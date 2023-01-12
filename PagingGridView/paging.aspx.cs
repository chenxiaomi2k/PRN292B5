using PagingGridView.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PagingGridView
{
    public partial class paging : System.Web.UI.Page
    {
        RegionDAO dao = new RegionDAO();
        MemberDAO mdao = new MemberDAO();
        CorporationDAO cdao = new CorporationDAO();
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
            regionList.Items.Add("All regions");
            corpList.DataSource = cdao.GetAllCorporations();
            corpList.DataValueField = "CorpNo";
            corpList.DataTextField = "CorpName";
            corpList.DataBind();
            corpList.Items.Add("All corporations");
            member.DataSource = mdao.GetMembers();
            member.DataBind();
            regionList.SelectedIndex = 9;
            corpList.SelectedValue = "All corporations";
        }

        protected void regionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(regionList.SelectedIndex == 9)
            {
                corpList.DataSource = cdao.GetAllCorporations();
                corpList.DataValueField = "CorpNo";
                corpList.DataTextField = "CorpName";
                corpList.DataBind();
                corpList.Items.Add("All corporations");
                corpList.SelectedValue = "All corporations";
                member.DataSource = mdao.GetMembers();
                member.DataBind();
            }
            else
            {
                corpList.DataSource = cdao.GetCorporations(regionList.SelectedIndex + 1);
                corpList.DataBind();
                corpList.Items.Add("All corporations");
                corpList.SelectedValue = "All corporations";
                member.DataSource = mdao.GetMembersByRegion(regionList.SelectedIndex + 1);
                member.DataBind();
            }            
        }

        protected void corpList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            member.DataSource = mdao.GetMembersByRegionAndCorp(regionList.SelectedIndex + 1, Convert.ToInt32(corpList.SelectedValue));
            member.DataBind();
        }

        protected void member_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            member.PageIndex = e.NewPageIndex;
            member.DataSource = mdao.GetMembers();
            member.DataBind();
        }

        protected void pagesize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(pagesize.SelectedValue.Equals("20"))
            {
                member.PageSize = 20;
            }
            if (pagesize.SelectedValue.Equals("40"))
            {
                member.PageSize = 40;
            }
            if (pagesize.SelectedValue.Equals("100"))
            {
                member.PageSize = 100;
            }
            if (regionList.SelectedIndex == 9)
            {
                corpList.DataSource = cdao.GetAllCorporations();
                corpList.DataValueField = "CorpNo";
                corpList.DataTextField = "CorpName";
                corpList.DataBind();
                corpList.Items.Add("All corporations");
                corpList.SelectedValue = "All corporations";
                member.DataSource = mdao.GetMembers();
                member.DataBind();
            }
            else
            {
                corpList.DataSource = cdao.GetCorporations(regionList.SelectedIndex + 1);
                corpList.DataBind();
                corpList.Items.Add("All corporations");
                corpList.SelectedValue = "All corporations";
                member.DataSource = mdao.GetMembersByRegion(regionList.SelectedIndex + 1);
                member.DataBind();
            }
        }
    }
}