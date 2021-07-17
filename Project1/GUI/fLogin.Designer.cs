
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
            this.btnlogn = new DevExpress.XtraEditors.SimpleButton();
            this.btnexit = new DevExpress.XtraEditors.SimpleButton();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(135, 146);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tài khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(306, 49);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(216, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "ĐĂNG NHẬP VÀO HỆ THỐNG";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(139, 228);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // btnlogn
            // 
            this.btnlogn.Location = new System.Drawing.Point(271, 295);
            this.btnlogn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnlogn.Name = "btnlogn";
            this.btnlogn.Size = new System.Drawing.Size(121, 39);
            this.btnlogn.TabIndex = 5;
            this.btnlogn.Text = "Đăng nhập";
            this.btnlogn.Click += new System.EventHandler(this.btnlogn_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(465, 295);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(121, 39);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Thoát";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(271, 142);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.BeepOnError = true;
            this.txtUsername.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtUsername.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtUsername.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txtUsername.Properties.MaskSettings.Set("mask", "[0-9]+");
            this.txtUsername.Properties.NullValuePrompt = "Nhập tài khoản";
            this.txtUsername.Properties.ShowNullValuePrompt = DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue;
            this.txtUsername.Properties.UseMaskAsDisplayFormat = true;
            this.txtUsername.Size = new System.Drawing.Size(315, 28);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(271, 228);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.BeepOnError = true;
            this.txtPassword.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtPassword.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtPassword.Properties.MaskSettings.Set("allowBlankInput", null);
            this.txtPassword.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txtPassword.Properties.MaskSettings.Set("mask", "[A-Za-z0-9]+");
            this.txtPassword.Properties.NullValuePrompt = "Nhập mật khẩu";
            this.txtPassword.Properties.ShowNullValuePrompt = DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue;
            this.txtPassword.Properties.UseMaskAsDisplayFormat = true;
            this.txtPassword.Size = new System.Drawing.Size(315, 28);
            this.txtPassword.TabIndex = 8;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 378);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogn);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnlogn;
        private DevExpress.XtraEditors.SimpleButton btnexit;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraEditors.TextEdit txtPassword;
    }
}