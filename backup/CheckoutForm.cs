using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class CheckoutForm : Form
    {
        private List<CartItem> _cart;
        private decimal _totalAmount;

        public string CustomerName { get; private set; } = string.Empty;
        public string CustomerPhone { get; private set; } = string.Empty;
        public string CustomerAddress { get; private set; } = string.Empty;
        public string PaymentMethod { get; private set; } = "cod";

        public CheckoutForm(List<CartItem> cart)
        {
            _cart = cart;
            InitializeComponent();
            
            // Wire events
            btnConfirm.Click += BtnConfirm_Click;
            btnCancel.Click += (s, e) => {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            LoadOrderSummary();
        }

        private void LoadOrderSummary()
        {
            lstSummary.Items.Clear();
            _totalAmount = 0;

            foreach (var item in _cart)
            {
                decimal rowTotal = item.Price * item.Quantity;
                _totalAmount += rowTotal;
                
                string lineText = $"{item.Name}";
                string qtyText = $"   x{item.Quantity}  ->  {rowTotal:N0} ₫";
                
                lstSummary.Items.Add(lineText);
                lstSummary.Items.Add(qtyText);
                lstSummary.Items.Add(string.Empty);
            }

            lblTotal.Text = string.Format("Tổng: {0:N0} ₫", _totalAmount);
        }

        private void BtnConfirm_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng điền Họ và Tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng điền Số Điện Thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Vui lòng điền Địa Chỉ Nhận Hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }

            CustomerName = txtName.Text.Trim();
            CustomerPhone = txtPhone.Text.Trim();
            CustomerAddress = txtAddress.Text.Trim();
            PaymentMethod = cbPayment.SelectedIndex == 0 ? "cod" : (cbPayment.SelectedIndex == 1 ? "bank" : "e-wallet");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
