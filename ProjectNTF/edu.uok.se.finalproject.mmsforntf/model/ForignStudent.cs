using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.model
{
    class ForignStudent
    {
        String name;
        String country;
        String belt;
        String coacherAtheleticId;

        public ForignStudent() { }

        public ForignStudent(String name,String country,String belt,String coacherAtheleticId)
        {
            this.name = name;
            this.country = country;
            this.belt = belt;
            this.CoacherAtheleticId = coacherAtheleticId;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string Belt
        {
            get
            {
                return belt;
            }

            set
            {
                belt = value;
            }
        }

        public string CoacherAtheleticId
        {
            get
            {
                return coacherAtheleticId;
            }

            set
            {
                coacherAtheleticId = value;
            }
        }
    }
}
