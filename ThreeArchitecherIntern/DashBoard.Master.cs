using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThreeArchitecherIntern
{
    public partial class DashBoard : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = " Welcome " + Session["name"];
            if(!this.IsPostBack)
            {
                bindgrid();
            }
            if (Session["usertype"].Equals("Admin"))
            {
               LinkButton1.Visible=false; 
               LinkButton2.Visible=false; 
               LinkButton3.Visible=false; 
               LinkButton4.Visible=false;
                LinkButton5.Visible=true;
                Image1.Visible=true;
                Label1.Visible=true;

            }
        }

        private void bindgrid()
        {
            UserBal.Class1 objBal = new UserBal.Class1();
            DataSet result = objBal.ShowImage(Convert.ToInt32(Session["id"]));
            DataSet ds = new DataSet();
            ds = result;
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                string url = ds.Tables[0].Rows[i]["image"].ToString();
                Image1.ImageUrl = url;
            }
        }
    }
}