using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19SpB5_Q3
{
    public class Corporation
    {
        public int CorpNo { get; set; }
        public string CorpName { get; set; }
        public int RegionNo { get; set; }

        public Corporation(int corpNo, string corpName)
        {
            CorpNo = corpNo;
            CorpName = corpName;
        }

        public override string ToString()
        {
            return CorpName;
        }
    }
}