using System.Drawing;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    partial class ForgotPasswordForm
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
            this.lblUserTitle = new Label();
            this.txtUsername = new TextBox();
            this.btnCheckUser = new Button();
            this.lblQuestionTitle = new Label();
            this.lblQuestionText = new Label();
            this.lblAnswerTitle = new Label();
            this.txtAnswer = new TextBox();
            this.btnVerify = new Button();
            this.lblNewPassTitle = new Label();
            this.txtNewPassword = new TextBox();
            this.btnReset = new Button();
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
            this.lblTitle.Text = "KHÔI PHỤC MẬT KHẨU";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.ForeColor = Color.Black;
            this.lblUserTitle.Location = new Point(30, 65);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new Size(360, 18);
            this.lblUserTitle.TabIndex = 1;
            this.lblUserTitle.Text = "Nhập tên đăng nhập:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = Color.White;
            this.txtUsername.BorderStyle = BorderStyle.FixedSingle;
            this.txtUsername.ForeColor = Color.Black;
            this.txtUsername.Location = new Point(30, 85);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(250, 25);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "user";
            // 
            // btnCheckUser
            // 
            this.btnCheckUser.BackColor = Color.RoyalBlue;
            this.btnCheckUser.FlatAppearance.BorderSize = 0;
            this.btnCheckUser.FlatStyle = FlatStyle.Flat;
            this.btnCheckUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnCheckUser.ForeColor = Color.White;
            this.btnCheckUser.Location = new Point(290, 83);
            this.btnCheckUser.Name = "btnCheckUser";
            this.btnCheckUser.Size = new Size(100, 27);
            this.btnCheckUser.TabIndex = 3;
            this.btnCheckUser.Text = "Kiểm Tra";
            this.btnCheckUser.UseVisualStyleBackColor = false;
            // 
            // lblQuestionTitle
            // 
            this.lblQuestionTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblQuestionTitle.ForeColor = Color.RoyalBlue;
            this.lblQuestionTitle.Location = new Point(30, 130);
            this.lblQuestionTitle.Name = "lblQuestionTitle";
            this.lblQuestionTitle.Size = new Size(360, 18);
            this.lblQuestionTitle.TabIndex = 4;
            this.lblQuestionTitle.Text = "Câu hỏi bảo mật của bạn:";
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.BackColor = Color.FromArgb(224, 224, 224);
            this.lblQuestionText.BorderStyle = BorderStyle.FixedSingle;
            this.lblQuestionText.Location = new Point(30, 155);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Padding = new Padding(5);
            this.lblQuestionText.Size = new Size(360, 35);
            this.lblQuestionText.TabIndex = 5;
            this.lblQuestionText.Text = "Ten me cua ban la gi?";
            this.lblQuestionText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAnswerTitle
            // 
            this.lblAnswerTitle.ForeColor = Color.Black;
            this.lblAnswerTitle.Location = new Point(30, 205);
            this.lblAnswerTitle.Name = "lblAnswerTitle";
            this.lblAnswerTitle.Size = new Size(360, 18);
            this.lblAnswerTitle.TabIndex = 6;
            this.lblAnswerTitle.Text = "Nhập câu trả lời bảo mật:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = Color.White;
            this.txtAnswer.BorderStyle = BorderStyle.FixedSingle;
            this.txtAnswer.ForeColor = Color.Black;
            this.txtAnswer.Location = new Point(30, 225);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new Size(250, 25);
            this.txtAnswer.TabIndex = 7;
            this.txtAnswer.Text = "Nguyen Thi A";
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = Color.ForestGreen;
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = FlatStyle.Flat;
            this.btnVerify.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnVerify.ForeColor = Color.White;
            this.btnVerify.Location = new Point(290, 223);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new Size(100, 27);
            this.btnVerify.TabIndex = 8;
            this.btnVerify.Text = "Xác Nhận";
            this.btnVerify.UseVisualStyleBackColor = false;
            // 
            // lblNewPassTitle
            // 
            this.lblNewPassTitle.ForeColor = Color.Black;
            this.lblNewPassTitle.Location = new Point(30, 275);
            this.lblNewPassTitle.Name = "lblNewPassTitle";
            this.lblNewPassTitle.Size = new Size(360, 18);
            this.lblNewPassTitle.TabIndex = 9;
            this.lblNewPassTitle.Text = "Nhập mật khẩu mới:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = Color.White;
            this.txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtNewPassword.ForeColor = Color.Black;
            this.txtNewPassword.Location = new Point(30, 295);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new Size(250, 25);
            this.txtNewPassword.TabIndex = 10;
            this.txtNewPassword.Text = "123456";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = Color.DarkOrange;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = FlatStyle.Flat;
            this.btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnReset.ForeColor = Color.White;
            this.btnReset.Location = new Point(290, 293);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new Size(100, 27);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Đặt Lại";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = Color.FromArgb(71, 85, 105);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.Location = new Point(30, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(360, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "QUAY LẠI ĐĂNG NHẬP";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 17F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.ClientSize = new Size(420, 420);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUserTitle);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnCheckUser);
            this.Controls.Add(this.lblQuestionTitle);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.lblAnswerTitle);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lblNewPassTitle);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.Font = new Font("Segoe UI", 9.5F);
            this.ForeColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPasswordForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Khôi Phục Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUserTitle;
        private TextBox txtUsername;
        private Button btnCheckUser;
        private Label lblQuestionTitle;
        private Label lblQuestionText;
        private Label lblAnswerTitle;
        private TextBox txtAnswer;
        private Button btnVerify;
        private Label lblNewPassTitle;
        private TextBox txtNewPassword;
        private Button btnReset;
        private Button btnCancel;
    }
}
