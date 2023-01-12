using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Fall20B5_Q3.DAL
{
    public class ProductDAO
    {
        public void AddProduct(Product p, int s, int c)
        {
            string query = @"insert into Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, Discontinued) values (@name, @sid, @cid, @quan, @price, @stock, @dis)";
            SqlParameter[] param = new SqlParameter[] {new SqlParameter("@name", p.ProductName),
                                                        new SqlParameter("@sid", s),
                                                        new SqlParameter("@cid", c),
                                                        new SqlParameter("@quan", p.QuantityPerUnit),
                                                        new SqlParameter("@price", p.UnitPrice),
                                                        new SqlParameter("@stock", p.UnitInStock),
                                                        new SqlParameter("@dis", p.Discontinued)};
            DAO.CrudDataBySQL(query, param);
        }
    }
}