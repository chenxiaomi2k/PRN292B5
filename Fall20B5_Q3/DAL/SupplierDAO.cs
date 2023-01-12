using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Fall20B5_Q3.DAL
{
    public class SupplierDAO
    {
        public List<Supplier> GetSuppliers()
        {
            string query = "select * from Suppliers";
            DataTable dt = DAO.GetDataBySql(query);
            List<Supplier> list = new List<Supplier>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Supplier(Convert.ToInt32(dr["SupplierID"]),
                                        dr["CompanyName"].ToString()));
            }
            return list;
        }
    }
}