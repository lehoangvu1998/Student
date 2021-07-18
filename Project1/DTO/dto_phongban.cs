using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.DTO
{
   public class dto_phongban
    {
        private int maphongban;
        private String phongban;

        public dto_phongban()
        {

        }
        public dto_phongban(int maphongban, string phongban)
        {
            this.maphongban = maphongban;
            this.phongban = phongban;
        }

        public int Maphongban { get => maphongban; set => maphongban = value; }
        public string Phongban { get => phongban; set => phongban = value; }
    }
}
