using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fall20B5_Q3
{
    public class Product
    {
        public string ProductName { get; set; }
        public int Supplier { get; set; }
        public int Category { get; set; }
        public string QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public string Discontinued { get; set; }

        public Product()
        {
        }

        public Product(string productName, int supplier, int category, string quantityPerUnit, double unitPrice, int unitInStock, string discontinued)
        {
            ProductName = productName;
            Supplier = supplier;
            Category = category;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitInStock = unitInStock;
            Discontinued = discontinued;
        }
    }
}