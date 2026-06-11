using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.tabContainer = new System.Windows.Forms.Panel();
            this.btnTabLogin = new System.Windows.Forms.Button();
            this.btnTabRegister = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblLogUser = new System.Windows.Forms.Label();
            this.txtLogUsername = new System.Windows.Forms.TextBox();
            this.lblLogPass = new System.Windows.Forms.Label();
            this.txtLogPassword = new System.Windows.Forms.TextBox();
            this.btnSubmitLogin = new System.Windows.Forms.Button();
            this.lblLogTip = new System.Windows.Forms.Label();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.lblRegUser = new System.Windows.Forms.Label();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.lblRegPass = new System.Windows.Forms.Label();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.lblRegName = new System.Windows.Forms.Label();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.lblRegPhone = new System.Windows.Forms.Label();
            this.txtRegPhone = new System.Windows.Forms.TextBox();
            this.lblRegAddress = new System.Windows.Forms.Label();
            this.txtRegAddress = new System.Windows.Forms.TextBox();
            this.btnSubmitRegister = new System.Windows.Forms.Button();
            this.tabContainer.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(20, 20);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(380, 35);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "⚡ TechStore";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSub
            // 
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSub.Location = new System.Drawing.Point(20, 55);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(380, 20);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Trải nghiệm mua sắm & quản lý kho trực tuyến";
            this.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabContainer
            // 
            this.tabContainer.BackColor = System.Drawing.Color.FromArgb(21, 28, 44);
            this.tabContainer.Controls.Add(this.btnTabLogin);
            this.tabContainer.Controls.Add(this.btnTabRegister);
            this.tabContainer.Location = new System.Drawing.Point(20, 85);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.Padding = new System.Windows.Forms.Padding(3);
            this.tabContainer.Size = new System.Drawing.Size(360, 38);
            this.tabContainer.TabIndex = 2;
            // 
            // btnTabLogin
            // 
            this.btnTabLogin.BackColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.btnTabLogin.FlatAppearance.BorderSize = 0;
            this.btnTabLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabLogin.ForeColor = System.Drawing.Color.White;
            this.btnTabLogin.Location = new System.Drawing.Point(3, 3);
            this.btnTabLogin.Name = "btnTabLogin";
            this.btnTabLogin.Size = new System.Drawing.Size(172, 32);
            this.btnTabLogin.TabIndex = 0;
            this.btnTabLogin.Text = "Đăng Nhập";
            this.btnTabLogin.UseVisualStyleBackColor = false;
            // 
            // btnTabRegister
            // 
            this.btnTabRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnTabRegister.FlatAppearance.BorderSize = 0;
            this.btnTabRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTabRegister.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnTabRegister.Location = new System.Drawing.Point(175, 3);
            this.btnTabRegister.Name = "btnTabRegister";
            this.btnTabRegister.Size = new System.Drawing.Size(172, 32);
            this.btnTabRegister.TabIndex = 1;
            this.btnTabRegister.Text = "Đăng Ký";
            this.btnTabRegister.UseVisualStyleBackColor = false;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.lblLogUser);
            this.panelLogin.Controls.Add(this.txtLogUsername);
            this.panelLogin.Controls.Add(this.lblLogPass);
            this.panelLogin.Controls.Add(this.txtLogPassword);
            this.panelLogin.Controls.Add(this.btnSubmitLogin);
            this.panelLogin.Controls.Add(this.lblLogTip);
            this.panelLogin.Location = new System.Drawing.Point(20, 135);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(360, 320);
            this.panelLogin.TabIndex = 3;
            // 
            // lblLogUser
            // 
            this.lblLogUser.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblLogUser.Location = new System.Drawing.Point(0, 15);
            this.lblLogUser.Name = "lblLogUser";
            this.lblLogUser.Size = new System.Drawing.Size(360, 20);
            this.lblLogUser.TabIndex = 0;
            this.lblLogUser.Text = "Tên đăng nhập *";
            // 
            // txtLogUsername
            // 
            this.txtLogUsername.BackColor = System.Drawing.Color.FromArgb(21, 28, 44);
            this.txtLogUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogUsername.ForeColor = System.Drawing.Color.White;
            this.txtLogUsername.Location = new System.Drawing.Point(0, 35);
            this.txtLogUsername.Name = "txtLogUsername";
            this.txtLogUsername.PlaceholderText = "Mặc định: user hoặc admin";
            this.txtLogUsername.Size = new System.Drawing.Size(360, 28);
            this.txtLogUsername.TabIndex = 1;
            // 
            // lblLogPass
            // 
            this.lblLogPass.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblLogPass.Location = new System.Drawing.Point(0, 85);
            this.lblLogPass.Name = "lblLogPass";
            this.lblLogPass.Size = new System.Drawing.Size(360, 20);
            this.lblLogPass.TabIndex = 2;
            this.lblLogPass.Text = "Mật khẩu *";
            // 
            // txtLogPassword
            // 
            this.txtLogPassword.BackColor = System.Drawing.Color.FromArgb(21, 28, 44);
            this.txtLogPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogPassword.ForeColor = System.Drawing.Color.White;
            this.txtLogPassword.Location = new System.Drawing.Point(0, 105);
            this.txtLogPassword.Name = "txtLogPassword";
            this.txtLogPassword.PasswordChar = '●';
            this.txtLogPassword.PlaceholderText = "Mật khẩu mặc định: 123";
            this.txtLogPassword.Size = new System.Drawing.Size(360, 28);
            this.txtLogPassword.TabIndex = 3;
            // 
            // btnSubmitLogin
            // 
            this.btnSubmitLogin.BackColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.btnSubmitLogin.FlatAppearance.BorderSize = 0;
            this.btnSubmitLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmitLogin.ForeColor = System.Drawing.Color.White;
            this.btnSubmitLogin.Location = new System.Drawing.Point(0, 175);
            this.btnSubmitLogin.Name = "btnSubmitLogin";
            this.btnSubmitLogin.Size = new System.Drawing.Size(360, 40);
            this.btnSubmitLogin.TabIndex = 4;
            this.btnSubmitLogin.Text = "Đăng Nhập Ngay";
            this.btnSubmitLogin.UseVisualStyleBackColor = false;
            // 
            // lblLogTip
            // 
            this.lblLogTip.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblLogTip.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblLogTip.Location = new System.Drawing.Point(0, 240);
            this.lblLogTip.Name = "lblLogTip";
            this.lblLogTip.Size = new System.Drawing.Size(360, 50);
            this.lblLogTip.TabIndex = 5;
            this.lblLogTip.Text = "Gợi ý: Đăng nhập 'user' / '123' để mua hàng\nhoặc 'admin' / '123' để quản lý doanh thu & kho hàng.";
            this.lblLogTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRegister
            // 
            this.panelRegister.AutoScroll = true;
            this.panelRegister.BackColor = System.Drawing.Color.Transparent;
            this.panelRegister.Controls.Add(this.lblRegUser);
            this.panelRegister.Controls.Add(this.txtRegUsername);
            this.panelRegister.Controls.Add(this.lblRegPass);
            this.panelRegister.Controls.Add(this.txtRegPassword);
            this.panelRegister.Controls.Add(this.lblRegName);
            this.panelRegister.Controls.Add(this.txtRegName);
            this.panelRegister.Controls.Add(this.lblRegPhone);
            this.panelRegister.Controls.Add(this.txtRegPhone);
            this.panelRegister.Controls.Add(this.lblRegAddress);
            this.panelRegister.Controls.Add(this.txtRegAddress);
            this.panelRegister.Controls.Add(this.btnSubmitRegister);
            this.panelRegister.Location = new System.Drawing.Point(20, 135);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(360, 320);
            this.panelRegister.TabIndex = 4;
            this.panelRegister.Visible = false;
            // 
            // lblRegUser
            // 
            this.lblRegUser.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblRegUser.Location = new System.Drawing.Point(0, 5);
            this.lblRegUser.Name = "lblRegUser";
            this.lblRegUser.Size = new System.Drawing.Size(340, 18);
            this.lblRegUser.TabIndex = 0;
            this.lblRegUser.Text = "Tên đăng nhập *";
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.BackColor = System.Drawing.Color.FromArgb(21, 28, 44);
            this.txtRegUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegUsername.ForeColor = System.Drawing.Color.White;
            this.txtRegUsername.Location = new System.Drawing.Point(0, 25);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(340, 28);
            this.txtRegUsername.TabIndex = 1;
            // 
            // lblRegPass
            // 
            this.lblRegPass.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblRegPass.Location = new System.Drawing.Point(0, 70);
            this.lblRegPass.Name = "lblRegPass";
            this.lblRegPass.Size = new System.Drawing.Size(340, 18);
            this.lblRegPass.TabIndex = 2;
            this.lblRegPass.Text = "Mật khẩu *";
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.BackColor = System.Drawing.Color.FromArgb(21, 28, 44);
            this.txtRegPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegPassword.ForeColor = System.Drawing.Color.White;
            this.txtRegPassword.Location = new System.Drawing.Point(0, 90);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '●';
            this.txtRegPassword.Size = new System.Drawing.Size(340, 28);
            this.txtRegPassword.TabIndex = 3;
            // 
            // lblRegName
            // 
            this.lblRegName.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblRegName.Location = new System.Drawing.Point(0, 135);
            this.lblRegName.Name = "lblRegName";
            this.lblRegName.Size = new System.Drawing.Size(340, 18);
            this.lblRegName.TabIndex = 4;
            this.lblRegName.Text = "Họ và Tên *";
            // 
            // txtRegName
            // 
            this.txtRegName.BackColor = System.Drawing.Color.FromArgb(21, 28, 44);
            this.txtRegName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegName.ForeColor = System.Drawing.Color.White;
            this.txtRegName.Location = new System.Drawing.Point(0, 155);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.PlaceholderText = "Nguyễn Văn A";
            this.txtRegName.Size = new System.Drawing.Size(340, 28);
            this.txtRegName.TabIndex = 5;
            // 
            // lblRegPhone
            // 
            this.lblRegPhone.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblRegPhone.Location = new System.Drawing.Point(0, 200);
            this.lblRegPhone.Name = "lblRegPhone";
            this.lblRegPhone.Size = new System.Drawing.Size(340, 18);
            this.lblRegPhone.TabIndex = 6;
            this.lblRegPhone.Text = "Số Điện Thoại *";
            // 
            // txtRegPhone
            // 
            this.txtRegPhone.BackColor = System.Drawing.Color.FromArgb(21, 28, 44);
            this.txtRegPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegPhone.ForeColor = System.Drawing.Color.White;
            this.txtRegPhone.Location = new System.Drawing.Point(0, 220);
            this.txtRegPhone.Name = "txtRegPhone";
            this.txtRegPhone.PlaceholderText = "09xxxxxxxx";
            this.txtRegPhone.Size = new System.Drawing.Size(340, 28);
            this.txtRegPhone.TabIndex = 7;
            // 
            // lblRegAddress
            // 
            this.lblRegAddress.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblRegAddress.Location = new System.Drawing.Point(0, 265);
            this.lblRegAddress.Name = "lblRegAddress";
            this.lblRegAddress.Size = new System.Drawing.Size(340, 18);
            this.lblRegAddress.TabIndex = 8;
            this.lblRegAddress.Text = "Địa Chỉ Nhận Hàng *";
            // 
            // txtRegAddress
            // 
            this.txtRegAddress.BackColor = System.Drawing.Color.FromArgb(21, 28, 44);
            this.txtRegAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegAddress.ForeColor = System.Drawing.Color.White;
            this.txtRegAddress.Location = new System.Drawing.Point(0, 285);
            this.txtRegAddress.Name = "txtRegAddress";
            this.txtRegAddress.PlaceholderText = "Số nhà, Tên đường, Tỉnh/Thành phố";
            this.txtRegAddress.Size = new System.Drawing.Size(340, 28);
            this.txtRegAddress.TabIndex = 9;
            // 
            // btnSubmitRegister
            // 
            this.btnSubmitRegister.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnSubmitRegister.FlatAppearance.BorderSize = 0;
            this.btnSubmitRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmitRegister.ForeColor = System.Drawing.Color.White;
            this.btnSubmitRegister.Location = new System.Drawing.Point(0, 335);
            this.btnSubmitRegister.Name = "btnSubmitRegister";
            this.btnSubmitRegister.Size = new System.Drawing.Size(340, 40);
            this.btnSubmitRegister.TabIndex = 10;
            this.btnSubmitRegister.Text = "Đăng Ký Ngay";
            this.btnSubmitRegister.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(11, 15, 25);
            this.ClientSize = new System.Drawing.Size(420, 520);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.tabContainer);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelRegister);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechStore - Đăng Nhập & Đăng Ký";
            this.tabContainer.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Panel tabContainer;
        private System.Windows.Forms.Button btnTabLogin;
        private System.Windows.Forms.Button btnTabRegister;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblLogUser;
        private System.Windows.Forms.TextBox txtLogUsername;
        private System.Windows.Forms.Label lblLogPass;
        private System.Windows.Forms.TextBox txtLogPassword;
        private System.Windows.Forms.Button btnSubmitLogin;
        private System.Windows.Forms.Label lblLogTip;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label lblRegUser;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.Label lblRegPass;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Label lblRegName;
        private System.Windows.Forms.TextBox txtRegName;
        private System.Windows.Forms.Label lblRegPhone;
        private System.Windows.Forms.TextBox txtRegPhone;
        private System.Windows.Forms.Label lblRegAddress;
        private System.Windows.Forms.TextBox txtRegAddress;
        private System.Windows.Forms.Button btnSubmitRegister;
    }
}
