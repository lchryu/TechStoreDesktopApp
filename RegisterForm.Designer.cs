using System.Drawing;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    partial class RegisterForm
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
            this.lblTitle = new Label();
            this.lblUser = new Label();
            this.txtUsername = new TextBox();
            this.lblPass = new Label();
            this.txtPassword = new TextBox();
            this.lblFullName = new Label();
            this.txtFullName = new TextBox();
            this.lblPhone = new Label();
            this.txtPhone = new TextBox();
            this.lblAddress = new Label();
            this.txtAddress = new TextBox();
            this.lblQuestion = new Label();
            this.cbSecurityQuestion = new ComboBox();
            this.lblAnswer = new Label();
            this.txtSecurityAnswer = new TextBox();
            this.btnRegister = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.DarkBlue;
            this.lblTitle.Location = new Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(380, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.ForeColor = Color.Black;
            this.lblUser.Location = new Point(30, 65);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new Size(360, 18);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Tên đăng nhập *";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = Color.White;
            this.txtUsername.BorderStyle = BorderStyle.FixedSingle;
            this.txtUsername.ForeColor = Color.Black;
            this.txtUsername.Location = new Point(30, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(360, 25);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "khachmoi";
            // 
            // lblPass
            // 
            this.lblPass.ForeColor = Color.Black;
            this.lblPass.Location = new Point(30, 125);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new Size(360, 18);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Mật khẩu *";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = Color.White;
            this.txtPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = Color.Black;
            this.txtPassword.Location = new Point(30, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new Size(360, 25);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "123456";
            // 
            // lblFullName
            // 
            this.lblFullName.ForeColor = Color.Black;
            this.lblFullName.Location = new Point(30, 185);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new Size(360, 18);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "Họ và Tên *";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = Color.White;
            this.txtFullName.BorderStyle = BorderStyle.FixedSingle;
            this.txtFullName.ForeColor = Color.Black;
            this.txtFullName.Location = new Point(30, 205);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new Size(360, 25);
            this.txtFullName.TabIndex = 6;
            this.txtFullName.Text = "Pham Khach Moi";
            // 
            // lblPhone
            // 
            this.lblPhone.ForeColor = Color.Black;
            this.lblPhone.Location = new Point(30, 245);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new Size(360, 18);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Số Điện Thoại *";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = Color.White;
            this.txtPhone.BorderStyle = BorderStyle.FixedSingle;
            this.txtPhone.ForeColor = Color.Black;
            this.txtPhone.Location = new Point(30, 265);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new Size(360, 25);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.Text = "0912345678";
            // 
            // lblAddress
            // 
            this.lblAddress.ForeColor = Color.Black;
            this.lblAddress.Location = new Point(30, 305);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new Size(360, 18);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Địa Chỉ Nhận Hàng *";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = Color.White;
            this.txtAddress.BorderStyle = BorderStyle.FixedSingle;
            this.txtAddress.ForeColor = Color.Black;
            this.txtAddress.Location = new Point(30, 325);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new Size(360, 25);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.Text = "12 Nguyen Trai, Quan 5, TP.HCM";
            // 
            // lblQuestion
            // 
            this.lblQuestion.ForeColor = Color.Black;
            this.lblQuestion.Location = new Point(30, 365);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new Size(360, 18);
            this.lblQuestion.TabIndex = 11;
            this.lblQuestion.Text = "Câu hỏi bảo mật (Phục vụ lấy lại mật khẩu) *";
            // 
            // cbSecurityQuestion
            // 
            this.cbSecurityQuestion.BackColor = Color.White;
            this.cbSecurityQuestion.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbSecurityQuestion.ForeColor = Color.Black;
            this.cbSecurityQuestion.FormattingEnabled = true;
            this.cbSecurityQuestion.Items.AddRange(new object[] {
            "Tên mẹ của bạn là gì?",
            "Nơi bạn sinh ra ở đâu?",
            "Trường tiểu học của bạn tên gì?",
            "Tên thú cưng đầu tiên của bạn?"});
            this.cbSecurityQuestion.Location = new Point(30, 385);
            this.cbSecurityQuestion.Name = "cbSecurityQuestion";
            this.cbSecurityQuestion.Size = new Size(360, 25);
            this.cbSecurityQuestion.TabIndex = 12;
            this.cbSecurityQuestion.Text = "Tên mẹ của bạn là gì?";
            // 
            // lblAnswer
            // 
            this.lblAnswer.ForeColor = Color.Black;
            this.lblAnswer.Location = new Point(30, 425);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new Size(360, 18);
            this.lblAnswer.TabIndex = 13;
            this.lblAnswer.Text = "Câu trả lời bảo mật *";
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.BackColor = Color.White;
            this.txtSecurityAnswer.BorderStyle = BorderStyle.FixedSingle;
            this.txtSecurityAnswer.ForeColor = Color.Black;
            this.txtSecurityAnswer.Location = new Point(30, 445);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.Size = new Size(360, 25);
            this.txtSecurityAnswer.TabIndex = 14;
            this.txtSecurityAnswer.Text = "Nguyen Thi A";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = Color.ForestGreen;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = FlatStyle.Flat;
            this.btnRegister.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnRegister.ForeColor = Color.White;
            this.btnRegister.Location = new Point(30, 495);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new Size(170, 40);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "ĐĂNG KÝ";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = Color.FromArgb(71, 85, 105);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Location = new Point(220, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(170, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 17F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.ClientSize = new Size(420, 565);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.cbSecurityQuestion);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtSecurityAnswer);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Font = new Font("Segoe UI", 9.5F);
            this.ForeColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Đăng Ký Tài Khoản Mới";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUser;
        private TextBox txtUsername;
        private Label lblPass;
        private TextBox txtPassword;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblQuestion;
        private ComboBox cbSecurityQuestion;
        private Label lblAnswer;
        private TextBox txtSecurityAnswer;
        private Button btnRegister;
        private Button btnCancel;
    }
}
