using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    public delegate void OnPriceChange();
    class Product
    {
        public event OnPriceChange PriceChange;
        public string productName { get; set; }
        public int productID { get; set; }

        private double productPrice;

        public double ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                if (!productPrice.Equals(value))
                {
                    PriceChange();
                    productPrice = value;
                }
            }
        }

        public Product()
        {
        }

        public Product(string productName, int productID, double productPrice)
        {
            this.productName = productName;
            this.productID = productID;
            this.productPrice = productPrice;
        }
        public void InputPro()
        {
            Console.Write("Product name: ");
            productName = Convert.ToString(Console.ReadLine());
            Console.Write("Pro ID: ");
            productID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Price: ");
            productPrice = Convert.ToDouble(Console.ReadLine());
        }
        public override string ToString()
        {
            return productName + " - " + productID + " - " + productPrice;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return productID;
        }

        public void Message()
        {
            Console.WriteLine("Tong tien trong order da thay doi");
        }
    }
}
