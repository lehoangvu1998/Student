
namespace Project1
{
    partial class fLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.txbpass = new System.Windows.Forms.TextBox();
            this.btnlogn = new DevExpress.XtraEditors.SimpleButton();
            this.btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(105, 111);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tài khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(238, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(174, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "ĐĂNG NHẬP VÀO HỆ THỐNG";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(108, 173);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(211, 108);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(245, 23);
            this.txttaikhoan.TabIndex = 3;
            // 
            // txbpass
            // 
            this.txbpass.Location = new System.Drawing.Point(211, 167);
            this.txbpass.Name = "txbpass";
            this.txbpass.Size = new System.Drawing.Size(245, 23);
            this.txbpass.TabIndex = 4;
            this.txbpass.UseSystemPasswordChar = true;
            // 
            // btnlogn
            // 
            this.btnlogn.Location = new System.Drawing.Point(211, 225);
            this.btnlogn.Name = "btnlogn";
            this.btnlogn.Size = new System.Drawing.Size(94, 29);
            this.btnlogn.TabIndex = 5;
            this.btnlogn.Text = "Đăng nhập";
            this.btnlogn.Click += new System.EventHandler(this.btnlogn_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(362, 225);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(94, 29);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Thoát";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 290);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogn);
            this.Controls.Add(this.txbpass);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.TextBox txbpass;
        private DevExpress.XtraEditors.SimpleButton btnlogn;
        private DevExpress.XtraEditors.SimpleButton btnexit;
    }
}