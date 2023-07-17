using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class CallMaid : ClsApartment
    {
        public const int Bathroom = 2;
        public const int Bedroom = 1;
        public const int Livingroom = 1;
        public const int Kitchen = 1;

        protected string location;
        protected int salary;
        protected int workScale;
        protected double worktime;
        protected int roomType;

        string[] ApartmentZone = {" ","Bathroom", "Bedroom", "Livingroom", "Kitchen"};

        public CallMaid()
        {
            location = "Apartment";
        }

        public CallMaid(string loc, int slry, double wrktime, int wrkScale, int rmtype) : this()
        {
            if (loc.Equals(" ") == false)
                location = loc;

            salary = slry;
            worktime = wrktime;
            workScale = wrkScale;
            roomType = rmtype;

        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value >= 100M && value <= 200M)
                    salary = value;
            }
        }
        public double Worktime
        {
            get { return worktime; }
            set
            {
                if (value >= 1 && value <= 2)
                    worktime = value;
            }
        }
        public int WorkScale
        {
            get { return workScale; }
            set
            {
                if (value >= 1M && value <= 10M)
                    workScale = value;
            }
        }
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                if (value.Length != 0)
                    location = value;
            }
        }

        public int RoomType
        {
            get { return roomType; }
            set {
                if (value >= Livingroom && value <= Kitchen)
                    roomType = value;
            }
        }

        public void LocationSummary(string[] show)
        {
            show[0] = "Location type: " + location + ", Salary: " + salary.ToString("C") + ", Work Scale: " + workScale.ToString();
            show[1] = "Work time: " + worktime.ToString();
            show[2] = " ";
            show[3] = "---";
        }

        public virtual string CleaningApartament()
        {
            return " The maid is cleaning.";
        }


    }
}


