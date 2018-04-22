using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.model
{
    class Match
    {
        String athleticId;
        String matchName;
        String venue;
        String date;
        String medal;
        String country;

        public Match() { }

        public Match(String athleticId, String matchName, String venue, String date, String medal)
        {
            this.athleticId = athleticId;
            this.matchName = matchName;
            this.venue = venue;
            this.date = date;
            this.medal = medal;
        }
        public Match(String athleticId, String matchName, String venue, String date, String medal,String country)
        {
            this.athleticId = athleticId;
            this.matchName = matchName;
            this.venue = venue;
            this.date = date;
            this.medal = medal;
            this.country = country;
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

        public string MatchName
        {
            get
            {
                return matchName;
            }

            set
            {
                matchName = value;
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

        public string Medal
        {
            get
            {
                return medal;
            }

            set
            {
                medal = value;
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
    }
}
