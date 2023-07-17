using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class ClsCommercial : ClsBuilding
    {
        private int squareFeet;
        private int parkingSpaces;
        private decimal rentPerSquareFoot;

        public ClsCommercial() : base()
        {
        }

        public ClsCommercial(string addr, decimal price, decimal payment, decimal tax, decimal insur, DateTime date, int type)
            : base(addr, price, payment, tax, insur, date, type)
        {
            buildingType = type;
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

        public int ParkingSpaces
        {
            get
            {
                return parkingSpaces;
            }
            set
            {
                parkingSpaces = value;
            }
        }

        public decimal RentPerSquareFoot
        {
            get
            {
                return rentPerSquareFoot;
            }
            set
            {
                if (value > 0M)
                    rentPerSquareFoot = value;
            }
        }

        public override string RemoveSnow()
        {
            return "Called Acme Snow Plowing: 803.234.5566";
        }
    }
}
