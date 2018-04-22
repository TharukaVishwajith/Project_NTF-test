using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNTF.edu.uok.se.finalproject.mmsforntf.model
{
    
        public class Member
        {

            private String athleticId;
            private String fullName;
            private String namewithInitials;
            private String dob;
            private String NICNo;
            private String address;
            private int telNo;
            private int mobileNo;
            private String occupation;
            private String email;
            private String DANorGUP;
            private String kukkiwonNo;
            private String belt;
            private String club;
            private String coacher;

            public Member()
            {
            }

            public Member(String athleticId, String fullName, String namewithInitials, String dob, String NICNo, String address, int telNo, int mobileNo, String occupation, String email, String DANorGUP, String kukkiwonNo, String belt, String club, String coacher)
            {
                this.AthleticId = athleticId;
                this.FullName = fullName;
                this.NamewithInitials = namewithInitials;
                this.Dob = dob;
                this.NICNo1 = NICNo;
                this.Address = address;
                this.TelNo = telNo;
                this.MobileNo = mobileNo;
                this.Occupation = occupation;
                this.Email = email;
                this.DANorGUP1 = DANorGUP;
                this.KukkiwonNo = kukkiwonNo;
                this.Belt = belt;
                this.Club = club;
                this.Coacher = coacher;
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

            public string FullName
            {
                get
                {
                    return fullName;
                }

                set
                {
                    fullName = value;
                }
            }

            public string NamewithInitials
            {
                get
                {
                    return namewithInitials;
                }

                set
                {
                    namewithInitials = value;
                }
            }

            public string Dob
            {
                get
                {
                    return dob;
                }

                set
                {
                    dob = value;
                }
            }

            public string NICNo1
            {
                get
                {
                    return NICNo;
                }

                set
                {
                    NICNo = value;
                }
            }

            public string Address
            {
                get
                {
                    return address;
                }

                set
                {
                    address = value;
                }
            }

            public int TelNo
            {
                get
                {
                    return telNo;
                }

                set
                {
                    telNo = value;
                }
            }

            public int MobileNo
            {
                get
                {
                    return mobileNo;
                }

                set
                {
                    mobileNo = value;
                }
            }

            public string Occupation
            {
                get
                {
                    return occupation;
                }

                set
                {
                    occupation = value;
                }
            }

            public string Email
            {
                get
                {
                    return email;
                }

                set
                {
                    email = value;
                }
            }

            public string DANorGUP1
            {
                get
                {
                    return DANorGUP;
                }

                set
                {
                    DANorGUP = value;
                }
            }

            public string KukkiwonNo
            {
                get
                {
                    return kukkiwonNo;
                }

                set
                {
                    kukkiwonNo = value;
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

            public string Club
            {
                get
                {
                    return club;
                }

                set
                {
                    club = value;
                }
            }

            public string Coacher
            {
                get
                {
                    return coacher;
                }

                set
                {
                    coacher = value;
                }
            }
    }
}
