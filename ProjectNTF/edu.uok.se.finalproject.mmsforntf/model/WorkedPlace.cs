using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.model
{
    class WorkedPlace
    {
        String place;
        String startedDate;
        String endDate;
        String athleticId;

        public WorkedPlace() { }

        public WorkedPlace(String place, String startedDate, String endDate, String athleticId)
        {
            this.Place = place;
            this.StartedDate = startedDate;
            this.EndDate = endDate;
            this.AthleticId = athleticId;
        }

        public string Place
        {
            get
            {
                return place;
            }

            set
            {
                place = value;
            }
        }

        public string StartedDate
        {
            get
            {
                return startedDate;
            }

            set
            {
                startedDate = value;
            }
        }

        public string EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
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
