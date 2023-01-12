using _19SpB5_Q3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _19SpB5_Q3
{
    public partial class home : System.Web.UI.Page
    {
        RegionDAO dao = new RegionDAO();
        CorporationDAO cdao = new CorporationDAO();
        MemberDAO mdao = new MemberDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            regionList.DataSource = dao.GetRegions();
            regionList.DataBind();
            corpList.DataSource = cdao.GetCorporations(1);
            corpList.DataValueField = "CorpNo";
            corpList.DataTextField = "CorpName";
            corpList.DataBind();
        }

        protected void regionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int no = regionList.SelectedIndex + 1;
            corpList.DataSource = cdao.GetCorporations(no);
            corpList.DataValueField = "CorpNo";
            corpList.DataTextField = "CorpName";
            corpList.DataBind();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            string FirstName = firstName.Text;
            string LastName = lastName.Text;
            int reno = regionList.SelectedIndex + 1;
            string cono = corpList.SelectedValue;
            int corpno = Convert.ToInt32(cono);
            Member m = new Member(LastName, FirstName, reno, corpno);
            mdao.AddMember(m);
        }
    }
}