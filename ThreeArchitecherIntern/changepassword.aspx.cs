using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using UserBal;

namespace ThreeArchitecherIntern
{
    public partial class changepassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        byte up;
        protected void Button1_Click(object sender, EventArgs e)
        {
            UserBal.Class1 objBal = new UserBal.Class1();
            DataSet result  =  objBal.Showpass(Convert.ToInt32(Session["id"]));
            DataSet ds = new DataSet();
            ds = result;
            if (ds.Tables[0].Rows.Count==1)
            {
                if (oldpassword.Text == result.Tables[0].Rows[0]["password"].ToString())
                {
                    up = 1;
                }
            }
            if (up == 1)
            {
                //UserBal.Class1 objBal = new UserBal.Class1();
                string pass = newpassword.Text;
                int results = objBal.UpdatePassword(Convert.ToInt32(Session["id"]),pass);
                if (results > 0)
                {
                    Response.Write("<script> alert('Update Successful');window.location.assign('/changepassword.aspx');</script>");
                }
            }
            else
            {
                Response.Write("<script> alert('Please Enter Correct Password');window.location.assign('/changepassword.aspx');</script>");
            }

        }

    }
}