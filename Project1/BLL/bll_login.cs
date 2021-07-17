using Project1.DAL;
using Project1.DTO;
using System.Collections.Generic;

namespace Project1.BLL
{
    class bll_login
    {
        dal_login dal = new dal_login();

        public List<dto_login> GetData(int maso)
        {
            return dal.GetData(maso);
        }

        public bool Login(int username, string password)
        {
            return dal.Login(username, password);
        }
    }
}
