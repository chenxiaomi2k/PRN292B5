using Fall20B5_Q3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fall20B5_Q3
{
    public partial class add : System.Web.UI.Page
    {
        ProductDAO dao = new ProductDAO();
        SupplierDAO sdao = new SupplierDAO();
        CategoryDAO cdao = new CategoryDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            sup.DataSource = sdao.GetSuppliers();
            sup.DataBind();
            cate.DataSource = cdao.GetCategories();
            cate.DataBind();
        }

        protected void addproduct_Click(object sender, EventArgs e)
        {
            string produtname = pname.Text;
            int sid = sup.SelectedIndex + 1;
            int cid = cate.SelectedIndex + 1;
            string quantity = quan.Text;
            double unitprice = Convert.ToDouble(price.Text);
            int unitinstock = Convert.ToInt32(unit.Text);
            string discontinued = dis.Checked.ToString();           
            Product p = new Product(produtname, sid, cid, quantity, unitprice, unitinstock, discontinued);
            dao.AddProduct(p, sid, cid);
        }
    }
}