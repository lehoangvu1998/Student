using Project1.DAL;
using Project1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.BLL
{
   public class bll_phongban
    {
        dal_phongban dal = new dal_phongban();

        public DataTable getPhongban()
        {
            return dal.getPhongban();
        }

        public bool themphongban(dto_phongban pb)
        {
            return dal.themphongban(pb);
        }

        public bool suaphongban(dto_phongban pb)
        {
            return dal.suaphongban(pb);
        }

        public bool delete(dto_phongban pb)
        {
            return dal.delete(pb);
        }
    }
}
