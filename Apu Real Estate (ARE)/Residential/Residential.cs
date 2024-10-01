using System;
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
        // Private fields
        private int numOfRooms;
        private int numOfFloors;
        private NotUsed notUsed;
        private int constructionYear;

        // Properties to access private fields
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

        public override string ToString()
        {
            return $"Floor {numOfFloors.ToString()}m^2, NumRoom {numOfRooms.ToString()} ,isUsed: {notUsed}, constructionYear: {constructionYear.ToString()}.";
        }
    }
}
