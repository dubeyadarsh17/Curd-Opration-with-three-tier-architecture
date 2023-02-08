using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ThreeArchitecherIntern
{
    public partial class changepicture : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                imageupdate();
            }

        }
        private void imageupdate()
        {
            UserBal.Class1 objBal = new UserBal.Class1();
            DataSet result = objBal.ShowImage(Convert.ToInt32(Session["id"]));
            DataSet ds = new DataSet();
            ds = result;
            for(int i = 0; i < ds.Tables.Count; i++)
            {
                string url= ds.Tables[0].Rows[i]["image"].ToString();
                Image1.ImageUrl= url;
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (FileUpload1.PostedFile != null)
            {
                string strpath = Path.GetExtension(FileUpload1.FileName);
                if (strpath != ".jpg" && strpath != ".jpeg" && strpath != ".png")
                {

                    Label1.Text = "Please Select Image(jpg,jpeg,png) File";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    string fileing = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    FileUpload1.SaveAs(Server.MapPath("~/image/") + fileing);
                    UserBal.Class1 objBal = new UserBal.Class1();
                    string img = "~/image/" + fileing;
                    int result = objBal.UpdateImage(Convert.ToInt32(Session["id"]), img);
                    if (result > 0)
                    {
                        Response.Write("<script> alert('Update Successful');window.location.assign('/changepicture.aspx');</script>");
                    }
                }
            }
        }
    }
}
