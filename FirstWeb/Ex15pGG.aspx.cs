using FirstWeb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWeb
{
    public partial class Ex15pGG : System.Web.UI.Page
    {
        CategoryDAO dao = new CategoryDAO();
        ProductDAO pdao = new ProductDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
                view.DataSource = pdao.GetProductsByCateID(1);
                view.DataBind();
                list.SelectedIndex = 0;
            }
        }

        private void LoadData()
        {
            list.DataSource = dao.GetAllCategories();
            list.DataBind();
        }

        protected void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = list.SelectedIndex + 1;
            view.DataSource = pdao.GetProductsByCateID(id);
            view.DataBind();
        }
    }
}