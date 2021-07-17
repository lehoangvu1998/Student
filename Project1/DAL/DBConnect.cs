using System.Data.SqlClient;

namespace Project1.DAL
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QLSINHVIEN;Integrated Security=True");
    }
}
