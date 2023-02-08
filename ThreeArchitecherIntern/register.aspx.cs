using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserSchema;
using UserDal;
using UserBal;

namespace ThreeArchitecherIntern
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                //gvDisplay.Visible = false;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Button2.Text == "Register")
                {
                    InsertData();
                }
                //else if (Button2.Text == "Update")
                //{
                //    int Id = int.Parse(gvDisplay.Rows[gvDisplay.SelectedIndex].Cells[0].Text);
                //    UpdateData(Id);
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Response.Redirect("login.aspx");
        }
        public void InsertData()
        {
            UserBal.Class1 objBal = new UserBal.Class1();
            objBal.Insert(txtname.Text, txtemail.Text, txtpass.Text, txtmob.Text, RadioButtonList1.SelectedValue);
        }
    }
}