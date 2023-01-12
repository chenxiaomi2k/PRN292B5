using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19SpB5_Q3
{
    public class Region
    {
        public int RegionNo { get; set; }
        public string RegionName { get; set; }

        public Region(int regionNo, string regionName)
        {
            RegionNo = regionNo;
            RegionName = regionName;
        }

        public override string ToString()
        {
            return RegionName;
        }
    }
}