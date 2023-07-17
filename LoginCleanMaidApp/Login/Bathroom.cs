using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Bathroom : CallMaid
    {
        private int bathtub;

        public Bathroom() : base()
        {

        }

        public Bathroom(string loc, int slry, double wrktime, int wrkScale, int rmtype)
            : base(loc, slry, wrktime, wrkScale,rmtype)
        {

            roomType = rmtype;
        }

        public override string CleaningApartament()
        {
            return "The bathroom is clean";
        }

        public int Bathtub
        {
            get { return bathtub; }
            set
            {
                if (value > 0)
                    bathtub = value;
            }
        }
    }
}
