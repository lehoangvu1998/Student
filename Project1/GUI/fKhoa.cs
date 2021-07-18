using Project1.BLL;
using Project1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Project1.GUI
{
    public partial class fKhoa : DevExpress.XtraEditors.XtraForm
    {
        bll_khoa bll = new bll_khoa();
        dto_khoa dto = new dto_khoa();
        dto_phongban dto_phongban = new dto_phongban();
        List<dto_phongban> arr = new List<dto_phongban>();

        public fKhoa()
        {
            InitializeComponent();
            loadKhoa();
            fillcombo();
        }

        void taomaphongban()
        {
            Random code = new Random();
            int maso = code.Next(1000, 8000);
            String a = maso.ToString();
            txbMaKhoa.Text = a;
        }

        void loadKhoa()
        {
            showkhoa.DataSource = bll.GetData();
            showkhoa.Columns[0].HeaderText = "Mã Khoa";
            showkhoa.Columns[1].HeaderText = " Tên Khoa ";
            showkhoa.Columns[2].HeaderText = " Tên Phòng Ban";
            showkhoa.Columns[3].HeaderText = " Số Điện Thoại";
            this.showkhoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void fillcombo()
        {
            DataSet ds = bll.LoadPhongban();
            cbPhongban.DataSource = ds.Tables[0];
            cbPhongban.DisplayMember = "TENPHONGBAN";
            cbPhongban.ValueMember = "MAPHONGBAN";
        }

        private void btnadd_Click(object sender, System.EventArgs e)
        {
            taomaphongban();
            btndelete.Visible = false;
            btnupdate.Visible = false;
        }

        private void fKhoa_Load(object sender, System.EventArgs e)
        {
            

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbPhongban.SelectedValue.ToString());
        }
    }
}