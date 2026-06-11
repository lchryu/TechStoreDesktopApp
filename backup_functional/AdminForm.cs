using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class AdminForm : Form
    {
        private AppDatabase _db = null!;
        private UserAccount _currentUser = null!;
        private string _activePage = "dashboard";

        // Style Colors matching MainForm
        private readonly Color ColorBgMain = Color.FromArgb(240, 240, 240);
        private readonly Color ColorBgSurface = Color.White;
        private readonly Color ColorPrimary = Color.RoyalBlue;
        private readonly Color ColorAccent = Color.ForestGreen;
        private readonly Color ColorTextPrimary = Color.Black;
        private readonly Color ColorTextSecondary = Color.FromArgb(64, 64, 64);

        public AdminForm(UserAccount loggedInUser)
        {
            _db = AppDatabase.Load();
            _currentUser = loggedInUser;
            InitializeComponent();

            lblUserInfo.Text = $"Xin chào, {_currentUser.FullName}";
            lblUserRole.Text = "Vai trò: Quản trị viên";

            WireEvents();
            SwitchPage("dashboard");
        }

        private void WireEvents()
        {
            btnMenuDashboard.Click += (s, e) => SwitchPage("dashboard");
            btnMenuInventory.Click += (s, e) => SwitchPage("inventory");
            btnMenuOrders.Click += (s, e) => SwitchPage("orders");
            btnMenuUsers.Click += (s, e) => SwitchPage("users");
            
            btnMenuLogout.Click += (s, e) =>
            {
                var res = MessageBox.Show("Bạn có muốn đăng xuất khỏi tài khoản không?", "Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                }
            };

            // Inventory operations
            btnAdminAddProduct.Click += (s, e) => AddNewProductAdmin();
            txtAdminSearch.TextChanged += (s, e) => RefreshInventoryTable();
            dgvInventory.CellContentClick += DgvInventory_CellContentClick;

            // Orders operations
            btnOrderDetails.Click += BtnOrderDetails_Click;
            btnOrderShipping.Click += (s, e) => UpdateOrderStatus("Đang giao");
            btnOrderComplete.Click += (s, e) => UpdateOrderStatus("Đã giao");
            btnOrderCancel.Click += (s, e) => UpdateOrderStatus("Đã hủy");

            // Users operations
            btnMakeAdmin.Click += (s, e) => ChangeUserRole("admin");
            btnMakeCustomer.Click += (s, e) => ChangeUserRole("customer");
            btnDeleteUser.Click += BtnDeleteUser_Click;
        }

        private void SwitchPage(string pageName)
        {
            _activePage = pageName;

            // Hide all panels
            panelDashboard.Visible = false;
            panelInventory.Visible = false;
            panelOrders.Visible = false;
            panelUsers.Visible = false;

            // Reset menu buttons style
            List<Button> buttons = new List<Button> { btnMenuDashboard, btnMenuInventory, btnMenuOrders, btnMenuUsers };
            foreach (var btn in buttons)
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            }

            if (pageName == "dashboard")
            {
                panelDashboard.Visible = true;
                btnMenuDashboard.BackColor = Color.White;
                btnMenuDashboard.ForeColor = Color.RoyalBlue;
                btnMenuDashboard.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshDashboard();
            }
            else if (pageName == "inventory")
            {
                panelInventory.Visible = true;
                btnMenuInventory.BackColor = Color.White;
                btnMenuInventory.ForeColor = Color.RoyalBlue;
                btnMenuInventory.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshInventoryTable();
            }
            else if (pageName == "orders")
            {
                panelOrders.Visible = true;
                btnMenuOrders.BackColor = Color.White;
                btnMenuOrders.ForeColor = Color.RoyalBlue;
                btnMenuOrders.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshOrdersTable();
            }
            else if (pageName == "users")
            {
                panelUsers.Visible = true;
                btnMenuUsers.BackColor = Color.White;
                btnMenuUsers.ForeColor = Color.RoyalBlue;
                btnMenuUsers.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshUsersTable();
            }
        }

        // ==========================================================================
        // 1. DASHBOARD
        // ==========================================================================
        private void RefreshDashboard()
        {
            // Calculate metrics
            lblStatRevenue.Text = string.Format("{0:N0} ₫", _db.Sales.Revenue);
            lblStatOrders.Text = _db.Sales.Orders.ToString();

            int lowStock = _db.Products.Count(p => p.Stock < 5);
            lblStatLowStock.Text = lowStock.ToString();
            lblStatTotalProducts.Text = _db.Products.Count.ToString();

            // Populate history list
            lstSalesHistory.Items.Clear();
            var history = _db.Sales.History;
            if (history != null)
            {
                foreach (var rec in history)
                {
                    lstSalesHistory.Items.Add($"Ngày: {rec.Date,-15} | Doanh thu: {rec.Amount:N0} ₫");
                }
            }
        }

        // ==========================================================================
        // 2. INVENTORY
        // ==========================================================================
        private void RefreshInventoryTable()
        {
            dgvInventory.Rows.Clear();
            string query = txtAdminSearch.Text.ToLower();

            var filtered = _db.Products.Where(p =>
                p.Name.ToLower().Contains(query) ||
                p.Category.ToLower().Contains(query) ||
                p.Id.ToLower().Contains(query)
            ).ToList();

            foreach (var p in filtered)
            {
                string statusText = "Sẵn có";
                if (p.Stock == 0) statusText = "Hết hàng";
                else if (p.Stock < 5) statusText = "Sắp hết";

                dgvInventory.Rows.Add(
                    p.Id,
                    p.Name,
                    p.Category,
                    string.Format("{0:N0} ₫", p.Price),
                    p.Stock,
                    statusText
                );
            }
        }

        private void DgvInventory_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string productId = dgvInventory.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
            var product = _db.Products.FirstOrDefault(p => p.Id == productId);
            if (product == null) return;

            // Edit column clicked
            if (e.ColumnIndex == 6)
            {
                using (var prodForm = new ProductForm(product))
                {
                    if (prodForm.ShowDialog(this) == DialogResult.OK)
                    {
                        var edited = prodForm.ResultProduct;
                        product.Name = edited.Name;
                        product.Category = edited.Category;
                        product.Price = edited.Price;
                        product.Stock = edited.Stock;
                        product.ImageUrl = edited.ImageUrl;
                        product.Description = edited.Description;
                        product.Specs = edited.Specs;

                        _db.Save();
                        RefreshInventoryTable();
                        MessageBox.Show("Cập nhật sản phẩm thành công!", "Quản Lý Kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            // Delete column clicked
            else if (e.ColumnIndex == 7)
            {
                var res = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm \"{product.Name}\"?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    _db.Products.Remove(product);
                    _db.Save();
                    RefreshInventoryTable();
                    MessageBox.Show("Xóa sản phẩm thành công!", "Quản Lý Kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AddNewProductAdmin()
        {
            using (var prodForm = new ProductForm(null))
            {
                if (prodForm.ShowDialog(this) == DialogResult.OK)
                {
                    _db.Products.Add(prodForm.ResultProduct);
                    _db.Save();
                    RefreshInventoryTable();
                    MessageBox.Show("Thêm sản phẩm mới thành công!", "Quản Lý Kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // ==========================================================================
        // 3. ORDERS
        // ==========================================================================
        private void RefreshOrdersTable()
        {
            dgvOrders.Rows.Clear();

            // Fetch all orders from all users
            foreach (var user in _db.Users)
            {
                if (user.OrderHistory == null) continue;
                foreach (var order in user.OrderHistory)
                {
                    dgvOrders.Rows.Add(
                        order.OrderId,
                        order.Date,
                        user.FullName,
                        string.Format("{0:N0} ₫", order.TotalAmount),
                        order.Status,
                        user.Username // Hidden reference helper column
                    );
                }
            }
        }

        private void BtnOrderDetails_Click(object? sender, EventArgs e)
        {
            var selectedOrder = GetSelectedOrder();
            if (selectedOrder != null)
            {
                using (var detailForm = new OrderDetailForm(selectedOrder))
                {
                    detailForm.ShowDialog(this);
                }
            }
        }

        private void UpdateOrderStatus(string newStatus)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng đơn hàng trước!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvOrders.SelectedRows[0];
            string orderId = row.Cells[0].Value?.ToString() ?? string.Empty;
            string username = row.Cells[5].Value?.ToString() ?? string.Empty;

            var user = _db.Users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (user != null)
            {
                var order = user.OrderHistory.FirstOrDefault(o => o.OrderId == orderId);
                if (order != null)
                {
                    order.Status = newStatus;
                    _db.Save();
                    RefreshOrdersTable();
                    MessageBox.Show($"Cập nhật trạng thái đơn #{orderId} thành '{newStatus}' thành công!", "Quản Lý Đơn Hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private UserOrder? GetSelectedOrder()
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng trước!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            var row = dgvOrders.SelectedRows[0];
            string orderId = row.Cells[0].Value?.ToString() ?? string.Empty;
            string username = row.Cells[5].Value?.ToString() ?? string.Empty;

            var user = _db.Users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (user != null)
            {
                var order = user.OrderHistory.FirstOrDefault(o => o.OrderId == orderId);
                if (order != null) return order;
            }

            MessageBox.Show("Không tìm thấy dữ liệu đơn hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        // ==========================================================================
        // 4. USERS
        // ==========================================================================
        private void RefreshUsersTable()
        {
            dgvUsers.Rows.Clear();
            foreach (var user in _db.Users)
            {
                dgvUsers.Rows.Add(
                    user.Username,
                    user.FullName,
                    user.Phone,
                    user.Address,
                    user.Role == "admin" ? "Quản Trị Viên" : "Khách Hàng"
                );
            }
        }

        private void ChangeUserRole(string newRole)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một người dùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = dgvUsers.SelectedRows[0].Cells[0].Value?.ToString() ?? string.Empty;

            // Don't demote yourself
            if (username.Equals(_currentUser.Username, StringComparison.OrdinalIgnoreCase) && newRole == "customer")
            {
                MessageBox.Show("Bạn không thể tự hạ quyền của chính mình!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _db.Users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (user != null)
            {
                user.Role = newRole;
                _db.Save();
                RefreshUsersTable();
                MessageBox.Show($"Đã thay đổi vai trò tài khoản \"{username}\" thành \"{newRole}\"!", "Quản Lý Người Dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDeleteUser_Click(object? sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một người dùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = dgvUsers.SelectedRows[0].Cells[0].Value?.ToString() ?? string.Empty;

            // Don't delete yourself
            if (username.Equals(_currentUser.Username, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Bạn không thể xóa tài khoản admin hiện tại của chính bạn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản \"{username}\"?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                var user = _db.Users.FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
                if (user != null)
                {
                    _db.Users.Remove(user);
                    _db.Save();
                    RefreshUsersTable();
                    MessageBox.Show("Đã xóa tài khoản thành công!", "Quản Lý Người Dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
