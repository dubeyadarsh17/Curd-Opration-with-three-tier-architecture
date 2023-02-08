using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using UserBal;
using UserDal;

namespace ThreeArchitecherIntern
{
    public partial class Userpage : System.Web.UI.Page
    {
        //string cs = ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;

        
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.ShowDataUser();
            }

        }
        private void ShowDataUser()
        {
            try
            {
                UserBal.Class1 objBal = new UserBal.Class1();
                Repeater1.DataSource = objBal.ShowDataUser(Convert.ToInt32(Session["id"]));
                Repeater1.DataBind();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Updateuserdetails.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("changepassword.aspx");
        }
        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("changepicture.aspx");
        }
    }
}