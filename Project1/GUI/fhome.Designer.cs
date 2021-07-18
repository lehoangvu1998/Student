
namespace Project1.GUI
{
    partial class fhome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fhome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuquanly = new System.Windows.Forms.ToolStripMenuItem();
            this.phongban = new System.Windows.Forms.ToolStripMenuItem();
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.giảngViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGiangvien = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.slider = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.heelo = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heelo)).BeginInit();
            this.heelo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuquanly,
            this.menuGiangvien,
            this.liênHệToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1372, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuquanly
            // 
            this.menuquanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phongban,
            this.khoaToolStripMenuItem,
            this.lớpToolStripMenuItem,
            this.mônHọcToolStripMenuItem,
            this.sinhViênToolStripMenuItem1,
            this.giảngViênToolStripMenuItem1});
            this.menuquanly.Image = ((System.Drawing.Image)(resources.GetObject("menuquanly.Image")));
            this.menuquanly.Name = "menuquanly";
            this.menuquanly.Size = new System.Drawing.Size(91, 24);
            this.menuquanly.Text = "Quản lý";
            // 
            // phongban
            // 
            this.phongban.Image = ((System.Drawing.Image)(resources.GetObject("phongban.Image")));
            this.phongban.Name = "phongban";
            this.phongban.Size = new System.Drawing.Size(216, 26);
            this.phongban.Text = "Phòng ban";
            this.phongban.Click += new System.EventHandler(this.phongban_Click);
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("khoaToolStripMenuItem.Image")));
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.khoaToolStripMenuItem.Text = "Khoa";
            this.khoaToolStripMenuItem.Click += new System.EventHandler(this.Khoa);
            // 
            // lớpToolStripMenuItem
            // 
            this.lớpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lớpToolStripMenuItem.Image")));
            this.lớpToolStripMenuItem.Name = "lớpToolStripMenuItem";
            this.lớpToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.lớpToolStripMenuItem.Text = "Lớp";
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mônHọcToolStripMenuItem.Image")));
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.mônHọcToolStripMenuItem.Text = "Môn học";
            // 
            // sinhViênToolStripMenuItem1
            // 
            this.sinhViênToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("sinhViênToolStripMenuItem1.Image")));
            this.sinhViênToolStripMenuItem1.Name = "sinhViênToolStripMenuItem1";
            this.sinhViênToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.sinhViênToolStripMenuItem1.Text = "Sinh viên";
            // 
            // giảngViênToolStripMenuItem1
            // 
            this.giảngViênToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("giảngViênToolStripMenuItem1.Image")));
            this.giảngViênToolStripMenuItem1.Name = "giảngViênToolStripMenuItem1";
            this.giảngViênToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.giảngViênToolStripMenuItem1.Text = "Giảng viên";
            // 
            // menuGiangvien
            // 
            this.menuGiangvien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpĐiểmToolStripMenuItem});
            this.menuGiangvien.Image = ((System.Drawing.Image)(resources.GetObject("menuGiangvien.Image")));
            this.menuGiangvien.Name = "menuGiangvien";
            this.menuGiangvien.Size = new System.Drawing.Size(111, 24);
            this.menuGiangvien.Text = "Giảng viên";
            // 
            // nhậpĐiểmToolStripMenuItem
            // 
            this.nhậpĐiểmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhậpĐiểmToolStripMenuItem.Image")));
            this.nhậpĐiểmToolStripMenuItem.Name = "nhậpĐiểmToolStripMenuItem";
            this.nhậpĐiểmToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nhậpĐiểmToolStripMenuItem.Text = "Nhập điểm";
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("liênHệToolStripMenuItem.Image")));
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.liênHệToolStripMenuItem.Text = "Liên hệ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.slider);
            this.panelControl1.Location = new System.Drawing.Point(0, 41);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1372, 651);
            this.panelControl1.TabIndex = 1;
            // 
            // slider
            // 
            this.slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slider.ErrorImage = ((System.Drawing.Image)(resources.GetObject("slider.ErrorImage")));
            this.slider.Image = ((System.Drawing.Image)(resources.GetObject("slider.Image")));
            this.slider.Location = new System.Drawing.Point(2, 2);
            this.slider.Margin = new System.Windows.Forms.Padding(4);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(1368, 647);
            this.slider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slider.TabIndex = 0;
            this.slider.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(1063, 693);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 2;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // heelo
            // 
            this.heelo.Controls.Add(this.labelControl1);
            this.heelo.Location = new System.Drawing.Point(1148, 0);
            this.heelo.Name = "heelo";
            this.heelo.Size = new System.Drawing.Size(224, 36);
            this.heelo.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "labelControl1";
            // 
            // fhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1372, 732);
            this.Controls.Add(this.heelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.menuStrip1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("fhome.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fhome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fhome_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heelo)).EndInit();
            this.heelo.ResumeLayout(false);
            this.heelo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuquanly;
        private System.Windows.Forms.ToolStripMenuItem menuGiangvien;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phongban;
        private System.Windows.Forms.ToolStripMenuItem khoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem giảngViênToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nhậpĐiểmToolStripMenuItem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox slider;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private DevExpress.XtraEditors.PanelControl heelo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}