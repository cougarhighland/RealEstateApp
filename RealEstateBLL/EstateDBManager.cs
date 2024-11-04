using Microsoft.EntityFrameworkCore;
using RealEstateDLL;
using RealEstateDLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var entityEstate = new RealEstateDLL.Entities.Estate();
            entityEstate.ID = estate.ID;
            entityEstate.ImagePath = estate.ImagePath;
            entityEstate.LegalForm = (RealEstateDLL.Entities.LegalForm)estate.LegalForm;

            entityEstate.Address = new RealEstateDLL.Entities.Address();
            entityEstate.Address.street = estate.Address.Street;
            entityEstate.Address.city = estate.Address.City;
            entityEstate.Address.zipCode = estate.Address.ZipCode;
            entityEstate.Address.country = (RealEstateDLL.Entities.Countries)estate.Address.Country;
          

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
                m_context.Estates.Remove(estate);
                m_context.SaveChanges();
            }
        }
  
    }
}
