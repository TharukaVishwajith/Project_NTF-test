using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.model
{
    class Course
    {
        String country;
        String courseName;
        String venue;
        String discription;
        String date;
        String athleticId;

        public Course(String country, String courseName, String venue, String discription, String date , String athleticId)
        {
            this.country = country;
            this.courseName = courseName;
            this.venue = venue;
            this.discription = discription;
            this.date = date;
            this.athleticId = athleticId;
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

        public string CouseName
        {
            get
            {
                return courseName;
            }

            set
            {
                courseName = value;
            }
        }

        public string Venue
        {
            get
            {
                return venue;
            }

            set
            {
                venue = value;
            }
        }

        public string Discription
        {
            get
            {
                return discription;
            }

            set
            {
                discription = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string AthleticId
        {
            get
            {
                return athleticId;
            }

            set
            {
                athleticId = value;
            }
        }
    }
}
