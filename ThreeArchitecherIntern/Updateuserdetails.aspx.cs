using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using UserBal;

namespace ThreeArchitecherIntern
{
    public partial class Updateuserdetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                getdata();
            }

        }
        private void getdata()
        {
            UserBal.Class1 objBal = new UserBal.Class1();
            DataSet Result = objBal.ShowUserDetails(Convert.ToInt32(Session["id"]));
            DataSet ds = new DataSet();
            ds = Result;
            if (ds.Tables[0].Rows.Count > 0)
            {
                name.Text = Result.Tables[0].Rows[0]["name"].ToString();
                email.Text = Result.Tables[0].Rows[0]["email"].ToString();
                mobile.Text = Result.Tables[0].Rows[0]["mob"].ToString();
                RR1.SelectedValue = Result.Tables[0].Rows[0]["gender"].ToString();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            UserBal.Class1 objBal = new UserBal.Class1();
            int Result = objBal.UpdateDetails(Convert.ToInt32(Session["id"]), name.Text, email.Text, mobile.Text, RR1.SelectedValue);
            if (Result != 0)
            {
                Response.Write("<script> alert('Update Successful');window.location.assign('/Updateuserdetails.aspx');</script>");
            }
        }
    }
}