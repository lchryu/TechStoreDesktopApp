using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class RegisterForm : Form
    {
        private AppDatabase _db;

        public RegisterForm()
        {
            _db = AppDatabase.Load();
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            btnRegister.Click += BtnRegister_Click;
            btnCancel.Click += (s, e) => {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
        }

        private void BtnRegister_Click(object? sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string fullName = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string question = cbSecurityQuestion.SelectedItem?.ToString() ?? string.Empty;
            string answer = txtSecurityAnswer.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || 
                string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phone) || 
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(question) || 
                string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Vui lòng điền đầy đủ tất cả thông tin!", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_db.Users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại! Vui lòng chọn tên khác.", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create new customer account with security question
            var newAccount = new UserAccount
            {
                Username = username,
                Password = password,
                FullName = fullName,
                Phone = phone,
                Address = address,
                SecurityQuestion = question,
                SecurityAnswer = answer,
                Role = "customer"
            };

            _db.Users.Add(newAccount);
            _db.Save();

            MessageBox.Show("Đăng ký tài khoản thành công! Bạn có thể sử dụng tài khoản này để đăng nhập.", "Đăng Ký Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
