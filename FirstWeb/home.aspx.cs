using FirstWeb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWeb
{
    public partial class home : System.Web.UI.Page
    {
        AccountDAO dao = new AccountDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                view.DataSource = dao.GetAllAccount();
                view.DataBind();
            }           
        }

        protected void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(type.SelectedValue.Equals("acc"))
            {
                view.DataSource = dao.GetAllAccount();
                view.DataBind();
            }
            if (type.SelectedValue.Equals("empl"))
            {
                view.DataSource = dao.GetAllEmployee();
                view.DataBind();
            }
            if (type.SelectedValue.Equals("cus"))
            {
                view.DataSource = dao.GetAllCustomer();
                view.DataBind();
            }
        }
    }
}