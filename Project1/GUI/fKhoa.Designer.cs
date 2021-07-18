namespace Project1.GUI
{
    partial class fKhoa
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
            System.Windows.Forms.Label tENPHONGBANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fKhoa));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btnrevert = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.txbtenkhoa = new DevExpress.XtraEditors.TextEdit();
            this.txbMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cbPhongban = new System.Windows.Forms.ComboBox();
            this.txtsdt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.showkhoa = new System.Windows.Forms.DataGridView();
            tENPHONGBANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbtenkhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showkhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // tENPHONGBANLabel
            // 
            tENPHONGBANLabel.AutoSize = true;
            tENPHONGBANLabel.Location = new System.Drawing.Point(365, 59);
            tENPHONGBANLabel.Name = "tENPHONGBANLabel";
            tENPHONGBANLabel.Size = new System.Drawing.Size(88, 21);
            tENPHONGBANLabel.TabIndex = 6;
            tENPHONGBANLabel.Text = "Phòng Ban";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.simpleButton1);
            this.groupControl3.Controls.Add(this.btnsave);
            this.groupControl3.Controls.Add(this.btnrevert);
            this.groupControl3.Controls.Add(this.btnupdate);
            this.groupControl3.Controls.Add(this.btndelete);
            this.groupControl3.Controls.Add(this.btnadd);
            this.groupControl3.Location = new System.Drawing.Point(710, 288);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(568, 185);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Chức năng";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(222, 50);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 38);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Sửa";
            // 
            // btnsave
            // 
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.Location = new System.Drawing.Point(24, 130);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(129, 38);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Lưu";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnrevert
            // 
            this.btnrevert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrevert.ImageOptions.Image")));
            this.btnrevert.Location = new System.Drawing.Point(417, 130);
            this.btnrevert.Margin = new System.Windows.Forms.Padding(4);
            this.btnrevert.Name = "btnrevert";
            this.btnrevert.Size = new System.Drawing.Size(143, 38);
            this.btnrevert.TabIndex = 4;
            this.btnrevert.Text = "Làm lại";
            // 
            // btnupdate
            // 
            this.btnupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.ImageOptions.Image")));
            this.btnupdate.Location = new System.Drawing.Point(417, 50);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(143, 38);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Cập nhật";
            // 
            // btndelete
            // 
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.Location = new System.Drawing.Point(222, 130);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(143, 38);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Xóa";
            // 
            // btnadd
            // 
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.Location = new System.Drawing.Point(24, 50);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(129, 38);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Thêm";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txbtenkhoa
            // 
            this.txbtenkhoa.Location = new System.Drawing.Point(105, 127);
            this.txbtenkhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txbtenkhoa.Name = "txbtenkhoa";
            this.txbtenkhoa.Size = new System.Drawing.Size(192, 28);
            this.txbtenkhoa.TabIndex = 3;
            // 
            // txbMaKhoa
            // 
            this.txbMaKhoa.Location = new System.Drawing.Point(105, 56);
            this.txbMaKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaKhoa.Name = "txbMaKhoa";
            this.txbMaKhoa.Size = new System.Drawing.Size(192, 28);
            this.txbMaKhoa.TabIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cbPhongban);
            this.groupControl2.Controls.Add(this.txtsdt);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(tENPHONGBANLabel);
            this.groupControl2.Controls.Add(this.txbtenkhoa);
            this.groupControl2.Controls.Add(this.txbMaKhoa);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(13, 288);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(675, 185);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Thông tin";
            // 
            // cbPhongban
            // 
            this.cbPhongban.FormattingEnabled = true;
            this.cbPhongban.Location = new System.Drawing.Point(475, 55);
            this.cbPhongban.Name = "cbPhongban";
            this.cbPhongban.Size = new System.Drawing.Size(184, 29);
            this.cbPhongban.TabIndex = 10;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(475, 126);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(184, 28);
            this.txtsdt.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(350, 129);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 21);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Số Điện Thoại";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 129);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên Khoa";
            // 
            // labelControl1
            // 
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 59);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Khoa";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.showkhoa);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(13, 13);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1265, 276);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "DANH SÁCH KHOA";
            // 
            // showkhoa
            // 
            this.showkhoa.AllowUserToAddRows = false;
            this.showkhoa.AllowUserToDeleteRows = false;
            this.showkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showkhoa.Location = new System.Drawing.Point(4, 38);
            this.showkhoa.Margin = new System.Windows.Forms.Padding(4);
            this.showkhoa.Name = "showkhoa";
            this.showkhoa.ReadOnly = true;
            this.showkhoa.RowHeadersWidth = 51;
            this.showkhoa.RowTemplate.Height = 24;
            this.showkhoa.Size = new System.Drawing.Size(1253, 214);
            this.showkhoa.TabIndex = 0;
            // 
            // fKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 494);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "fKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fKhoa";
            this.Load += new System.EventHandler(this.fKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txbtenkhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsdt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showkhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.SimpleButton btnrevert;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.TextEdit txbtenkhoa;
        private DevExpress.XtraEditors.TextEdit txbMaKhoa;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView showkhoa;
        private DevExpress.XtraEditors.TextEdit txtsdt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cbPhongban;
    }
}