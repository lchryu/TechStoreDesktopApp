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
            this.lblBrand = new Label();
            this.lblSub = new Label();
            this.panelLogin = new Panel();
            this.lblLogUser = new Label();
            this.txtLogUsername = new TextBox();
            this.lblLogPass = new Label();
            this.txtLogPassword = new TextBox();
            this.btnSubmitLogin = new Button();
            this.btnOpenRegister = new Button();
            this.btnOpenForgotPassword = new Button();
            this.lblLogTip = new Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblBrand.ForeColor = Color.DarkBlue;
            this.lblBrand.Location = new Point(20, 15);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new Size(360, 35);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "CỬA HÀNG TECHSTORE";
            this.lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSub
            // 
            this.lblSub.Font = new Font("Segoe UI", 9F);
            this.lblSub.ForeColor = Color.FromArgb(64, 64, 64);
            this.lblSub.Location = new Point(20, 50);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new Size(360, 20);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Hệ thống mua bán công nghệ & thiết bị điện tử";
            this.lblSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = Color.White;
            this.panelLogin.BorderStyle = BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.lblLogUser);
            this.panelLogin.Controls.Add(this.txtLogUsername);
            this.panelLogin.Controls.Add(this.lblLogPass);
            this.panelLogin.Controls.Add(this.txtLogPassword);
            this.panelLogin.Controls.Add(this.btnSubmitLogin);
            this.panelLogin.Controls.Add(this.btnOpenRegister);
            this.panelLogin.Controls.Add(this.btnOpenForgotPassword);
            this.panelLogin.Controls.Add(this.lblLogTip);
            this.panelLogin.Location = new Point(20, 80);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Padding = new Padding(15);
            this.panelLogin.Size = new Size(360, 310);
            this.panelLogin.TabIndex = 2;
            // 
            // lblLogUser
            // 
            this.lblLogUser.ForeColor = Color.Black;
            this.lblLogUser.Location = new Point(15, 15);
            this.lblLogUser.Name = "lblLogUser";
            this.lblLogUser.Size = new Size(328, 20);
            this.lblLogUser.TabIndex = 0;
            this.lblLogUser.Text = "Tên đăng nhập:";
            // 
            // txtLogUsername
            // 
            this.txtLogUsername.BackColor = Color.White;
            this.txtLogUsername.BorderStyle = BorderStyle.FixedSingle;
            this.txtLogUsername.ForeColor = Color.Black;
            this.txtLogUsername.Location = new Point(15, 35);
            this.txtLogUsername.Name = "txtLogUsername";
            this.txtLogUsername.PlaceholderText = "Nhập tài khoản...";
            this.txtLogUsername.Size = new Size(328, 25);
            this.txtLogUsername.TabIndex = 1;
            // 
            // lblLogPass
            // 
            this.lblLogPass.ForeColor = Color.Black;
            this.lblLogPass.Location = new Point(15, 75);
            this.lblLogPass.Name = "lblLogPass";
            this.lblLogPass.Size = new Size(328, 20);
            this.lblLogPass.TabIndex = 2;
            this.lblLogPass.Text = "Mật khẩu:";
            // 
            // txtLogPassword
            // 
            this.txtLogPassword.BackColor = Color.White;
            this.txtLogPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtLogPassword.ForeColor = Color.Black;
            this.txtLogPassword.Location = new Point(15, 95);
            this.txtLogPassword.Name = "txtLogPassword";
            this.txtLogPassword.PasswordChar = '*';
            this.txtLogPassword.PlaceholderText = "Nhập mật khẩu...";
            this.txtLogPassword.Size = new Size(328, 25);
            this.txtLogPassword.TabIndex = 3;
            // 
            // btnSubmitLogin
            // 
            this.btnSubmitLogin.BackColor = Color.RoyalBlue;
            this.btnSubmitLogin.FlatAppearance.BorderSize = 0;
            this.btnSubmitLogin.FlatStyle = FlatStyle.Flat;
            this.btnSubmitLogin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnSubmitLogin.ForeColor = Color.White;
            this.btnSubmitLogin.Location = new Point(15, 140);
            this.btnSubmitLogin.Name = "btnSubmitLogin";
            this.btnSubmitLogin.Size = new Size(328, 40);
            this.btnSubmitLogin.TabIndex = 4;
            this.btnSubmitLogin.Text = "ĐĂNG NHẬP";
            this.btnSubmitLogin.UseVisualStyleBackColor = false;
            // 
            // btnOpenRegister
            // 
            this.btnOpenRegister.BackColor = Color.FromArgb(240, 240, 240);
            this.btnOpenRegister.FlatAppearance.BorderSize = 0;
            this.btnOpenRegister.FlatStyle = FlatStyle.Flat;
            this.btnOpenRegister.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.btnOpenRegister.ForeColor = Color.RoyalBlue;
            this.btnOpenRegister.Location = new Point(15, 195);
            this.btnOpenRegister.Name = "btnOpenRegister";
            this.btnOpenRegister.Size = new Size(155, 30);
            this.btnOpenRegister.TabIndex = 5;
            this.btnOpenRegister.Text = "Đăng Ký Tài Khoản";
            this.btnOpenRegister.UseVisualStyleBackColor = false;
            // 
            // btnOpenForgotPassword
            // 
            this.btnOpenForgotPassword.BackColor = Color.FromArgb(240, 240, 240);
            this.btnOpenForgotPassword.FlatAppearance.BorderSize = 0;
            this.btnOpenForgotPassword.FlatStyle = FlatStyle.Flat;
            this.btnOpenForgotPassword.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            this.btnOpenForgotPassword.ForeColor = Color.FromArgb(127, 29, 29);
            this.btnOpenForgotPassword.Location = new Point(188, 195);
            this.btnOpenForgotPassword.Name = "btnOpenForgotPassword";
            this.btnOpenForgotPassword.Size = new Size(155, 30);
            this.btnOpenForgotPassword.TabIndex = 6;
            this.btnOpenForgotPassword.Text = "Quên Mật Khẩu?";
            this.btnOpenForgotPassword.UseVisualStyleBackColor = false;
            // 
            // lblLogTip
            // 
            this.lblLogTip.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            this.lblLogTip.ForeColor = Color.Gray;
            this.lblLogTip.Location = new Point(15, 235);
            this.lblLogTip.Name = "lblLogTip";
            this.lblLogTip.Size = new Size(328, 60);
            this.lblLogTip.TabIndex = 7;
            this.lblLogTip.Text = "Tài khoản test:\nAdmin: admin / 123 | Khách hàng: user / 123";
            this.lblLogTip.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 17F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.ClientSize = new Size(400, 410);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.panelLogin);
            this.Font = new Font("Segoe UI", 9.5F);
            this.ForeColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "TechStore - Đăng Nhập Hệ Thống";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Label lblBrand;
        private Label lblSub;
        private Panel panelLogin;
        private Label lblLogUser;
        private TextBox txtLogUsername;
        private Label lblLogPass;
        private TextBox txtLogPassword;
        private Button btnSubmitLogin;
        private Button btnOpenRegister;
        private Button btnOpenForgotPassword;
        private Label lblLogTip;
    }
}
