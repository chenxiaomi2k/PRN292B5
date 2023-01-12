using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWeb
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public string CateName { get; set; }

        public Product()
        {
        }

        public Product(int productId, string productName, double unitPrice, string cateName)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            CateName = cateName;
        }
    }
}