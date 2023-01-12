using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19SpB5_Q1.Entity
{
    class Corporation
    {
        public int Corp_no { get; set; }
        public string Corp_name { get; set; }
        public string Street { get; set; }
        public string Region { get; set; }
        public DateTime expr_dt { get; set; }

        public Corporation()
        {
        }

        public Corporation(int corp_no, string corp_name, string street, string region, DateTime expr_dt)
        {
            Corp_no = corp_no;
            Corp_name = corp_name;
            Street = street;
            Region = region;
            this.expr_dt = expr_dt;
        }

        public Corporation(string corp_name, string street, DateTime expr_dt)
        {
            Corp_name = corp_name;
            Street = street;
            this.expr_dt = expr_dt;
        }
    }
}
