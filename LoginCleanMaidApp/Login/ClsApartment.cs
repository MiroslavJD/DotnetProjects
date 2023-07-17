using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class ClsApartment : ClsBuilding
    {
        private int units;
        private decimal rentPerUnit;
        private double occupancyRate;

        public ClsApartment() : base()
        {
        }

        public ClsApartment(string addr, decimal price, decimal payment, decimal tax, decimal insur, DateTime date, int type)
            : base(addr, price, payment, tax, insur, date, type)
        {
            buildingType = type;
        }

        public int Units
        {
            get
            {
                return units;
            }
            set
            {
                if (value > 0)
                    units = value;
            }
        }
        public decimal RentPerUnit
        {
            get
            {
                return rentPerUnit;
            }
            set
            {
                if (value > 0M)
                    rentPerUnit = value;
            }
        }
        public double OccupancyRate
        {
            get
            {
                return occupancyRate;
            }
            set
            {
                if (value > 0.0)
                    occupancyRate = value;
            }
        }

        public override string RemoveSnow()
        {
            return "Called Rolling Snow Plowing: 804.521.11566";
        }
              
    }
}

