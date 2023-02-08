using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDal;
using UserSchema;
using System.Data;
using System.Data.SqlClient;

namespace UserBal
{
    public class Class1
    {
        public void Insert(string Name,string Email,string Password,string Mobile,string Gender)
        {
            try
            {
                UserDal.Class1 objDal = new UserDal.Class1();
               objDal.InsertData(Name,Email,Password,Mobile,Gender);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateAdmin(string Id, string Name, string Mobile, string Gender, string UserType, string Image)
        {
            try
            {
                UserDal.Class1 objDal = new UserDal.Class1();
                objDal.UpdateData(Id,Name,Mobile,Gender,UserType,Image);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable BindGrid()
        {
            try
            {
                UserDal.Class1 objDal = new UserDal.Class1();
                return objDal.BindGrid();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteAdmin(int Id)
        {
            try
            {
                UserDal.Class1 objDAL = new UserDal.Class1();
                return objDAL.DeleteData(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet login(string Email,string Password)
        {
            try
            {
                UserDal.Class1 objDal = new UserDal.Class1();
                return objDal.LoginUser(Email,Password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ShowDataUser(int Id)
        {
            try
            {
                UserDal.Class1 objDal = new UserDal.Class1();
                return objDal.showUser(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ShowUserDetails(int id)
        {
            try
            {
                UserDal.Class1 objDal = new UserDal.Class1();
                return objDal.ShowUserDetails(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateDetails(int id, string Name, string Email, string Mobile, string Gender)
        {
            try
            {
                UserDal.Class1 objDal = new UserDal.Class1();
                return objDal.UpdateDetails(id,Name,Email,Mobile,Gender);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdatePassword(int id, string Password)
        {
            try
            {
                UserDal.Class1 objDal = new UserDal.Class1();
                return objDal.UpdatePassword(id, Password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Showpass(int id)
        {
            try
            {
                UserDal.Class1 objDal = new UserDal.Class1();
                return objDal.SelectPassword(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateImage(int id, string Image)
        {
            try
            {
                UserDal.Class1 objDal = new UserDal.Class1();
                return objDal.UpdateImage(id, Image);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ShowImage(int id)
        {
            try
            {
                UserDal.Class1 objDal = new UserDal.Class1();
                return objDal.ShowImage(id);
            }
            catch(Exception  ex)
            {
                throw ex;
            }
        }

    }
}
