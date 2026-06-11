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
            // Switch tabs
            btnTabLogin.Click += (s, e) => SwitchTab("login");
            btnTabRegister.Click += (s, e) => SwitchTab("register");

            // Submissions
            btnSubmitLogin.Click += BtnSubmitLogin_Click;
            btnSubmitRegister.Click += BtnSubmitRegister_Click;
        }

        private void SwitchTab(string tab)
        {
            if (tab == "login")
            {
                btnTabLogin.BackColor = Color.FromArgb(99, 102, 241);
                btnTabLogin.ForeColor = Color.White;
                btnTabRegister.BackColor = Color.Transparent;
                btnTabRegister.ForeColor = Color.FromArgb(148, 163, 184);

                panelRegister.Visible = false;
                panelLogin.Visible = true;
            }
            else
            {
                btnTabRegister.BackColor = Color.FromArgb(99, 102, 241);
                btnTabRegister.ForeColor = Color.White;
                btnTabLogin.BackColor = Color.Transparent;
                btnTabLogin.ForeColor = Color.FromArgb(148, 163, 184);

                panelLogin.Visible = false;
                panelRegister.Visible = true;
            }
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

            LoggedInUser = user;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnSubmitRegister_Click(object? sender, EventArgs e)
        {
            string username = txtRegUsername.Text.Trim();
            string password = txtRegPassword.Text;
            string fullName = txtRegName.Text.Trim();
            string phone = txtRegPhone.Text.Trim();
            string address = txtRegAddress.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc (*)", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_db.Users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại! Vui lòng chọn tên khác.", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create new customer account
            var newAccount = new UserAccount
            {
                Username = username,
                Password = password,
                FullName = fullName,
                Phone = phone,
                Address = address,
                Role = "customer"
            };

            _db.Users.Add(newAccount);
            _db.Save();

            MessageBox.Show("Đăng ký tài khoản thành công! Bạn có thể sử dụng tài khoản này để đăng nhập ngay.", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Auto fill login inputs and switch to login tab
            txtLogUsername.Text = username;
            txtLogPassword.Text = password;
            SwitchTab("login");

            // Reset register form inputs
            txtRegUsername.Text = "";
            txtRegPassword.Text = "";
            txtRegName.Text = "";
            txtRegPhone.Text = "";
            txtRegAddress.Text = "";
        }
    }
}
