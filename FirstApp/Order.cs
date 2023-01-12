using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    public delegate void OnTotalChange();
    class Order : IComparer<Product>
    {
        public event OnTotalChange TotalChange;
        public int orderID { get; set; }
        public DateTime orderDate { get; set; }
        public string customer { get; set; }

        private Dictionary<Product, int> items = new Dictionary<Product, int>();
        
        public Order()
        {
        }

        public Order(int orderID, DateTime orderDate, string customer, Dictionary<Product, int> items)
        {
            this.orderID = orderID;
            this.orderDate = orderDate;
            this.customer = customer;
            this.items = items;
        }

        public void Input()
        {
            Console.Write("Order ID: ");
            orderID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Date: ");
            orderDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Customer: ");
            customer = Convert.ToString(Console.ReadLine());                      
        }

        public void AddProduct(Product p, int quantity)
        {
            if (items.ContainsKey(p))
            {
                items[p] = items[p] + quantity;
                TotalChange();
            }
            else
            {
                items.Add(p, quantity);
                TotalChange();
            }
        }

        public void RemoveProduct(Product p)
        {
            Console.Write("Enter product to remove: ");
            string name = Convert.ToString(Console.ReadLine());
            if (name.Equals(p.productName))
            {
                items.Remove(p);
                Console.WriteLine("Remove Product successfull");
                TotalChange();
            }
            else
            {
                Console.WriteLine("Cant find product");
            }
        }

        public void RemoveProduct(Product p, int quantity)
        {
            Console.Write("Enter product to remove: ");
            string name = Convert.ToString(Console.ReadLine());            
            if(items[p] > quantity)
            {
                items[p] = items[p] - quantity;
                Console.WriteLine("Quantity changed");
                TotalChange();
            }
            else
            {
                items.Remove(p);
            }
        }

        public void Sort()
        {
            Console.WriteLine("Sorted:");
            List<Product> list = new List<Product>(items.Keys);
            list.Sort(Compare);
            foreach(Product p in list)
            {
                Console.WriteLine(p.productID);
            }
        }

        public void NewSort()
        {
            Console.WriteLine("New sort:");
            //IEnumerable<KeyValuePair<Product, int>> products = items.OrderBy();
        }

        public int Compare(Product x, Product y)
        {
            return x.productID.CompareTo(y.productID);
        }

        public void SortByPrice()
        {
            Console.WriteLine("Sorted:");
            List<Product> list = new List<Product>(items.Keys);
            list.Sort(ComparePrice);
            foreach (Product p in list)
            {
                Console.WriteLine(p.ProductPrice);
            }
        }

        public int ComparePrice(Product x, Product y)
        {
            return x.ProductPrice.CompareTo(y.ProductPrice);
        }

        public void Message()
        {
            Console.WriteLine("Tong tien da thay doi");
        }
    }
}
