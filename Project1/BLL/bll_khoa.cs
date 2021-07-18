using Project1.DAL;
using System.Data;

namespace Project1.BLL
{
    public class bll_khoa
    {
        dal_khoa dal = new dal_khoa();

        public DataSet LoadPhongban()
        {
            return dal.LoadPhongban();
        }

        public DataTable GetData()
        {
            return dal.GetData();
        }
    }
}
