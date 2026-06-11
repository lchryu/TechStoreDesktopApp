using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class ForgotPasswordForm : Form
    {
        private AppDatabase _db;
        private UserAccount? _foundUser;

        public ForgotPasswordForm()
        {
            _db = AppDatabase.Load();
            InitializeComponent();
            WireEvents();
            ResetFormState();
        }

        private void ResetFormState()
        {
            lblQuestionTitle.Visible = false;
            lblQuestionText.Visible = false;
            lblAnswerTitle.Visible = false;
            txtAnswer.Visible = false;
            btnVerify.Visible = false;

            lblNewPassTitle.Visible = false;
            txtNewPassword.Visible = false;
            btnReset.Visible = false;

            txtUsername.Enabled = true;
            btnCheckUser.Enabled = true;
            _foundUser = null;
        }

        private void WireEvents()
        {
            btnCheckUser.Click += BtnCheckUser_Click;
            btnVerify.Click += BtnVerify_Click;
            btnReset.Click += BtnReset_Click;
            btnCancel.Click += (s, e) => {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
        }

        private void BtnCheckUser_Click(object? sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _db.Users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (user == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản này trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _foundUser = user;
            txtUsername.Enabled = false;
            btnCheckUser.Enabled = false;

            if (string.IsNullOrEmpty(user.SecurityQuestion))
            {
                // Fallback for old accounts without security question
                lblQuestionText.Text = "Tài khoản chưa được thiết lập câu hỏi bảo mật. Câu hỏi mặc định: Nơi bạn sinh ra ở đâu?";
                _foundUser.SecurityQuestion = "Nơi bạn sinh ra ở đâu?";
                _foundUser.SecurityAnswer = "Sài Gòn";
            }
            else
            {
                lblQuestionText.Text = user.SecurityQuestion;
            }

            lblQuestionTitle.Visible = true;
            lblQuestionText.Visible = true;
            lblAnswerTitle.Visible = true;
            txtAnswer.Visible = true;
            btnVerify.Visible = true;
            txtAnswer.Focus();
        }

        private void BtnVerify_Click(object? sender, EventArgs e)
        {
            if (_foundUser == null) return;

            string answer = txtAnswer.Text.Trim();
            if (string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Vui lòng nhập câu trả lời bảo mật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_foundUser.SecurityAnswer.Equals(answer, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Câu trả lời bảo mật không đúng! Vui lòng thử lại.", "Sai câu trả lời", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtAnswer.Enabled = false;
            btnVerify.Enabled = false;

            lblNewPassTitle.Visible = true;
            txtNewPassword.Visible = true;
            btnReset.Visible = true;
            txtNewPassword.Focus();
        }

        private void BtnReset_Click(object? sender, EventArgs e)
        {
            if (_foundUser == null) return;

            string newPass = txtNewPassword.Text;
            if (string.IsNullOrEmpty(newPass) || newPass.Length < 3)
            {
                MessageBox.Show("Mật khẩu mới phải từ 3 ký tự trở lên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update user in DB
            var dbUser = _db.Users.FirstOrDefault(u => u.Username.Equals(_foundUser.Username, StringComparison.OrdinalIgnoreCase));
            if (dbUser != null)
            {
                dbUser.Password = newPass;
                _db.Save();
                MessageBox.Show("Đặt lại mật khẩu thành công! Hãy đăng nhập lại bằng mật khẩu mới.", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
