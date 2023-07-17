using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Livingroom : CallMaid
    {
        private int tables;
        private int chairs;
        private int couch;

        public Livingroom() : base()
        {

        }

        public Livingroom(string loc, int slry, double wrktime, int wrkScale, int rmtype)
            : base(loc, slry, wrktime, wrkScale, rmtype)
        {
            roomType = rmtype;
        }
        public override string CleaningApartament()
        {
            return "The livingroom is clean";
        }

        public int Tables
        {
            get { return tables; }
            set
            {
                if (value > 0)
                    tables = value;
            }
        }
        public int Chairs
        {
            get { return chairs; }
            set
            {
                if (value > 0)
                    chairs = value;
            }
        }
        public int Couch
        {
            get { return couch; }
            set
            {
                if (value > 0)
                    couch = value;
            }
        }
    }
}
