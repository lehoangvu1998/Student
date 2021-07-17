using Project1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.DAL
{
    public class dal_phongban : DBConnect
    {
        public DataTable getPhongban()
        {
            SqlDataAdapter dt = new SqlDataAdapter("select* from PHONGBAN", conn);
            DataTable da = new DataTable();
            dt.Fill(da);
            return da;
        }

        public bool themphongban(dto_phongban pb)
        {
            try
            {
                conn.Open();
                string sql = string.Format("insert into PHONGBAN(MAPHONGBAN, TENPHONGBAN) values ('{0}', '{1}')", pb.Maphongban, pb.Phongban);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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

        public bool suaphongban(dto_phongban pb)
        {
            try
            {
                conn.Open();
                string sql = string.Format("update PHONGBAN set TENPHONGBAN ='{1}' where MAPHONGBAN={0}", pb.Phongban, pb.Maphongban);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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

        public bool delete(dto_phongban pb)
        {
            try
            {
                conn.Open();
                string sql = string.Format("delete from PHONGBAN where MAPHONGBAN={0}", pb.Maphongban);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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
