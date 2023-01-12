using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWeb
{
    public class Category
    {
        public int CateId { get; set; }
        public string CateName { get; set; }
        public string CateDes { get; set; }

        public Category()
        {
        }

        public Category(int cateId, string cateName, string cateDes)
        {
            CateId = cateId;
            CateName = cateName;
            CateDes = cateDes;
        }

        public override string ToString()
        {
            return CateName;
        }
    }
}