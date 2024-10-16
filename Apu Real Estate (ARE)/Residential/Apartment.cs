﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Residential
{
    public class Apartment: Residential
    {
        //fields
        private NotUsed notUsed;
        private int constructionYear;
        //properties
        public NotUsed NotUsed
        {
            get { return notUsed; }
            set { notUsed = value; }
        }

        public int ConstructionYear
        {
            get { return constructionYear; }
            set { constructionYear = value; }
        }
        //constructors
        public Apartment() { }
        public Apartment(NotUsed isUsed, int construction)
        {
            //set value of NotUsed and ConstructionYear by setters of Residential
            NotUsed = isUsed;
            ConstructionYear = construction;
        }
        //get details of residential estate
        public override string GetDetails()
        {
            return $"Residential,{ResidentialType},Floor {NumOfFloors.ToString()},Number of Room {NumOfRooms.ToString()},isUsed {notUsed},constructionYear {constructionYear.ToString()}";
        }
    }
}
