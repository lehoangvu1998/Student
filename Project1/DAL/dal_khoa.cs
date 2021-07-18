using System.Data;
using System.Data.SqlClient;

namespace Project1.DAL
{
    public class dal_khoa : DBConnect
    {
        public DataSet LoadPhongban()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PHONGBAN", conn);
                da.Fill(ds);
                return ds;
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetData()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select kh.MAKHOA, kh.TENKHOA, pb.TENPHONGBAN, kh.SDT from KHOA kh, PHONGBAN pb where kh.MAPHONGBAN = pb.MAPHONGBAN", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //public Dictionary<int, string> FillCombo()
        //{
        //    Dictionary<int, string> map = new Dictionary<int, string>();
        //    try
        //    {
        //        conn.Open();
        //        string sql = "select MAPHONGBAN, TENPHONGBAN from PHONGBAN ";
        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        SqlDataReader rd = cmd.ExecuteReader();
        //        while (rd.Read())
        //        {
        //            dto_phongban dto = new dto_phongban();
        //            dto.Maphongban = rd.GetInt32(rd.GetOrdinal("MAPHONGBAN"));
        //            dto.Phongban = rd.GetString(rd.GetOrdinal("TENPHONGBAN"));
        //            map.Add(dto.Maphongban, dto.Phongban);
        //        }
        //    }
        //    catch
        //    {

        //    }
        //    finally { conn.Close(); }
        //    return map;
        //}

    }
}
