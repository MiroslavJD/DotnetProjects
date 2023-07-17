using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Kitchen : CallMaid
    {

        private int glasses;
        private int spoons;
        private int forks;
        private int plates;

        public Kitchen() : base()
        {
            
        }

        public Kitchen(string loc, int slry, double wrktime, int wrkScale,int rmtype)
            : base(loc, slry, wrktime, wrkScale, rmtype)
        {
            roomType = rmtype;

        }


        public override string CleaningApartament()
        {
            return "The kitchen is clean";
        }

        public int Glasses
        {
            get { return glasses; }
            set
            {
                if (value > 0)
                    glasses = value;
            }
        }
        public int Spoons
        {
            get { return spoons; }
            set
            {
                if (value > 0)
                    spoons = value;
            }
        }
        public int Forks
        {
            get { return forks; }
            set
            {
                if (value > 0)
                    forks = value;
            }
        }
        public int Plates
        {
            get { return plates; }
            set
            {
                if (value > 0)
                    plates = value;
            }
        }
    }
}
