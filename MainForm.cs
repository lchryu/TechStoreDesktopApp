using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class MainForm : Form
    {
        // Database & Active User context
        private AppDatabase _db = null!;
        private UserAccount _currentUser = null!;
        private static List<CartItem> _cart = new List<CartItem>();
        private string _activeCategory = "all";
        private string _activePage = "home";
        private Voucher? _appliedVoucher = null;
        private decimal _discountAmount = 0;

        // Style Colors
        private readonly Color ColorBgMain = Color.FromArgb(240, 240, 240);
        private readonly Color ColorBgSurface = Color.White;
        private readonly Color ColorBgSurfaceHover = Color.FromArgb(230, 242, 255);
        private readonly Color ColorPrimary = Color.RoyalBlue;
        private readonly Color ColorAccent = Color.ForestGreen;
        private readonly Color ColorTextPrimary = Color.Black;
        private readonly Color ColorTextSecondary = Color.FromArgb(64, 64, 64);

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

        public MainForm()
        {
            _db = AppDatabase.Load();
            _currentUser = new UserAccount { FullName = "Khách Hàng Demo", Username = "demo", Role = "customer" };
            InitializeComponent();
            
            // Design mode check to prevent running runtime wire-ups
            if (IsDesignMode())
            {
                lblUserInfo.Text = "Xin chào, Khách Hàng Demo";
                lblUserRole.Text = "Vai trò: Khách hàng";
                return;
            }

            cbPriceFilter.SelectedIndex = 0;
            cbSortFilter.SelectedIndex = 0;
            lblUserInfo.Text = $"Xin chào, {_currentUser.FullName}";
            lblUserRole.Text = "Vai trò: Khách hàng";

            ApplySystemSettings();
            WireMenuEvents();
            LoadState();
            SwitchPage("home");
        }

        public MainForm(UserAccount loggedInUser)
        {
            _db = AppDatabase.Load();
            _currentUser = loggedInUser;
            InitializeComponent();
            cbPriceFilter.SelectedIndex = 0;
            cbSortFilter.SelectedIndex = 0;

            // Set User info context on UI
            lblUserInfo.Text = $"Xin chào, {_currentUser.FullName}";
            lblUserRole.Text = "Vai trò: Khách hàng";

            ApplySystemSettings();

            // Wire Menu click events
            WireMenuEvents();

            // Load initial state & navigate home
            LoadState();
            SwitchPage("home");
        }

        private void WireMenuEvents()
        {
            btnMenuHome.Click += (s, e) => { SwitchPage("home"); RefreshHomeFeatured(); };
            btnMenuApple.Click += (s, e) => { SwitchPage("shop"); _activeCategory = "phone_apple"; lblCategoryTitle.Text = "Điện thoại Apple"; RefreshStorefront(); };
            btnMenuSamsung.Click += (s, e) => { SwitchPage("shop"); _activeCategory = "phone_samsung"; lblCategoryTitle.Text = "Điện thoại Samsung"; RefreshStorefront(); };
            btnMenuXiaomi.Click += (s, e) => { SwitchPage("shop"); _activeCategory = "phone_xiaomi"; lblCategoryTitle.Text = "Điện thoại Xiaomi"; RefreshStorefront(); };
            btnMenuWatches.Click += (s, e) => { SwitchPage("shop"); _activeCategory = "watch"; lblCategoryTitle.Text = "Đồng hồ thông minh"; RefreshStorefront(); };
            btnMenuAccessories.Click += (s, e) => { SwitchPage("shop"); _activeCategory = "accessory"; lblCategoryTitle.Text = "Tai nghe & Phụ kiện"; RefreshStorefront(); };
            btnMenuCart.Click += (s, e) => { SwitchPage("cart"); RefreshCartPage(); };
            btnMenuProfile.Click += (s, e) => { SwitchPage("profile"); RefreshProfilePage(); };
            btnMenuNews.Click += (s, e) => { SwitchPage("news"); RefreshNewsPage(); };
            btnMenuAbout.Click += (s, e) => { SwitchPage("about"); RefreshAboutPage(); };

            cbPriceFilter.SelectedIndexChanged += (s, e) => RefreshStorefront();
            cbSortFilter.SelectedIndexChanged += (s, e) => RefreshStorefront();
            btnApplyVoucher.Click += BtnApplyVoucher_Click;

            btnMenuLogout.Click += (s, e) =>
            {
                var res = MessageBox.Show("Bạn có muốn đăng xuất khỏi tài khoản không?", "Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                }
            };
        }

        private void SwitchPage(string pageName)
        {
            _activePage = pageName;

            // Hide all views
            panelHome.Visible = false;
            panelShop.Visible = false;
            panelCartView.Visible = false;
            panelProfile.Visible = false;
            panelNews.Visible = false;
            panelAbout.Visible = false;

            // Reset menu buttons highlight colors
            List<Button> buttons = new List<Button> {
                btnMenuHome, btnMenuApple, btnMenuSamsung, btnMenuXiaomi,
                btnMenuWatches, btnMenuAccessories, btnMenuCart, btnMenuProfile, btnMenuNews, btnMenuAbout
            };
            foreach (var btn in buttons)
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            }

            // Show active page and highlight active button
            if (pageName == "home")
            {
                panelHome.Visible = true;
                btnMenuHome.BackColor = Color.White;
                btnMenuHome.ForeColor = Color.RoyalBlue;
                btnMenuHome.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshHomeFeatured();
            }
            else if (pageName == "shop")
            {
                panelShop.Visible = true;
                Button? activeBtn = null;
                if (_activeCategory == "phone_apple") activeBtn = btnMenuApple;
                else if (_activeCategory == "phone_samsung") activeBtn = btnMenuSamsung;
                else if (_activeCategory == "phone_xiaomi") activeBtn = btnMenuXiaomi;
                else if (_activeCategory == "watch") activeBtn = btnMenuWatches;
                else if (_activeCategory == "accessory") activeBtn = btnMenuAccessories;

                if (activeBtn != null)
                {
                    activeBtn.BackColor = Color.White;
                    activeBtn.ForeColor = Color.RoyalBlue;
                    activeBtn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
            }
            else if (pageName == "cart")
            {
                panelCartView.Visible = true;
                btnMenuCart.BackColor = Color.White;
                btnMenuCart.ForeColor = Color.RoyalBlue;
                btnMenuCart.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshCartPage();
            }
            else if (pageName == "profile")
            {
                panelProfile.Visible = true;
                btnMenuProfile.BackColor = Color.White;
                btnMenuProfile.ForeColor = Color.RoyalBlue;
                btnMenuProfile.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshProfilePage();
            }
            else if (pageName == "news")
            {
                panelNews.Visible = true;
                btnMenuNews.BackColor = Color.White;
                btnMenuNews.ForeColor = Color.RoyalBlue;
                btnMenuNews.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshNewsPage();
            }
            else if (pageName == "about")
            {
                panelAbout.Visible = true;
                btnMenuAbout.BackColor = Color.White;
                btnMenuAbout.ForeColor = Color.RoyalBlue;
                btnMenuAbout.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                ApplySystemSettings();
                RefreshAboutPage();
            }
        }

        // ==========================================================================
        // PAGE REFRESH METHODS
        // ==========================================================================

        private void RefreshHomeFeatured()
        {
            flpHomeFeatured.Controls.Clear();
            var featuredList = _db.Products.Take(3).ToList();

            foreach (var product in featuredList)
            {
                Panel card = CreateProductCard(product);
                flpHomeFeatured.Controls.Add(card);
            }
        }

        private void RefreshStorefront()
        {
            flpProducts.Controls.Clear();
            string query = txtCustomerSearch.Text.ToLower();

            var filtered = _db.Products.Where(p =>
            {
                bool matchCat = p.Category == _activeCategory;
                bool matchSearch = p.Name.ToLower().Contains(query) || p.Description.ToLower().Contains(query);
                return matchCat && matchSearch;
            }).ToList();

            // Apply price range filtering
            if (cbPriceFilter.SelectedIndex == 1) // Dưới 10 triệu
            {
                filtered = filtered.Where(p => p.Price < 10000000).ToList();
            }
            else if (cbPriceFilter.SelectedIndex == 2) // Từ 10 - 20 triệu
            {
                filtered = filtered.Where(p => p.Price >= 10000000 && p.Price <= 20000000).ToList();
            }
            else if (cbPriceFilter.SelectedIndex == 3) // Trên 20 triệu
            {
                filtered = filtered.Where(p => p.Price > 20000000).ToList();
            }

            // Apply price sorting
            if (cbSortFilter.SelectedIndex == 1) // Giá tăng dần
            {
                filtered = filtered.OrderBy(p => p.Price).ToList();
            }
            else if (cbSortFilter.SelectedIndex == 2) // Giá giảm dần
            {
                filtered = filtered.OrderByDescending(p => p.Price).ToList();
            }

            foreach (var product in filtered)
            {
                Panel card = CreateProductCard(product);
                flpProducts.Controls.Add(card);
            }
        }

        private Panel CreateProductCard(Product product)
        {
            Panel card = new Panel
            {
                Size = new Size(270, 310),
                BackColor = ColorBgSurface,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 25, 25),
                Padding = new Padding(12)
            };
            card.Click += (s, e) => OpenDetailDialog(product);

            PictureBox pb = new PictureBox
            {
                Size = new Size(246, 130),
                Location = new Point(12, 12),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = ColorBgMain
            };
            pb.Click += (s, e) => OpenDetailDialog(product);
            card.Controls.Add(pb);
            _ = FetchCardImageAsync(pb, product.ImageUrl, product.Name);

            Label lblName = new Label
            {
                Text = product.Name,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = ColorTextPrimary,
                Location = new Point(12, 152),
                Size = new Size(246, 40),
                AutoEllipsis = true
            };
            lblName.Click += (s, e) => OpenDetailDialog(product);
            card.Controls.Add(lblName);

            Label lblPrice = new Label
            {
                Text = string.Format("{0:N0} ₫", product.Price),
                Font = new Font("Segoe UI", 11.5F, FontStyle.Bold),
                ForeColor = Color.Red,
                Location = new Point(12, 195),
                Size = new Size(130, 25)
            };
            lblPrice.Click += (s, e) => OpenDetailDialog(product);
            card.Controls.Add(lblPrice);

            Label lblStockStatus = new Label
            {
                Location = new Point(12, 225),
                Size = new Size(246, 20),
                Font = new Font("Segoe UI", 8.5F, FontStyle.Italic)
            };
            if (product.Stock == 0)
            {
                lblStockStatus.Text = "Hết hàng";
                lblStockStatus.ForeColor = Color.FromArgb(239, 68, 68);
            }
            else if (product.Stock < 5)
            {
                lblStockStatus.Text = $"Chỉ còn {product.Stock} cái";
                lblStockStatus.ForeColor = Color.FromArgb(245, 158, 11);
            }
            else
            {
                lblStockStatus.Text = $"Còn hàng ({product.Stock})";
                lblStockStatus.ForeColor = Color.FromArgb(16, 185, 129);
            }
            lblStockStatus.Click += (s, e) => OpenDetailDialog(product);
            card.Controls.Add(lblStockStatus);

            Button btnBuy = new Button
            {
                Text = product.Stock == 0 ? "Tạm Hết Hàng" : "Thêm vào giỏ",
                Location = new Point(12, 255),
                Size = new Size(246, 35),
                BackColor = product.Stock == 0 ? Color.FromArgb(71, 85, 105) : ColorPrimary,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Enabled = product.Stock > 0
            };
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.Click += (s, e) => { AddToCart(product); };
            card.Controls.Add(btnBuy);

            return card;
        }

        private void RefreshCartPage()
        {
            flpCartLines.Controls.Clear();
            decimal total = 0;

            foreach (var item in _cart)
            {
                decimal rowTotal = item.Price * item.Quantity;
                total += rowTotal;

                Panel row = new Panel
                {
                    Size = new Size(520, 75),
                    Margin = new Padding(0, 0, 0, 10),
                    BackColor = ColorBgMain
                };

                PictureBox pb = new PictureBox
                {
                    Size = new Size(60, 60),
                    Location = new Point(10, 8),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = ColorBgSurface
                };
                _ = FetchCardImageAsync(pb, item.ImageUrl, item.Name);
                row.Controls.Add(pb);

                Label lblName = new Label
                {
                    Text = item.Name,
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    Location = new Point(80, 10),
                    Size = new Size(230, 20),
                    AutoEllipsis = true
                };
                row.Controls.Add(lblName);

                Label lblPrice = new Label
                {
                    Text = string.Format("{0:N0} ₫", item.Price),
                    Font = new Font("Segoe UI", 8.5F),
                    ForeColor = ColorAccent,
                    Location = new Point(80, 32),
                    Size = new Size(180, 18)
                };
                row.Controls.Add(lblPrice);

                // Qty controls
                Button btnMinus = new Button { Text = "-", Size = new Size(24, 24), Location = new Point(320, 25), FlatStyle = FlatStyle.Flat, BackColor = ColorBgSurface };
                btnMinus.FlatAppearance.BorderSize = 0;
                btnMinus.Click += (s, e) => UpdateCartQty(item.ProductId, -1);

                Label lblQty = new Label { Text = item.Quantity.ToString(), Location = new Point(345, 27), Size = new Size(30, 20), TextAlign = ContentAlignment.MiddleCenter, Font = new Font("Segoe UI", 9.5F, FontStyle.Bold) };

                Button btnPlus = new Button { Text = "+", Size = new Size(24, 24), Location = new Point(375, 25), FlatStyle = FlatStyle.Flat, BackColor = ColorBgSurface };
                btnPlus.FlatAppearance.BorderSize = 0;
                btnPlus.Click += (s, e) => UpdateCartQty(item.ProductId, 1);

                row.Controls.Add(btnMinus);
                row.Controls.Add(lblQty);
                row.Controls.Add(btnPlus);

                Label lblRowTotal = new Label
                {
                    Text = string.Format("{0:N0} ₫", rowTotal),
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = ColorPrimary,
                    Location = new Point(410, 27),
                    Size = new Size(80, 20),
                    TextAlign = ContentAlignment.MiddleRight
                };
                row.Controls.Add(lblRowTotal);

                Button btnRemove = new Button
                {
                    Text = "✕",
                    Size = new Size(24, 24),
                    Location = new Point(495, 25),
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.FromArgb(239, 68, 68)
                };
                btnRemove.FlatAppearance.BorderSize = 0;
                btnRemove.Click += (s, e) => RemoveFromCart(item.ProductId);
                row.Controls.Add(btnRemove);

                flpCartLines.Controls.Add(row);
            }

            lblCartTotalAmount.Text = string.Format("Tổng cộng: {0:N0} ₫", total);

            // Populate Voucher ComboBox if empty or reload
            cbVoucher.Items.Clear();
            cbVoucher.Items.Add("Không sử dụng mã");
            foreach (var v in _db.Vouchers)
            {
                cbVoucher.Items.Add($"{v.Code} - {v.Description}");
            }
            cbVoucher.SelectedIndex = 0;

            lblVoucherDiscount.Visible = false;
            lblVoucherFinalTotal.Visible = false;
            _appliedVoucher = null;
            _discountAmount = 0;

            if (string.IsNullOrEmpty(txtCheckoutName.Text)) txtCheckoutName.Text = _currentUser.FullName;
            if (string.IsNullOrEmpty(txtCheckoutPhone.Text)) txtCheckoutPhone.Text = _currentUser.Phone;
            if (string.IsNullOrEmpty(txtCheckoutAddress.Text)) txtCheckoutAddress.Text = _currentUser.Address;

            btnPlaceOrderSubmit.Enabled = _cart.Count > 0;
            btnPlaceOrderSubmit.BackColor = _cart.Count > 0 ? ColorPrimary : Color.FromArgb(71, 85, 105);
        }

        private void BtnPlaceOrderSubmit_Click(object? sender, EventArgs e)
        {
            if (_cart.Count == 0) return;

            if (_db.Settings.IsMaintenanceMode)
            {
                MessageBox.Show("Cửa hàng hiện đang chuyển sang chế độ bảo trì hệ thống! Bạn không thể thực hiện đặt hàng vào lúc này.", "Bảo Trì Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtCheckoutName.Text.Trim();
            string phone = txtCheckoutPhone.Text.Trim();
            string address = txtCheckoutAddress.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Vui lòng điền thông tin người nhận hàng đầy đủ!", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Subtract stock levels
            foreach (var item in _cart)
            {
                var prod = _db.Products.FirstOrDefault(p => p.Id == item.ProductId);
                if (prod != null)
                {
                    prod.Stock -= item.Quantity;
                }
            }

            // Log Order receipt
            decimal originalTotal = _cart.Sum(c => c.Price * c.Quantity);
            decimal total = originalTotal - _discountAmount;
            
            string itemsSummary = string.Join(", ", _cart.Select(c => $"{c.Name} x{c.Quantity}"));
            if (_appliedVoucher != null)
            {
                itemsSummary = $"[Mã {_appliedVoucher.Code}] " + itemsSummary;
            }

            var newOrder = new UserOrder
            {
                OrderId = "DH" + DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString().Substring(4),
                Date = DateTime.Now.ToString("dd/MM/yyyy"),
                TotalAmount = total,
                ItemsSummary = itemsSummary,
                Status = "Chờ xử lý" // Updated initial state
            };

            var userRecord = _db.Users.FirstOrDefault(u => u.Username.Equals(_currentUser.Username, StringComparison.OrdinalIgnoreCase));
            if (userRecord != null)
            {
                userRecord.OrderHistory.Insert(0, newOrder);
                _currentUser = userRecord; // sync
            }

            // Add to database revenue statistics
            _db.Sales.Revenue += total;
            _db.Sales.Orders += 1;
            if (_db.Sales.History.Count > 0)
            {
                _db.Sales.History[_db.Sales.History.Count - 1].Amount += total;
            }

            _db.Save();

            _appliedVoucher = null;
            _discountAmount = 0;

            _cart.Clear();
            SaveCart();
            RefreshCartCount();
            RefreshCartPage();

            MessageBox.Show($"Đặt hàng thành công!\nĐơn hàng #{newOrder.OrderId} ({total:N0} ₫) đang chờ Admin xét duyệt.", "Đặt Hàng Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshProfilePage()
        {
            lblProfUsername.Text = $"Tên tài khoản: {_currentUser.Username}";
            txtProfFullName.Text = _currentUser.FullName;
            txtProfPhone.Text = _currentUser.Phone;
            txtProfAddress.Text = _currentUser.Address;

            // Load order history list box
            lstOrderHistory.Items.Clear();
            if (_currentUser.OrderHistory == null || _currentUser.OrderHistory.Count == 0)
            {
                lstOrderHistory.Items.Add("Chưa có đơn hàng nào.");
                return;
            }

            foreach (var order in _currentUser.OrderHistory)
            {
                lstOrderHistory.Items.Add($"Đơn hàng: #{order.OrderId} ({order.Date})");
                lstOrderHistory.Items.Add($"  Tổng tiền: {order.TotalAmount:N0} ₫ - Trạng thái: {order.Status}");
                lstOrderHistory.Items.Add($"  Chi tiết: {order.ItemsSummary}");
                lstOrderHistory.Items.Add(new string('-', 70));
            }
        }

        private void BtnSaveProfile_Click(object? sender, EventArgs e)
        {
            string name = txtProfFullName.Text.Trim();
            string phone = txtProfPhone.Text.Trim();
            string address = txtProfAddress.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin!", "Cập Nhật Hồ Sơ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userRecord = _db.Users.FirstOrDefault(u => u.Username.Equals(_currentUser.Username, StringComparison.OrdinalIgnoreCase));
            if (userRecord != null)
            {
                userRecord.FullName = name;
                userRecord.Phone = phone;
                userRecord.Address = address;
                _db.Save();

                _currentUser = userRecord;
                lblUserInfo.Text = $"Xin chào, {_currentUser.FullName}";

                MessageBox.Show("Cập nhật hồ sơ thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ==========================================================================
        // 5. NEWS PAGE
        // ==========================================================================
        private void RefreshNewsPage()
        {
            flpNews.Controls.Clear();

            var articles = new List<Tuple<string, string, string>>
            {
                Tuple.Create(
                    "Đánh giá chi tiết iPhone 15 Pro Max sau 6 tháng sử dụng",
                    "Liệu bộ khung viền Titan cao cấp cùng camera zoom quang học 5x có thực sự xứng đáng với số tiền đầu tư gần 30 triệu đồng? Hãy cùng chúng tôi đánh giá lại những ưu nhược điểm thực tế.",
                    "Hôm nay chúng ta cùng nhìn lại chiếc điện thoại hàng đầu của Apple. Sau nửa năm sử dụng, máy vẫn giữ được độ bóng bảy của khung Titan. Trọng lượng nhẹ hơn giúp cầm lâu không bị mỏi tay. Camera zoom 5x cho chất lượng chi tiết cực tốt ở điều kiện ban ngày. Tuy nhiên, thời lượng pin chỉ ở mức trung bình khá và máy vẫn tỏa nhiệt ấm lên khi sạc nhanh 27W."
                ),
                Tuple.Create(
                    "Samsung cập nhật loạt tính năng Galaxy AI tiếng Việt siêu xịn",
                    "Bản cập nhật One UI mới nhất mang đến tính năng Live Translate (phiên dịch cuộc gọi thời gian thực) và trợ lý chat thông minh hỗ trợ trọn vẹn ngôn ngữ Tiếng Việt cho các dòng S23 và Z Fold5.",
                    "Người dùng tại Việt Nam giờ đây có thể thoải mái gọi điện cho người nước ngoài mà không lo rào cản ngôn ngữ. Tính năng AI sẽ dịch trực tiếp giọng nói hai chiều theo thời gian thực. Bên cạnh đó, trợ lý ghi chú thông minh (Note Assist) cũng tự động tóm tắt nội dung các đoạn văn bản dài bằng tiếng Việt cực kỳ chuyên nghiệp."
                ),
                Tuple.Create(
                    "Rò rỉ thiết kế tai nghe Sony WH-1000XM6 cực sang xịn mịn",
                    "Nhiều nguồn tin rò rỉ uy tín cho thấy mẫu tai nghe over-ear chống ồn chủ động đầu bảng tiếp theo của Sony sẽ có thay đổi lớn về ngoại hình gấp gọn và chip chống ồn ANC thế hệ mới.",
                    "Sản phẩm dự kiến sẽ ra mắt vào cuối năm nay với giá bán khoảng 8.5 triệu đồng. Ngoài thiết kế headband mềm mại hơn và đệm tai thoáng khí, Sony được cho là sẽ nâng cấp thời lượng pin từ 30 giờ lên tới 42 giờ khi bật ANC. Cảm biến chạm thông minh ở earcup cũng sẽ nhạy hơn khi trời mưa ẩm."
                )
            };

            foreach (var art in articles)
            {
                Panel card = new Panel
                {
                    Size = new Size(310, 220),
                    BackColor = ColorBgSurface,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(0, 0, 20, 20),
                    Padding = new Padding(12)
                };

                Label lblTitle = new Label
                {
                    Text = art.Item1,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = ColorPrimary,
                    Location = new Point(12, 12),
                    Size = new Size(286, 45),
                    AutoEllipsis = true
                };
                card.Controls.Add(lblTitle);

                Label lblSummary = new Label
                {
                    Text = art.Item2,
                    Font = new Font("Segoe UI", 8.5F),
                    ForeColor = ColorTextSecondary,
                    Location = new Point(12, 65),
                    Size = new Size(286, 95),
                    AutoEllipsis = true
                };
                card.Controls.Add(lblSummary);

                Button btnReadMore = new Button
                {
                    Text = "Đọc Chi Tiết →",
                    Location = new Point(12, 170),
                    Size = new Size(286, 32),
                    BackColor = ColorBgMain,
                    ForeColor = ColorPrimary,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 8.5F, FontStyle.Bold)
                };
                btnReadMore.FlatAppearance.BorderSize = 0;
                btnReadMore.Click += (s, e) => MessageBox.Show(art.Item3, art.Item1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                card.Controls.Add(btnReadMore);

                flpNews.Controls.Add(card);
            }
        }

        // ==========================================================================
        // 6. ABOUT PAGE
        // ==========================================================================
        private void RefreshAboutPage()
        {
            txtAboutName.Clear();
            txtAboutEmail.Clear();
            txtAboutMsg.Clear();
        }

        private void BtnSendAboutMsg_Click(object? sender, EventArgs e)
        {
            string name = txtAboutName.Text.Trim();
            string email = txtAboutEmail.Text.Trim();
            string msg = txtAboutMsg.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(msg))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên, email và tin nhắn phản hồi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save to database
            var newFeedback = new Feedback
            {
                Id = "FB" + (DateTimeOffset.UtcNow.ToUnixTimeSeconds() % 10000).ToString(),
                CustomerName = name,
                Email = email,
                Message = msg,
                Date = DateTime.Now.ToString("dd/MM/yyyy"),
                Status = "Chờ xử lý"
            };
            _db.Feedbacks.Add(newFeedback);
            _db.Save();

            MessageBox.Show($"Cảm ơn bạn {name}!\nÝ kiến phản hồi đã được lưu lại và gửi tới Quản trị viên hệ thống.", "Gửi Liên Hệ Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshAboutPage();
        }

        private void ApplySystemSettings()
        {
            this.Text = $"{_db.Settings.StoreName} - Cửa Hàng Công Nghệ";
            lblLogo.Text = $"🛒 {_db.Settings.StoreName}";
            lblAboutText.Text = $"Chào mừng bạn đến với {_db.Settings.StoreName}!\n\n" +
                               $"Chúng tôi chuyên cung cấp các thiết bị công nghệ chính hãng bao gồm điện thoại di động, đồng hồ thông minh, máy tính xách tay và phụ kiện với giá tốt nhất thị trường.\n\n" +
                               $"📍 Địa chỉ: {_db.Settings.Address}\n" +
                               $"📞 Hotline: {_db.Settings.Hotline}\n" +
                               $"✉️ Email: {_db.Settings.Email}\n\n" +
                               $"Sự hài lòng của quý khách là niềm vinh hạnh của chúng tôi!";
        }

        // ==========================================================================
        // CART / IMAGE FETCH HELPERS
        // ==========================================================================
        private void AddToCart(Product product)
        {
            if (product.Stock <= 0)
            {
                MessageBox.Show("Sản phẩm đã tạm hết hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = _cart.FirstOrDefault(c => c.ProductId == product.Id);
            if (item != null)
            {
                if (item.Quantity >= product.Stock)
                {
                    MessageBox.Show($"Kho hàng chỉ còn tối đa {product.Stock} cái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                item.Quantity += 1;
            }
            else
            {
                _cart.Add(new CartItem
                {
                    ProductId = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = 1,
                    ImageUrl = product.ImageUrl
                });
            }

            SaveCart();
            RefreshCartCount();
            MessageBox.Show($"Đã thêm {product.Name} vào giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateCartQty(string productId, int delta)
        {
            var item = _cart.FirstOrDefault(c => c.ProductId == productId);
            var prod = _db.Products.FirstOrDefault(p => p.Id == productId);

            if (item == null || prod == null) return;

            int newQty = item.Quantity + delta;
            if (newQty <= 0)
            {
                _cart.Remove(item);
            }
            else
            {
                if (newQty > prod.Stock)
                {
                    MessageBox.Show($"Kho chỉ còn lại {prod.Stock} chiếc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                item.Quantity = newQty;
            }

            _appliedVoucher = null;
            _discountAmount = 0;
            SaveCart();
            RefreshCartCount();
            RefreshCartPage();
        }

        private void RemoveFromCart(string productId)
        {
            var item = _cart.FirstOrDefault(c => c.ProductId == productId);
            if (item != null)
            {
                _cart.Remove(item);
                _appliedVoucher = null;
                _discountAmount = 0;
                SaveCart();
                RefreshCartCount();
                RefreshCartPage();
            }
        }

        private void RefreshCartCount()
        {
            int total = _cart.Sum(item => item.Quantity);
            btnMenuCart.Text = $"🛒 Giỏ Hàng ({total})";
        }

        private void OpenDetailDialog(Product product)
        {
            using (var detailForm = new DetailForm(product))
            {
                if (detailForm.ShowDialog(this) == DialogResult.OK)
                {
                    AddToCart(product);
                }
            }
        }

        private async Task FetchCardImageAsync(PictureBox pb, string url, string productName)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] data = await client.GetByteArrayAsync(url);
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        pb.Image = Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                // Fallback: generate beautiful gradient image locally
                Bitmap bmp = new Bitmap(236, 130);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    // Generate a hash color based on product name for visual variety
                    int hash = Math.Abs(productName.GetHashCode());
                    int r = (hash % 120) + 30;
                    int gVal = ((hash / 100) % 120) + 30;
                    int b = ((hash / 10000) % 120) + 30;
                    Color startColor = Color.FromArgb(r, gVal, b);
                    Color endColor = Color.FromArgb(Math.Min(r + 60, 255), Math.Min(gVal + 60, 255), Math.Min(b + 60, 255));

                    using (var brush = new LinearGradientBrush(new Rectangle(0, 0, 236, 130), startColor, endColor, 45F))
                    {
                        g.FillRectangle(brush, 0, 0, 236, 130);
                    }

                    // Draw overlay text representing the product brand/type
                    string brand = "TECH";
                    if (productName.ToLower().Contains("iphone")) brand = "APPLE";
                    else if (productName.ToLower().Contains("samsung") || productName.ToLower().Contains("galaxy")) brand = "SAMSUNG";
                    else if (productName.ToLower().Contains("xiaomi") || productName.ToLower().Contains("redmi")) brand = "XIAOMI";
                    else if (productName.ToLower().Contains("sony")) brand = "SONY";
                    else if (productName.ToLower().Contains("macbook") || productName.ToLower().Contains("dell") || productName.ToLower().Contains("rog")) brand = "LAPTOP";

                    using (Font brandFont = new Font("Segoe UI Black", 16, FontStyle.Bold))
                    using (Font nameFont = new Font("Segoe UI Semibold", 8.5F))
                    {
                        // Draw Brand
                        g.DrawString(brand, brandFont, Brushes.White, new PointF(15, 30));
                        // Draw a subtle line
                        g.DrawLine(new Pen(Color.FromArgb(150, 255, 255, 255), 2), 15, 65, 80, 65);
                        // Draw short name snippet
                        string displayName = productName.Length > 25 ? productName.Substring(0, 22) + "..." : productName;
                        g.DrawString(displayName, nameFont, Brushes.LightGray, new PointF(15, 75));
                    }
                }
                pb.Image = bmp;
            }
        }

        private void LoadState()
        {
            // Pure UI mockup: state preserved static _cart in-memory
            RefreshCartCount();
            RefreshHomeFeatured();
        }

        private void SaveCart()
        {
            // Pure UI mockup: save in-memory static _cart only
        }

        private void PanelHomeHero_Paint(object sender, PaintEventArgs e)
        {
            if (panelHomeHero == null) return;
            using (var brush = new LinearGradientBrush(panelHomeHero.ClientRectangle, Color.FromArgb(99, 102, 241), Color.FromArgb(6, 182, 212), 45F))
            {
                e.Graphics.FillRectangle(brush, panelHomeHero.ClientRectangle);
            }
        }

        private void TxtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshStorefront();
        }

        private void BtnApplyVoucher_Click(object? sender, EventArgs e)
        {
            decimal total = _cart.Sum(c => c.Price * c.Quantity);
            if (total == 0)
            {
                MessageBox.Show("Giỏ hàng của bạn đang trống!", "Mã Giảm Giá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbVoucher.SelectedIndex <= 0)
            {
                _appliedVoucher = null;
                _discountAmount = 0;
                lblVoucherDiscount.Visible = false;
                lblVoucherFinalTotal.Visible = false;
                return;
            }

            string selectedText = cbVoucher.SelectedItem?.ToString() ?? string.Empty;
            string code = selectedText.Split('-')[0].Trim();
            var voucher = _db.Vouchers.FirstOrDefault(v => v.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
            if (voucher != null)
            {
                _appliedVoucher = voucher;
                _discountAmount = total * (voucher.DiscountPercent / 100M);
                if (_discountAmount > voucher.MaxDiscount)
                {
                    _discountAmount = voucher.MaxDiscount;
                }

                decimal finalTotal = total - _discountAmount;
                lblVoucherDiscount.Text = string.Format("Đã giảm: -{0:N0} ₫", _discountAmount);
                lblVoucherFinalTotal.Text = string.Format("Tổng thanh toán: {0:N0} ₫", finalTotal);

                lblVoucherDiscount.Visible = true;
                lblVoucherFinalTotal.Visible = true;

                MessageBox.Show($"Áp dụng mã {code} thành công!\nBạn được giảm {voucher.DiscountPercent}% (Giảm {_discountAmount:N0} ₫).", "Mã Giảm Giá", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
