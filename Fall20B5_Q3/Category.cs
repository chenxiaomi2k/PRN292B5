using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fall20B5_Q3
{
    public class Category
    {
        public int Cid { get; set; }
        public string Cname { get; set; }

        public Category(int cid, string cname)
        {
            Cid = cid;
            Cname = cname;
        }

        public override string ToString()
        {
            return Cname;
        }
    }
}