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
        private readonly RealEstateContext m_context;

        public EstateDBManager()
        {
            m_context = new RealEstateContext();
        }

        public void AddEstate(Estate estate)
        {
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
            //because it needs address ID that match for foregn key
            entityEstate.AddressId = entityAdress.AddressId;
            m_context.Estates.Add(entityEstate);
            m_context.SaveChanges();
        }

        public void DeleteEstate(int id)
        {
            var estate = m_context.Estates
                .Include(e => e.Address)  // Include related Address
                .FirstOrDefault(e => e.ID == id);

            if (estate != null)
            {
                if (estate.Address != null)
                {
                    m_context.Addresses.Remove(estate.Address); // Remove related address
                }
                m_context.Estates.Remove(estate);
                m_context.SaveChanges();
            }
        }

        public List<Estate> GetAllEstates()
        {
            // Retrieve all estates and include the related Address entity
            var estates = m_context.Estates
                .Include(e => e.Address)  // Include related Address
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
                }).ToList();  // Execute the query and convert to list

            return estates;
        }

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
