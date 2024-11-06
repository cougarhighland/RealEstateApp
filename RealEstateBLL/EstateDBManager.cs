using Microsoft.EntityFrameworkCore;
using RealEstateDLL;
using RealEstateDLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL
{
    public class EstateDBManager
    {
        //field
        private readonly RealEstateContext m_context;
        //constructor
        public EstateDBManager()
        {
            m_context = new RealEstateContext();
        }

        /// <summary>
        /// Adds a new estate and its related address to the database.
        /// </summary>
        /// <param name="estate">The estate entity to add.</param>
        public void AddEstate(Estate estate)
        {
            //add Address first in order to generate Address ID
            var entityAdress = new RealEstateDLL.Entities.Address();
            entityAdress.street = estate.Address.Street;
            entityAdress.city = estate.Address.City;
            entityAdress.zipCode = estate.Address.ZipCode;
            entityAdress.country = (RealEstateDLL.Entities.Countries)estate.Address.Country;
            m_context.Addresses.Add(entityAdress);
            m_context.SaveChanges();

            var entityEstate = new RealEstateDLL.Entities.Estate();
            //entityEstate.ID = estate.ID;
            entityEstate.ImagePath = estate.ImagePath;
            entityEstate.LegalForm = (RealEstateDLL.Entities.LegalForm)estate.LegalForm;
            entityEstate.Category = (RealEstateDLL.Entities.EstateType)estate.EstateType;
            //foregn key for Address
            entityEstate.AddressId = entityAdress.AddressId;
            m_context.Estates.Add(entityEstate);
            m_context.SaveChanges();
        }

        /// <summary>
        /// Deletes an estate and its related address from the database based on the estate ID.
        /// </summary>
        /// <param name="id">The ID of the estate to delete.</param>
        public void DeleteEstate(int id)
        {
            var estate = m_context.Estates
                .Include(e => e.Address) 
                .FirstOrDefault(e => e.ID == id);

            if (estate != null)
            {
                if (estate.Address != null)
                {
                    // Remove related address
                    m_context.Addresses.Remove(estate.Address); 
                }
                //remove estate
                m_context.Estates.Remove(estate);
                m_context.SaveChanges();
            }
        }

        /// <summary>
        /// Retrieves all estates from the database, including related address information.
        /// </summary>
        /// <returns>A list of estates with their related addresses.</returns>
        public List<Estate> GetAllEstates()
        {
            // Retrieve all estates and include the related Address entity
            var estates = m_context.Estates
                .Include(e => e.Address)  
                .Select(e => new Estate
                {
                    ID = e.ID,
                    ImagePath = e.ImagePath,
                    LegalForm = (LegalForm)e.LegalForm,
                    EstateType = (EstateType)e.Category,
                    Address = new Address
                    {
                        Street = e.Address.street,
                        City = e.Address.city,
                        ZipCode = e.Address.zipCode,
                        Country = (Countries)e.Address.country 
                    }
                }).ToList(); 

            return estates;
        }

        /// <summary>
        /// Retrieves the ID of the latest added estate from the database.
        /// </summary>
        /// <returns>The ID of the latest estate or 0 if no estates exist.</returns>
        public int GetID()
        {
            var latestEstate = m_context.Estates.OrderByDescending(e => e.ID).FirstOrDefault();
            if(latestEstate != null)
            {
                return latestEstate.ID;
            }
            else
            {
                return 0;
            }
        }
  
    }
}
