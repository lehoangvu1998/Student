
namespace Project1.GUI
{
    partial class fPhongban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPhongban));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.showphongban = new System.Windows.Forms.DataGridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txbphongban = new DevExpress.XtraEditors.TextEdit();
            this.txbmaphongban = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btnrevert = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showphongban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbphongban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbmaphongban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.showphongban);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(976, 210);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "DANH SÁCH PHÒNG BAN";
            // 
            // showphongban
            // 
            this.showphongban.AllowUserToAddRows = false;
            this.showphongban.AllowUserToDeleteRows = false;
            this.showphongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showphongban.Location = new System.Drawing.Point(3, 29);
            this.showphongban.Name = "showphongban";
            this.showphongban.ReadOnly = true;
            this.showphongban.RowHeadersWidth = 51;
            this.showphongban.RowTemplate.Height = 24;
            this.showphongban.Size = new System.Drawing.Size(970, 163);
            this.showphongban.TabIndex = 0;
            this.showphongban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showphongban_CellClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txbphongban);
            this.groupControl2.Controls.Add(this.txbmaphongban);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(15, 228);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(508, 141);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông tin";
            // 
            // txbphongban
            // 
            this.txbphongban.Location = new System.Drawing.Point(184, 96);
            this.txbphongban.Name = "txbphongban";
            this.txbphongban.Size = new System.Drawing.Size(213, 23);
            this.txbphongban.TabIndex = 3;
            // 
            // txbmaphongban
            // 
            this.txbmaphongban.Location = new System.Drawing.Point(184, 48);
            this.txbmaphongban.Name = "txbmaphongban";
            this.txbmaphongban.Size = new System.Drawing.Size(213, 23);
            this.txbmaphongban.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(68, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên Phòng Ban";
            // 
            // labelControl1
            // 
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(73, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Phòng Ban";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.simpleButton1);
            this.groupControl3.Controls.Add(this.btnsave);
            this.groupControl3.Controls.Add(this.btnrevert);
            this.groupControl3.Controls.Add(this.btnupdate);
            this.groupControl3.Controls.Add(this.btndelete);
            this.groupControl3.Controls.Add(this.btnadd);
            this.groupControl3.Location = new System.Drawing.Point(546, 228);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(442, 141);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Chức năng";
            // 
            // btnsave
            // 
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.Location = new System.Drawing.Point(19, 99);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 29);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Lưu";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnrevert
            // 
            this.btnrevert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrevert.ImageOptions.Image")));
            this.btnrevert.Location = new System.Drawing.Point(324, 99);
            this.btnrevert.Name = "btnrevert";
            this.btnrevert.Size = new System.Drawing.Size(111, 29);
            this.btnrevert.TabIndex = 4;
            this.btnrevert.Text = "Làm lại";
            this.btnrevert.Click += new System.EventHandler(this.btnrevert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.ImageOptions.Image")));
            this.btnupdate.Location = new System.Drawing.Point(324, 38);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(111, 29);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.Location = new System.Drawing.Point(173, 99);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(111, 29);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Xóa";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.Location = new System.Drawing.Point(19, 38);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 29);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Thêm";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(173, 38);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(111, 29);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Sửa";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // fPhongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 424);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "fPhongban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPhongban";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showphongban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbphongban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbmaphongban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView showphongban;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txbphongban;
        private DevExpress.XtraEditors.TextEdit txbmaphongban;
        private DevExpress.XtraEditors.SimpleButton btnrevert;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}