using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class LoginForm : Form
    {
        private AppDatabase _db;
        public UserAccount? LoggedInUser { get; private set; }

        public LoginForm()
        {
            _db = AppDatabase.Load();
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            btnSubmitLogin.Click += BtnSubmitLogin_Click;

            btnOpenRegister.Click += (s, e) =>
            {
                using (var regForm = new RegisterForm())
                {
                    if (regForm.ShowDialog(this) == DialogResult.OK)
                    {
                        // Refresh db context to reload newly created account
                        _db = AppDatabase.Load();
                    }
                }
            };

            btnOpenForgotPassword.Click += (s, e) =>
            {
                using (var fpForm = new ForgotPasswordForm())
                {
                    if (fpForm.ShowDialog(this) == DialogResult.OK)
                    {
                        // Refresh db context to reload reset password
                        _db = AppDatabase.Load();
                    }
                }
            };
        }

        private void BtnSubmitLogin_Click(object? sender, EventArgs e)
        {
            string username = txtLogUsername.Text.Trim();
            string password = txtLogPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền tên đăng nhập và mật khẩu!", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _db.Users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Password == password);
            if (user == null)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_db.Settings.IsMaintenanceMode && user.Role != "admin")
            {
                MessageBox.Show("Hệ thống hiện đang bảo trì định kỳ! Khách hàng tạm thời không thể đăng nhập. Xin lỗi vì sự bất tiện này.", "Hệ Thống Bảo Trì", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoggedInUser = user;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
