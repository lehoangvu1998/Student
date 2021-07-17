using Project1.DTO;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Project1.DAL
{

    public class dal_login : DBConnect
    {
        //getRole 
        //getName
        //List contain {role, name}

        public List<dto_login> GetData(int maso)
        {
            List<dto_login> arr = new List<dto_login>();
            string query = "select HOTEN, ROLE, DIACHI from USERS where MAUSERS = " + maso;
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    arr.Add(new dto_login()
                    {
                        Name = rd.GetString(rd.GetOrdinal("HOTEN")),
                        Address = rd.GetString(rd.GetOrdinal("DIACHI")),
                        Role = rd.GetInt32(rd.GetOrdinal("ROLE"))
                    }); 
                }
            }
            catch { }
            finally { conn.Close(); }
            return arr;
        }

        public bool Login(int username, string password)
        {
            try
            {
                string sql = "select MAUSERS, PASS from USERS where MAUSERS = " + username + " and PASS = " + password;
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    return true;
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
