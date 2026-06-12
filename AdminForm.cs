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

        private static string GetProjectDirectory([System.Runtime.CompilerServices.CallerFilePath] string sourceFilePath = "")
        {
            return System.IO.Path.GetDirectoryName(sourceFilePath) ?? "";
        }

        private static bool IsDesignMode()
        {
            try
            {
                string proc = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
                if (proc.IndexOf("DesignToolsServer", StringComparison.OrdinalIgnoreCase) >= 0 ||
                    proc.IndexOf("devenv", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    return true;
                }
            }
            catch { }
            return System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime;
        }

        public AdminForm()
        {
            _db = AppDatabase.Load();
            _currentUser = new UserAccount { FullName = "Quản trị viên Demo", Username = "admin", Role = "admin" };
            InitializeComponent();

            if (IsDesignMode())
            {
                lblUserInfo.Text = "Xin chào, Quản trị viên Demo";
                lblUserRole.Text = "Vai trò: Quản trị viên";

                try
                {
                    string projDir = GetProjectDirectory();
                    string piePath = System.IO.Path.Combine(projDir, "chart_pie_mock.png");
                    string revPath = System.IO.Path.Combine(projDir, "chart_revenue_mock.png");

                    if (System.IO.File.Exists(piePath))
                        pbPieChartMock.Image = Image.FromFile(piePath);
                    if (System.IO.File.Exists(revPath))
                        pbRevenueChartMock.Image = Image.FromFile(revPath);
                }
                catch
                {
                    // Fail silently to prevent designer crash
                }
                return;
            }

            // Hide design-time previews at runtime
            pbPieChartMock.Visible = false;
            pbRevenueChartMock.Visible = false;

            lblUserInfo.Text = $"Xin chào, {_currentUser.FullName}";
            lblUserRole.Text = "Vai trò: Quản trị viên";

            WireEvents();
            SwitchPage("dashboard");
        }

        public AdminForm(UserAccount loggedInUser)
        {
            _db = AppDatabase.Load();
            _currentUser = loggedInUser;
            InitializeComponent();

            // Hide design-time previews at runtime
            pbPieChartMock.Visible = false;
            pbRevenueChartMock.Visible = false;

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
            btnMenuVouchers.Click += (s, e) => SwitchPage("vouchers");
            btnMenuFeedback.Click += (s, e) => SwitchPage("feedback");
            btnMenuSettings.Click += (s, e) => SwitchPage("settings");
            
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

            // Vouchers operations
            btnVchAdd.Click += BtnVchAdd_Click;
            btnVchDelete.Click += BtnVchDelete_Click;

            // Feedback operations
            btnFeedbackResolve.Click += BtnFeedbackResolve_Click;
            btnFeedbackDelete.Click += BtnFeedbackDelete_Click;

            // Settings operations
            btnSettingsSave.Click += BtnSettingsSave_Click;

        }

        private void SwitchPage(string pageName)
        {
            _activePage = pageName;

            // Hide all panels
            panelDashboard.Visible = false;
            panelInventory.Visible = false;
            panelOrders.Visible = false;
            panelUsers.Visible = false;
            panelVouchers.Visible = false;
            panelFeedback.Visible = false;
            panelSettings.Visible = false;

            // Reset menu buttons style
            List<Button> buttons = new List<Button> { 
                btnMenuDashboard, btnMenuInventory, btnMenuOrders, btnMenuUsers,
                btnMenuVouchers, btnMenuFeedback, btnMenuSettings
            };
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
            else if (pageName == "vouchers")
            {
                panelVouchers.Visible = true;
                btnMenuVouchers.BackColor = Color.White;
                btnMenuVouchers.ForeColor = Color.RoyalBlue;
                btnMenuVouchers.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshVouchersTable();
            }
            else if (pageName == "feedback")
            {
                panelFeedback.Visible = true;
                btnMenuFeedback.BackColor = Color.White;
                btnMenuFeedback.ForeColor = Color.RoyalBlue;
                btnMenuFeedback.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshFeedbackTable();
            }
            else if (pageName == "settings")
            {
                panelSettings.Visible = true;
                btnMenuSettings.BackColor = Color.White;
                btnMenuSettings.ForeColor = Color.RoyalBlue;
                btnMenuSettings.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                LoadSettings();
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

            // Redraw pie chart and revenue chart
            panelPieChart.Invalidate();
            panelRevenueChart.Invalidate();
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

        // ==========================================================================
        // 5. VOUCHERS MANAGEMENT
        // ==========================================================================
        private void RefreshVouchersTable()
        {
            dgvVouchers.Rows.Clear();
            foreach (var v in _db.Vouchers)
            {
                dgvVouchers.Rows.Add(
                    v.Code,
                    v.Description,
                    $"{v.DiscountPercent}%",
                    string.Format("{0:N0} ₫", v.MaxDiscount)
                );
            }
        }

        private void BtnVchAdd_Click(object? sender, EventArgs e)
        {
            string code = txtVchCode.Text.Trim().ToUpper();
            string desc = txtVchDesc.Text.Trim();
            string pctText = txtVchPercent.Text.Trim();
            string maxText = txtVchMax.Text.Trim();

            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(desc) || string.IsNullOrEmpty(pctText) || string.IsNullOrEmpty(maxText))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin Voucher!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_db.Vouchers.Any(v => v.Code.Equals(code, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã Voucher này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(pctText, out decimal percent) || percent <= 0 || percent > 100)
            {
                MessageBox.Show("Phần trăm giảm giá phải là số từ 1 đến 100!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(maxText, out decimal maxDiscount) || maxDiscount < 0)
            {
                MessageBox.Show("Giảm tối đa phải là số không âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newVoucher = new Voucher
            {
                Code = code,
                Description = desc,
                DiscountPercent = percent,
                MaxDiscount = maxDiscount
            };

            _db.Vouchers.Add(newVoucher);
            _db.Save();

            // Clear inputs
            txtVchCode.Clear();
            txtVchDesc.Clear();
            txtVchPercent.Clear();
            txtVchMax.Clear();

            RefreshVouchersTable();
            MessageBox.Show("Thêm Voucher mới thành công!", "Quản Lý Vouchers", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnVchDelete_Click(object? sender, EventArgs e)
        {
            if (dgvVouchers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng Voucher cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string code = dgvVouchers.SelectedRows[0].Cells[0].Value?.ToString() ?? string.Empty;
            var voucher = _db.Vouchers.FirstOrDefault(v => v.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
            if (voucher != null)
            {
                var res = MessageBox.Show($"Bạn có chắc chắn muốn xóa mã Voucher \"{code}\"?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    _db.Vouchers.Remove(voucher);
                    _db.Save();
                    RefreshVouchersTable();
                    MessageBox.Show("Xóa Voucher thành công!", "Quản Lý Vouchers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // ==========================================================================
        // 6. FEEDBACK MANAGEMENT
        // ==========================================================================
        private void RefreshFeedbackTable()
        {
            dgvFeedback.Rows.Clear();
            foreach (var fb in _db.Feedbacks)
            {
                dgvFeedback.Rows.Add(
                    fb.Id,
                    fb.CustomerName,
                    fb.Email,
                    fb.Date,
                    fb.Status,
                    fb.Message
                );
            }
        }

        private void BtnFeedbackResolve_Click(object? sender, EventArgs e)
        {
            if (dgvFeedback.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một phản hồi cần xử lý!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fbId = dgvFeedback.SelectedRows[0].Cells[0].Value?.ToString() ?? string.Empty;
            var fb = _db.Feedbacks.FirstOrDefault(f => f.Id == fbId);
            if (fb != null)
            {
                fb.Status = "Đã giải quyết";
                _db.Save();
                RefreshFeedbackTable();
                MessageBox.Show($"Đã đánh dấu phản hồi #{fbId} là 'Đã giải quyết'!", "Phản Hồi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnFeedbackDelete_Click(object? sender, EventArgs e)
        {
            if (dgvFeedback.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một phản hồi cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fbId = dgvFeedback.SelectedRows[0].Cells[0].Value?.ToString() ?? string.Empty;
            var fb = _db.Feedbacks.FirstOrDefault(f => f.Id == fbId);
            if (fb != null)
            {
                var res = MessageBox.Show($"Bạn có chắc chắn muốn xóa phản hồi #{fbId}?", "Xác Nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    _db.Feedbacks.Remove(fb);
                    _db.Save();
                    RefreshFeedbackTable();
                    MessageBox.Show("Xóa phản hồi thành công!", "Phản Hồi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // ==========================================================================
        // 7. SYSTEM CONFIGURATION
        // ==========================================================================
        private void LoadSettings()
        {
            txtSettingsStoreName.Text = _db.Settings.StoreName;
            txtSettingsHotline.Text = _db.Settings.Hotline;
            txtSettingsEmail.Text = _db.Settings.Email;
            txtSettingsAddress.Text = _db.Settings.Address;
            chkSettingsMaintenance.Checked = _db.Settings.IsMaintenanceMode;
        }

        private void BtnSettingsSave_Click(object? sender, EventArgs e)
        {
            string storeName = txtSettingsStoreName.Text.Trim();
            string hotline = txtSettingsHotline.Text.Trim();
            string email = txtSettingsEmail.Text.Trim();
            string address = txtSettingsAddress.Text.Trim();
            bool maintenance = chkSettingsMaintenance.Checked;

            if (string.IsNullOrEmpty(storeName) || string.IsNullOrEmpty(hotline) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin cấu hình cửa hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _db.Settings.StoreName = storeName;
            _db.Settings.Hotline = hotline;
            _db.Settings.Email = email;
            _db.Settings.Address = address;
            _db.Settings.IsMaintenanceMode = maintenance;
            _db.Save();

            MessageBox.Show("Lưu cấu hình hệ thống thành công!", "Cấu Hình Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PanelPieChart_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime || _db == null)
            {
                g.Clear(Color.White);
                var previewCounts = new (int count, Color color, string label)[]
                {
                    (4, Color.FromArgb(71, 85, 105), "Apple"),
                    (3, Color.FromArgb(59, 130, 246), "Samsung"),
                    (3, Color.FromArgb(249, 115, 22), "Xiaomi"),
                    (3, Color.FromArgb(16, 185, 129), "Laptops"),
                    (4, Color.FromArgb(236, 72, 153), "Watches"),
                    (4, Color.FromArgb(107, 114, 128), "Accessories")
                };

                int totalPreview = previewCounts.Sum(item => item.count);
                float currentAnglePreview = 0;
                int legendYPreview = 80;



                foreach (var item in previewCounts)
                {
                    float sweepAngle = 360f * item.count / totalPreview;
                    using (var brush = new SolidBrush(item.color))
                    {
                        g.FillPie(brush, 30, 80, 220, 220, currentAnglePreview, sweepAngle);
                        g.FillRectangle(brush, 280, legendYPreview, 15, 15);
                    }

                    g.DrawPie(Pens.White, 30, 80, 220, 220, currentAnglePreview, sweepAngle);
                    using (Font legendFont = new Font("Segoe UI", 9.5F))
                    {
                        string pctText = string.Format("{0} ({1:P0})", item.label, (double)item.count / totalPreview);
                        g.DrawString(pctText, legendFont, Brushes.Black, new PointF(305, legendYPreview - 2));
                    }

                    currentAnglePreview += sweepAngle;
                    legendYPreview += 30;
                }

                return;
            }

            // Get product category counts
            var categoryCounts = new Dictionary<string, (int count, Color color, string displayName)>();
            categoryCounts["Apple"] = (_db.Products.Count(p => p.Category == "phone_apple"), Color.FromArgb(71, 85, 105), "Apple");
            categoryCounts["Samsung"] = (_db.Products.Count(p => p.Category == "phone_samsung"), Color.FromArgb(59, 130, 246), "Samsung");
            categoryCounts["Xiaomi"] = (_db.Products.Count(p => p.Category == "phone_xiaomi"), Color.FromArgb(249, 115, 22), "Xiaomi");
            categoryCounts["Laptop"] = (_db.Products.Count(p => p.Category == "laptop"), Color.FromArgb(16, 185, 129), "Laptops");
            categoryCounts["Smartwatch"] = (_db.Products.Count(p => p.Category == "watch"), Color.FromArgb(236, 72, 153), "Watches");
            categoryCounts["Phụ kiện"] = (_db.Products.Count(p => p.Category == "accessory"), Color.FromArgb(107, 114, 128), "Accessories");

            int totalProducts = categoryCounts.Values.Sum(v => v.count);
            if (totalProducts == 0) return;

            // Drawing coordinates
            int pieWidth = 220;
            int pieHeight = 220;
            int pieX = 30;
            int pieY = 80;

            float currentAngle = 0;
            int legendY = 80;



            foreach (var kvp in categoryCounts)
            {
                if (kvp.Value.count == 0) continue;

                float sweepAngle = 360f * kvp.Value.count / totalProducts;

                // Draw pie slice
                using (var brush = new SolidBrush(kvp.Value.color))
                {
                    g.FillPie(brush, pieX, pieY, pieWidth, pieHeight, currentAngle, sweepAngle);
                }

                // Draw slices boundaries
                g.DrawPie(Pens.White, pieX, pieY, pieWidth, pieHeight, currentAngle, sweepAngle);

                // Draw Legend Item
                using (var brush = new SolidBrush(kvp.Value.color))
                {
                    g.FillRectangle(brush, 280, legendY, 15, 15);
                }
                
                using (Font legendFont = new Font("Segoe UI", 9.5F))
                {
                    string pctText = string.Format("{0} ({1:P0})", kvp.Value.displayName, (double)kvp.Value.count / totalProducts);
                    g.DrawString(pctText, legendFont, Brushes.Black, new PointF(305, legendY - 2));
                }
                legendY += 30;

                currentAngle += sweepAngle;
            }
        }

        private void PanelRevenueChart_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Clear background
            g.Clear(Color.White);

            // Fetch data (fallback if empty or at design-time)
            List<SalesRecord> history;
            if (DesignMode || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime || _db == null || _db.Sales == null || _db.Sales.History == null || _db.Sales.History.Count == 0)
            {
                history = new List<SalesRecord>
                {
                    new SalesRecord { Date = "04/06", Amount = 15400000 },
                    new SalesRecord { Date = "05/06", Amount = 29990000 },
                    new SalesRecord { Date = "06/06", Amount = 8490000 },
                    new SalesRecord { Date = "07/06", Amount = 45990000 },
                    new SalesRecord { Date = "08/06", Amount = 2450000 },
                    new SalesRecord { Date = "09/06", Amount = 39990000 },
                    new SalesRecord { Date = "10/06", Amount = 3490000 }
                };
            }
            else
            {
                history = _db.Sales.History;
            }



            if (history.Count == 0) return;

            // Chart area bounds
            int paddingLeft = 55;
            int paddingRight = 20;
            int paddingTop = 60;
            int paddingBottom = 40;

            int width = panelRevenueChart.Width;
            int height = panelRevenueChart.Height;

            int chartWidth = width - paddingLeft - paddingRight;
            int chartHeight = height - paddingTop - paddingBottom;

            decimal maxAmount = history.Max(h => h.Amount);
            if (maxAmount <= 0) maxAmount = 1;

            // Draw Y-Axis lines and labels
            using (Pen gridPen = new Pen(Color.FromArgb(235, 235, 235), 1))
            using (Font labelFont = new Font("Segoe UI", 8F))
            {
                int yGridLines = 4;
                for (int i = 0; i <= yGridLines; i++)
                {
                    float y = paddingTop + chartHeight - (chartHeight * i / (float)yGridLines);
                    g.DrawLine(gridPen, paddingLeft, y, width - paddingRight, y);

                    decimal gridVal = maxAmount * i / yGridLines;
                    string label = string.Format("{0:N0} d", gridVal);
                    if (gridVal >= 1000000)
                    {
                        label = string.Format("{0:0.#}M d", gridVal / 1000000m);
                    }
                    g.DrawString(label, labelFont, Brushes.Gray, new PointF(5, y - 6));
                }
            }

            // Draw X-Axis labels & Bar/Line points
            float xStep = (float)chartWidth / Math.Max(1, history.Count - 1);
            if (history.Count == 1) xStep = chartWidth;

            PointF[] points = new PointF[history.Count];
            for (int i = 0; i < history.Count; i++)
            {
                float x = paddingLeft + (i * xStep);
                float y = paddingTop + chartHeight - (float)((decimal)chartHeight * history[i].Amount / maxAmount);
                points[i] = new PointF(x, y);

                // Draw X-Axis labels
                using (Font labelFont = new Font("Segoe UI", 8F))
                {
                    string dateLabel = history[i].Date;
                    g.DrawString(dateLabel, labelFont, Brushes.Gray, new PointF(x - 12, paddingTop + chartHeight + 8));
                }
            }

            // Draw Line / Bars
            if (points.Length > 1)
            {
                // Draw filled gradient area under the curve
                using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    path.AddLine(points[0].X, paddingTop + chartHeight, points[0].X, points[0].Y);
                    for (int i = 1; i < points.Length; i++)
                    {
                        path.AddLine(points[i - 1].X, points[i - 1].Y, points[i].X, points[i].Y);
                    }
                    path.AddLine(points[points.Length - 1].X, points[points.Length - 1].Y, points[points.Length - 1].X, paddingTop + chartHeight);
                    path.CloseFigure();

                    using (System.Drawing.Drawing2D.LinearGradientBrush areaBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
                        new PointF(0, paddingTop),
                        new PointF(0, paddingTop + chartHeight),
                        Color.FromArgb(80, Color.RoyalBlue),
                        Color.FromArgb(5, Color.RoyalBlue)))
                    {
                        g.FillPath(areaBrush, path);
                    }
                }

                // Draw connecting line
                using (Pen linePen = new Pen(Color.RoyalBlue, 2.5f))
                {
                    g.DrawLines(linePen, points);
                }
            }

            // Draw data point circles
            foreach (var pt in points)
            {
                g.FillEllipse(Brushes.White, pt.X - 4, pt.Y - 4, 8, 8);
                g.DrawEllipse(Pens.RoyalBlue, pt.X - 4, pt.Y - 4, 8, 8);
            }
        }
    }
}
