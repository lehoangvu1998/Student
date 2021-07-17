using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Project1.GUI
{
    public partial class fhome : DevExpress.XtraEditors.XtraForm
    {
        public static string name, address;
        public fhome()
        {
            InitializeComponent();
            loadusers();
            timer2.Start();
        }

        private int imgae = 1;
        
        
        private void Loadnextimg()
        {
            if (imgae == 17 )
            {
                imgae = 1;

            }
            slider.ImageLocation = string.Format(@"IMG\{0}.jpg", imgae);
            imgae++;
        }

        private void loadusers()
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Loadnextimg();
        }

        private void phongban_Click(object sender, EventArgs e)
        {
            fPhongban f = new fPhongban();
            f.Show();
            this.Dispose();
        }

        private void fhome_FormClosing(object sender, FormClosingEventArgs e)
        {
            fLogin F = new fLogin();
            F.Show();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString(" dd/MM/yyyy hh:mm:ss");
        }

        private void Khoa(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Tên: " + name + "\nĐịa chỉ: " + address);
        }
    }
}