using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using UserSchema;

namespace UserDal
{
    public class Class1
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
        SqlCommand cmd;
        // DataTable dt;
        public void InsertData(string Name, string Email, string Password, string Mobile, string Gender)
        {
            try
            {
                using (cmd = new SqlCommand("Threetireprocedure", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Insert2");
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@password", Password);
                    cmd.Parameters.AddWithValue("@mob", Mobile);
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    cmd.Parameters.AddWithValue("@usertype", "User");
                    cmd.Parameters.AddWithValue("@image", "~/image/hello.jpg");
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public void UpdateData(string Id, string Name, string Mobile, string Gender, string UserType, string Image)
        {
            try
            {
                using (cmd = new SqlCommand("Threetireprocedure", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@Action", "UpdateAdminpage2");
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@mob", Mobile);
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    cmd.Parameters.AddWithValue("@usertype", UserType);
                    cmd.Parameters.AddWithValue("@image", Image);
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable BindGrid()
        {
            try
            {
                using (cmd = new SqlCommand("Threetireprocedure", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "selectadmin2");
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public int DeleteData(int Id)
        {
            try
            {
                using (cmd = new SqlCommand("Threetireprocedure", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "delete2");
                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(Id));
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public DataSet LoginUser(string Email, string Password)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("Threetireprocedure", con))
                {
                    cmd.Parameters.AddWithValue("@Action", "login2");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@password", Password);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    con.Close();
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public DataSet showUser(int Id)
        {
            try
            {
                using (cmd = new SqlCommand("Threetireprocedure", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "selectUser2");
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(Id));
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public DataSet ShowUserDetails(int id)
        {
            try
            {
                using (cmd = new SqlCommand("Threetireprocedure", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "selectUserdetails2");
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }
        public int UpdateDetails(int id, string Name, string Email, string Mobile, string Gender)
        {
            try
            {
                using (cmd = new SqlCommand("Threetireprocedure", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "UpdateDetails2");
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@mob", Mobile);
                    cmd.Parameters.AddWithValue("@gender", Gender);
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }
        public DataSet SelectPassword(int id)
        {
            try
            {
                using (cmd = new SqlCommand("Threetireprocedure", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "selectPass");
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public int UpdatePassword(int id, string Password)
        {
            try
            {
                using (cmd = new SqlCommand("Threetireprocedure", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "changepass2");
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                    cmd.Parameters.AddWithValue("@password", Password);
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public int UpdateImage(int id, string Image)
        {
            try
            {
                using (cmd = new SqlCommand("Threetireprocedure", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "UpdateImage2");
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                    cmd.Parameters.AddWithValue("@image", Image);
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public DataSet ShowImage(int id)
        {
            try
            {
                using (cmd = new SqlCommand("Threetireprocedure", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "selectImg");
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));              
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}