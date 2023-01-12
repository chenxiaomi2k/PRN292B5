using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PagingGridView
{
    public class Member
    {
        public int MemberNo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpireDate { get; set; }

        public Member(int memberNo, string lastName, string firstName, DateTime issueDate, DateTime expireDate)
        {
            MemberNo = memberNo;
            LastName = lastName;
            FirstName = firstName;
            IssueDate = issueDate;
            ExpireDate = expireDate;
        }
    }
}