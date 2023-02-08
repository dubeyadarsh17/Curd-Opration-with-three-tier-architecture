using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using UserBal;
using UserDal;

namespace ThreeArchitecherIntern
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            UserBal.Class1 objBal = new UserBal.Class1();
            DataSet result = objBal.login(TextBox1.Text, TextBox2.Text);
            DataSet ds = new DataSet();
            ds = result;
            if(ds.Tables[0].Rows.Count > 0)
            {
                Session["id"] = ds.Tables[0].Rows[0][0].ToString();
                Session["name"] = ds.Tables[0].Rows[0][1].ToString();
                Session["usertype"] = ds.Tables[0].Rows[0][6].ToString();
                if (Session["usertype"].Equals("User"))
                {
                    Response.Redirect("Userpage.aspx");
                }
                else
                {
                    Response.Redirect("admin.aspx");
                }
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
    }
}