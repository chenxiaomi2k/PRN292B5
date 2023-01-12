using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fall20B5_Q3
{
    public class Supplier
    {
        public int Sid { get; set; }
        public string Sname { get; set; }

        public Supplier(int sid, string sname)
        {
            Sid = sid;
            Sname = sname;
        }

        public override string ToString()
        {
            return Sname;
        }
    }
}