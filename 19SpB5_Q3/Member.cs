using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19SpB5_Q3
{
    public class Member
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int RegionNo { get; set; }
        public int CorpNo { get; set; }

        public Member(string lastName, string firstName, int regionNo, int corpNo)
        {
            LastName = lastName;
            FirstName = firstName;
            RegionNo = regionNo;
            CorpNo = corpNo;
        }
    }
}