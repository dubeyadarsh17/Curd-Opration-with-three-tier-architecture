using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThreeArchitecherIntern
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }
        private void BindGrid()
        {
            try
            {
                UserBal.Class1 objBal = new UserBal.Class1();
                Repeater1.DataSource = objBal.BindGrid();
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Update")
            {
                try
                {
                    string Id = ((Label)e.Item.FindControl("Label7")).Text;
                    string Name = ((TextBox)e.Item.FindControl("TextBox1")).Text;
                    string Mobile = ((TextBox)e.Item.FindControl("TextBox2")).Text;
                    string Gender = ((RadioButtonList)e.Item.FindControl("RadioButtonList1")).SelectedValue;
                    string UserType = ((DropDownList)e.Item.FindControl("DropDownList1")).SelectedValue;
                    string Image = ((Image)e.Item.FindControl("Image2")).ImageUrl;
                    FileUpload FileUpload1 = (FileUpload)e.Item.FindControl("FileUpload1");
                    string path = "~/image/";
                    if (FileUpload1.HasFile)
                    {
                        path += FileUpload1.FileName;
                        FileUpload1.SaveAs(MapPath(path));
                    }
                    else
                    {
                        Image img = (Image)e.Item.FindControl("Image2") as Image;
                        path = img.ImageUrl;
                    }
                    UserBal.Class1 objBal = new UserBal.Class1();
                    objBal.UpdateAdmin(Id, Name, Mobile, Gender, UserType, Image = path);
                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                BindGrid();
            }

            if (e.CommandName.Equals("Delete"))
            {
                try
                {
                    int Id = int.Parse(((Label)e.Item.FindControl("Label7")).Text);
                    DeleteRecord(Id);
                   
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                BindGrid();
            }
           
        }

        protected void OnEdting(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            item.FindControl("lnkUpdate").Visible = true;
            item.FindControl("lnkCancel").Visible = true;
            item.FindControl("Label7").Visible = true;
            item.FindControl("TextBox1").Visible = true;
            item.FindControl("Label8").Visible = true;
            item.FindControl("TextBox2").Visible = true;
            item.FindControl("RadioButtonList1").Visible = true;
            item.FindControl("DropDownList1").Visible = true;
            item.FindControl("Image2").Visible = true;
            item.FindControl("FileUpload1").Visible = true;

            item.FindControl("lnkEdit").Visible = false;
            item.FindControl("lnkDelete").Visible = false;
            item.FindControl("Label1").Visible = false;
            item.FindControl("Label2").Visible = false;
            item.FindControl("Label3").Visible = false;
            item.FindControl("Label4").Visible = false;
            item.FindControl("Label5").Visible = false;
            item.FindControl("Image1").Visible = false;



        }
        //protected void OnUpdating(object sender, EventArgs e)
        //{
        //    try
        //    {


        //        RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
        //        //UserBal.Class1 objBal = new UserBal.Class1();
        //        Label Id = Repeater1.FindControl("Label7") as Label;
        //        TextBox Name = Repeater1.FindControl("TextBox1") as TextBox;
        //        TextBox Mobile = Repeater1.FindControl("TextBox2") as TextBox;
        //        RadioButtonList Gender = Repeater1.FindControl("RadioButtonList1") as RadioButtonList;
        //        DropDownList UserType = Repeater1.FindControl("DropDownList1") as DropDownList;
        //        Image image = Repeater1.FindControl("Image2") as Image;
        //        FileUpload FileUpload1 = Repeater1.FindControl("FileUpload1") as FileUpload;

        //        string path = "~/image/";
        //        if (FileUpload1.HasFile)
        //        {
        //            path += FileUpload1.FileName;
        //            FileUpload1.SaveAs(MapPath(path));
        //        }
        //        else
        //        {
        //            Image img = (Image)Repeater1.FindControl("Image2");
        //            path = img.ImageUrl;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        protected void OnCancel(object sender, EventArgs e)
        {
            RepeaterItem item = (sender as LinkButton).Parent as RepeaterItem;
            item.FindControl("lnkUpdate").Visible = false;
            item.FindControl("lnkCancel").Visible = false;
            item.FindControl("Label7").Visible = false;
            item.FindControl("TextBox1").Visible = false;
            item.FindControl("Label8").Visible = false;
            item.FindControl("TextBox2").Visible = false;
            item.FindControl("RadioButtonList1").Visible = false;
            item.FindControl("DropDownList1").Visible = false;
            item.FindControl("Image2").Visible = false;
            item.FindControl("FileUpload1").Visible = false;

            item.FindControl("lnkEdit").Visible = true;
            item.FindControl("lnkDelete").Visible = true;
            item.FindControl("Label1").Visible = true;
            item.FindControl("Label2").Visible = true;
            item.FindControl("Label3").Visible = true;
            item.FindControl("Label4").Visible = true;
            item.FindControl("Label5").Visible = true;
            item.FindControl("Image1").Visible = true;


        }
        private void DeleteRecord(int Id)
        {
            try
            {
                UserBal.Class1 objBAL = new UserBal.Class1();
                int Result = objBAL.DeleteAdmin(Id);
                if (Result > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data Deleted Successfully')", true);
                }
                //BindGrid();
                //Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}