using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class ClsHome : ClsBuilding
    {
        private int squareFeet;
        private int bedrooms;
        private double bathrooms;
        private decimal rentPerMonth;

        public ClsHome() : base()
        {
        }
        public ClsHome(string addr, decimal price, decimal payment, decimal tax, decimal insur, DateTime date, int type)
            : base(addr, price, payment, tax, insur, date, type)
        {
            buildingType = 3;
        }

        public int SquareFeet
        {
            get
            {
                return squareFeet;
            }
            set
            {
                if (value > 0)
                    squareFeet = value;
            }
        }
        public int BedRooms
        {
            get
            {
                return bedrooms;
            }
            set
            {
                bedrooms = value;
            }
        }
        public double BathRooms
        {
            get
            {
                return bathrooms;
            }
            set
            {
                bathrooms = value;
            }
        }
        public decimal RentPerMonth
        {
            get
            {
                return rentPerMonth;
            }
            set
            {
                if (value > 0M)
                    rentPerMonth = value;
            }
        }

        public override string RemoveSnow()
        {
            return "Home: No snow removal service available";
        }
    }
}
