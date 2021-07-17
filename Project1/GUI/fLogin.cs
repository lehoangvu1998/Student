using DevExpress.XtraEditors;
using Project1.BLL;
using Project1.DTO;
using Project1.GUI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project1
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        dto_login dto = new dto_login();
        bll_login bll = new bll_login();
        List<dto_login> arr = new List<dto_login>();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnlogn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                dto.Maso = int.Parse(txtUsername.Text);
                dto.Pass = txtPassword.Text;
                if (bll.Login(dto.Maso, dto.Pass))
                {
                    arr = bll.GetData(dto.Maso);
                    for (int i = 0; i < arr.Count; i++)
                    {
                        dto = arr[i];
                        string name = dto.Name;
                        string address = dto.Address;
                        int quyen = dto.Role;
                        //double diem = dto.Diem;
                        if (quyen == 0)
                        {
                            fhome.name = name;
                            fhome.address = address;
                            this.Hide();
                            new fhome().ShowDialog();
                            this.Close();
                        }
                        if (quyen == 1)
                        {
                            fPhongban.name = name;
                            fPhongban.address = address;
                            this.Hide();
                            new fPhongban().ShowDialog();
                            this.Close();
                        }
                        if (quyen == 2)
                        {

                        }
                    }
                }
                else
                    XtraMessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("Tài khoản hoặc mật khẩu không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}