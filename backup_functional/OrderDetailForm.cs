using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class OrderDetailForm : Form
    {
        private UserOrder _order;

        public OrderDetailForm(UserOrder order)
        {
            _order = order;
            InitializeComponent();
            PopulateOrderDetails();
            btnClose.Click += (s, e) => this.Close();
        }

        private void PopulateOrderDetails()
        {
            lblOrderId.Text = $"Mã đơn hàng: #{_order.OrderId}";
            lblOrderDate.Text = $"Ngày đặt hàng: {_order.Date}";
            lblStatus.Text = $"Trạng thái: {_order.Status}";

            // Color code the status
            if (_order.Status == "Thành công" || _order.Status == "Đã giao")
            {
                lblStatus.ForeColor = Color.ForestGreen;
            }
            else if (_order.Status == "Đang giao" || _order.Status == "Đang xử lý" || _order.Status == "Chờ xử lý")
            {
                lblStatus.ForeColor = Color.OrangeRed;
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
            }

            lblTotalAmount.Text = string.Format("TỔNG TIỀN: {0:N0} ₫", _order.TotalAmount);

            // Populate items list
            lstItems.Items.Clear();
            if (!string.IsNullOrEmpty(_order.ItemsSummary))
            {
                string[] items = _order.ItemsSummary.Split(',');
                foreach (var item in items)
                {
                    string cleaned = item.Trim();
                    if (!string.IsNullOrEmpty(cleaned))
                    {
                        lstItems.Items.Add($" • {cleaned}");
                    }
                }
            }
            else
            {
                lstItems.Items.Add("Không có chi tiết sản phẩm.");
            }
        }
    }
}
