using DevExpress.XtraEditors;
using Project1.BLL;
using Project1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1.GUI
{
    public partial class fPhongban : DevExpress.XtraEditors.XtraForm
    {
        public static string name, address;
        bll_phongban bll = new bll_phongban();
        public fPhongban()
        {
            InitializeComponent();
            loadphongban();
            txbmaphongban.ReadOnly = true;
            txbphongban.ReadOnly = true;

            txbmaphongban.Text = name;
            txbphongban.Text = address;
        }

        void taomaphongban()
        {
            Random code = new Random();
            int maso = code.Next(100, 2000);
            String a = maso.ToString();
            txbmaphongban.Text = a;
        }
        void loadphongban()
        {
            showphongban.DataSource = bll.getPhongban();
            showphongban.Columns[0].HeaderText = "Mã Phòng Ban";
            showphongban.Columns[1].HeaderText = "Tên Phòng Ban";
            this.showphongban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnrevert_Click(object sender, EventArgs e)
        {
            txbphongban.ResetText();
            txbphongban.Focus();
            taomaphongban();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txbmaphongban.ReadOnly = false;
            txbphongban.ReadOnly = false;
            taomaphongban();
            txbphongban.Focus();
            btndelete.Visible = false;
            btnupdate.Visible = false;
        
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txbmaphongban.Text != "" && txbphongban.Text != "")
            {
                dto_phongban dto = new dto_phongban(txbmaphongban.Text, txbphongban.Text);
                
                if (bll.themphongban(dto))
                {
                    MessageBox.Show("Thêm mới thành công");
                    loadphongban();
                    btndelete.Visible = true;
                    btnupdate.Visible = true;
                  
                } else
                {
                    MessageBox.Show("Không thành công");
                }
            } else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void showphongban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.showphongban.Rows[e.RowIndex];
                txbmaphongban.Text = row.Cells[0].Value.ToString();
                txbphongban.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txbphongban.Text != "")
            {
                dto_phongban pb = new dto_phongban(txbphongban.Text, txbmaphongban.Text);
                if (MessageBox.Show(" Bạn có muốn thay đổi tên phòng ban !!!" , "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                   if (bll.suaphongban(pb))
                    {
                        MessageBox.Show("Cập nhật thành công ");
                        loadphongban();
                    }else
                    {
                        MessageBox.Show("Không thành công", "Thông báo");
                    }
                }
            }else
            {
                MessageBox.Show("Vui lòng nhập vào tên cần thay đỗi");
                txbphongban.Focus();
            }
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txbphongban.ReadOnly = false;
            txbphongban.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            dto_phongban pb = new dto_phongban(txbmaphongban.Text, txbphongban.Text);
            if (MessageBox.Show(" Bạn có muốn xóa phòng ban !!!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bll.delete(pb))
                {
                    MessageBox.Show("Xóa thành công ");
                    loadphongban();
                }
                else
                {
                    MessageBox.Show("Không thành công", "Thông báo");
                }
            }
        }
    }
}