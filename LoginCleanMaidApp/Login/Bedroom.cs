using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Bedroom : CallMaid
    {

        private int bed;
        private int sheets;

        public Bedroom() : base()
        {

        }

        public Bedroom(string loc, int slry, double wrktime, int wrkScale, int rmtype)
            : base(loc,slry,wrktime,wrkScale,rmtype)
        {
            roomType = rmtype;
        }

        public override string CleaningApartament()
        {
            return "The Bathroom is clean";
        }

        public int Bed
        {
            get { return bed; }
            set
            {
                if (value > 0)
                    bed = value;
            }
        }
        public int Sheets
        {
            get { return sheets; }
            set
            {
                if (value > 0)
                    sheets = value;
            }
        }
    }
}
