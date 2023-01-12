using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fall20B5_Q2
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
        public string QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int UnitOnOrder { get; set; }
        public int ReOrderLevel { get; set; }
        public string Discontinued { get; set; }

        public Product()
        {
        }

        public Product(int productid, string productname, string companyname, string categoryname, string quantityperunit, double unitprice, int unitinstock, int unitonorder, int reorderlevel, string discontinued)
        {
            ProductId = productid;
            ProductName = productname;
            CompanyName = companyname;
            CategoryName = categoryname;
            QuantityPerUnit = quantityperunit;
            UnitPrice = unitprice;
            UnitInStock = unitinstock;
            UnitOnOrder = unitonorder;
            ReOrderLevel = reorderlevel;
            Discontinued = discontinued;
        }
    }
}
