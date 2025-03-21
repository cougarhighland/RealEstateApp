﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_.Residential
{
    public enum NotUsed
    {
        No,
        Yes
    }
    public abstract class Residential : Estate
    {
        // fields
        private int numOfRooms;
        private int numOfFloors;
        private NotUsed notUsed;
        private int constructionYear;

        // Properties
        public int NumOfRooms
        {
            get { return numOfRooms; }
            set { numOfRooms = value; }
        }

        public int NumOfFloors
        {
            get { return numOfFloors; }
            set { numOfFloors = value; }
        }

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
        // Method to get a string representation of the Residential estate
        public string GetDetails()
        {
            return $"Floor {numOfFloors.ToString()},Number of Room {numOfRooms.ToString()},isUsed {notUsed},constructionYear {constructionYear.ToString()}";
        }
    }
}
