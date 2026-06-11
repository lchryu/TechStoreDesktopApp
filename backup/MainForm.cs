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
        private List<CartItem> _cart = new List<CartItem>();
        private string _activeCategory = "all";
        private string _activePage = "home";

        // Style Colors
        private readonly Color ColorBgMain = Color.FromArgb(11, 15, 25);
        private readonly Color ColorBgSurface = Color.FromArgb(21, 28, 44);
        private readonly Color ColorBgSurfaceHover = Color.FromArgb(30, 41, 59);
        private readonly Color ColorPrimary = Color.FromArgb(99, 102, 241);
        private readonly Color ColorAccent = Color.FromArgb(6, 182, 212);
        private readonly Color ColorTextPrimary = Color.FromArgb(248, 250, 252);
        private readonly Color ColorTextSecondary = Color.FromArgb(148, 163, 184);

        public MainForm(UserAccount loggedInUser)
        {
            _db = AppDatabase.Load();
            _currentUser = loggedInUser;
            InitializeComponent();

            // Set User info context on UI
            lblUserInfo.Text = $"Xin chào, {_currentUser.FullName}";
            lblUserRole.Text = $"Vai trò: {(_currentUser.Role == "admin" ? "Quản trị viên" : "Khách hàng")}";
            btnMenuAdmin.Visible = (_currentUser.Role == "admin");

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
            btnMenuAdmin.Click += (s, e) => { SwitchPage("admin"); RefreshAdminPanel(); };

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
            panelAdmin.Visible = false;

            // Reset menu buttons highlight colors
            List<Button> buttons = new List<Button> {
                btnMenuHome, btnMenuApple, btnMenuSamsung, btnMenuXiaomi,
                btnMenuWatches, btnMenuAccessories, btnMenuCart, btnMenuProfile, btnMenuAdmin
            };
            foreach (var btn in buttons)
            {
                btn.BackColor = Color.Transparent;
                btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            }

            // Show active page and highlight active button
            if (pageName == "home")
            {
                panelHome.Visible = true;
                btnMenuHome.BackColor = Color.FromArgb(255, 255, 255, 6);
                btnMenuHome.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshHomeFeatured();
            }
            else if (pageName == "shop")
            {
                panelShop.Visible = true;
                if (_activeCategory == "phone_apple") btnMenuApple.BackColor = Color.FromArgb(255, 255, 255, 6);
                else if (_activeCategory == "phone_samsung") btnMenuSamsung.BackColor = Color.FromArgb(255, 255, 255, 6);
                else if (_activeCategory == "phone_xiaomi") btnMenuXiaomi.BackColor = Color.FromArgb(255, 255, 255, 6);
                else if (_activeCategory == "watch") btnMenuWatches.BackColor = Color.FromArgb(255, 255, 255, 6);
                else if (_activeCategory == "accessory") btnMenuAccessories.BackColor = Color.FromArgb(255, 255, 255, 6);
            }
            else if (pageName == "cart")
            {
                panelCartView.Visible = true;
                btnMenuCart.BackColor = Color.FromArgb(255, 255, 255, 6);
                btnMenuCart.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshCartPage();
            }
            else if (pageName == "profile")
            {
                panelProfile.Visible = true;
                btnMenuProfile.BackColor = Color.FromArgb(255, 255, 255, 6);
                btnMenuProfile.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshProfilePage();
            }
            else if (pageName == "admin")
            {
                panelAdmin.Visible = true;
                btnMenuAdmin.BackColor = Color.FromArgb(255, 255, 255, 6);
                btnMenuAdmin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                RefreshAdminPanel();
            }
        }

        // ==========================================================================
        // PAGE PANELS CREATION
        // ==========================================================================


        private void RefreshHomeFeatured()
        {
            flpHomeFeatured.Controls.Clear();

            // Show 3 distinct items for storefront home screen preview
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

            foreach (var product in filtered)
            {
                Panel card = CreateProductCard(product);
                flpProducts.Controls.Add(card);
            }
        }

        // Reusable Helper to build a styled storefront product card
        private Panel CreateProductCard(Product product)
        {
            Panel card = new Panel
            {
                Size = new Size(270, 310),
                BackColor = ColorBgSurface,
                Margin = new Padding(0, 0, 25, 25),
                Padding = new Padding(12)
            };
            card.Click += (s, e) => OpenDetailDialog(product);

            PictureBox pb = new PictureBox
            {
                Size = new Size(246, 130),
                Location = new Point(12, 12),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(11, 15, 25)
            };
            pb.Click += (s, e) => OpenDetailDialog(product);
            card.Controls.Add(pb);
            _ = FetchCardImageAsync(pb, product.ImageUrl);

            Label lblName = new Label
            {
                Text = product.Name,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White,
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
                ForeColor = ColorAccent,
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
                _ = FetchCardImageAsync(pb, item.ImageUrl);
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

                // Qty panel
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

                // Row total
                Label lblRowTotal = new Label
                {
                    Text = string.Format("{0:N0} ₫", rowTotal),
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(410, 27),
                    Size = new Size(80, 20),
                    TextAlign = ContentAlignment.MiddleRight
                };
                row.Controls.Add(lblRowTotal);

                // Delete Button
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

            // Prefill Checkout form if not customized
            if (string.IsNullOrEmpty(txtCheckoutName.Text)) txtCheckoutName.Text = _currentUser.FullName;
            if (string.IsNullOrEmpty(txtCheckoutPhone.Text)) txtCheckoutPhone.Text = _currentUser.Phone;
            if (string.IsNullOrEmpty(txtCheckoutAddress.Text)) txtCheckoutAddress.Text = _currentUser.Address;

            btnPlaceOrderSubmit.Enabled = _cart.Count > 0;
            btnPlaceOrderSubmit.BackColor = _cart.Count > 0 ? ColorPrimary : Color.FromArgb(71, 85, 105);
        }

        private void BtnPlaceOrderSubmit_Click(object? sender, EventArgs e)
        {
            if (_cart.Count == 0) return;

            string name = txtCheckoutName.Text.Trim();
            string phone = txtCheckoutPhone.Text.Trim();
            string address = txtCheckoutAddress.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Vui lòng điền thông tin người nhận hàng đầy đủ!", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Subtract stock levels
            foreach (var item in _cart)
            {
                var prod = _db.Products.FirstOrDefault(p => p.Id == item.ProductId);
                if (prod != null)
                {
                    prod.Stock -= item.Quantity;
                }
            }

            // 2. Log Order receipt
            decimal total = _cart.Sum(c => c.Price * c.Quantity);
            string itemsSummary = string.Join(", ", _cart.Select(c => $"{c.Name} x{c.Quantity}"));

            var newOrder = new UserOrder
            {
                OrderId = "DH" + DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString().Substring(4),
                Date = DateTime.Now.ToString("dd/MM/yyyy"),
                TotalAmount = total,
                ItemsSummary = itemsSummary
            };

            // Add history to current user database record
            var userRecord = _db.Users.FirstOrDefault(u => u.Username.Equals(_currentUser.Username, StringComparison.OrdinalIgnoreCase));
            if (userRecord != null)
            {
                userRecord.OrderHistory.Insert(0, newOrder);
                _currentUser = userRecord; // sync local context
            }

            // 3. Add to Admin Revenue charts
            _db.Sales.Revenue += total;
            _db.Sales.Orders += 1;
            if (_db.Sales.History.Count > 0)
            {
                _db.Sales.History[_db.Sales.History.Count - 1].Amount += total;
            }

            // Save state database
            _db.Save();

            // Clear cart
            _cart.Clear();
            SaveCart();
            RefreshCartCount();
            RefreshCartPage();

            MessageBox.Show($"Đặt hàng thành công!\nHóa đơn: {total:N0} ₫ đã được tạo và lưu vào Hồ sơ của bạn.", "Thanh Toán Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void RefreshProfilePage()
        {
            lblProfUsername.Text = $"Tên tài khoản: {_currentUser.Username}";
            txtProfFullName.Text = _currentUser.FullName;
            txtProfPhone.Text = _currentUser.Phone;
            txtProfAddress.Text = _currentUser.Address;

            // Load order history
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
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin của hồ sơ!", "Cập Nhật Hồ Sơ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var userRecord = _db.Users.FirstOrDefault(u => u.Username.Equals(_currentUser.Username, StringComparison.OrdinalIgnoreCase));
            if (userRecord != null)
            {
                userRecord.FullName = name;
                userRecord.Phone = phone;
                userRecord.Address = address;
                _db.Save();

                _currentUser = userRecord; // sync local context
                lblUserInfo.Text = $"Xin chào, {_currentUser.FullName}";

                MessageBox.Show("Cập nhật hồ sơ tài khoản thành công!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void RefreshAdminPanel()
        {
            RefreshInventoryTable();
            RefreshAdminMetrics();
            panelChart.Invalidate();
        }

        // ==========================================================================
        // MAIN OPERATIONS (CART / IMAGES / HELPERS)
        // ==========================================================================
        private void AddToCart(Product product)
        {
            if (product.Stock <= 0)
            {
                MessageBox.Show("Sản phẩm đã hết hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = _cart.FirstOrDefault(c => c.ProductId == product.Id);
            if (item != null)
            {
                if (item.Quantity >= product.Stock)
                {
                    MessageBox.Show($"Kho hàng chỉ còn {product.Stock} sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show($"Chỉ còn {prod.Stock} cái trong kho!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                item.Quantity = newQty;
            }

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

        private async Task FetchCardImageAsync(PictureBox pb, string url)
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
                Bitmap bmp = new Bitmap(236, 130);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.FromArgb(15, 23, 42));
                    using (Font font = new Font("Segoe UI", 12, FontStyle.Bold))
                    {
                        g.DrawString("Tech Image", font, Brushes.Gray, new PointF(55, 50));
                    }
                }
                pb.Image = bmp;
            }
        }

        // ==========================================================================
        // STATE STORAGE WRAPPERS
        // ==========================================================================
        private void LoadState()
        {
            string cartPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cart.json");
            if (File.Exists(cartPath))
            {
                try
                {
                    string json = File.ReadAllText(cartPath);
                    _cart = System.Text.Json.JsonSerializer.Deserialize<List<CartItem>>(json) ?? new List<CartItem>();
                }
                catch { }
            }

            RefreshCartCount();
            RefreshHomeFeatured();
        }

        private void SaveCart()
        {
            string cartPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cart.json");
            string json = System.Text.Json.JsonSerializer.Serialize(_cart);
            File.WriteAllText(cartPath, json);
        }

        private Label CreateMetricCard(TableLayoutPanel layout, string title, string val, int col, Color iconColor)
        {
            Panel card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = ColorBgSurface,
                Margin = new Padding(0, 0, 15, 0),
                Padding = new Padding(15)
            };

            card.Paint += (s, e) =>
            {
                using (SolidBrush brush = new SolidBrush(iconColor))
                {
                    e.Graphics.FillRectangle(brush, 0, 0, 4, card.Height);
                }
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = ColorTextSecondary,
                Location = new Point(15, 10),
                Size = new Size(200, 20)
            };
            card.Controls.Add(lblTitle);

            Label lblVal = new Label
            {
                Text = val,
                Font = new Font("Segoe UI", 15F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(15, 30),
                Size = new Size(200, 30),
                TextAlign = ContentAlignment.MiddleLeft
            };
            card.Controls.Add(lblVal);

            layout.Controls.Add(card, col, 0);
            return lblVal;
        }

        private void RefreshAdminMetrics()
        {
            lblStatRevenue.Text = string.Format("{0:N0} ₫", _db.Sales.Revenue);
            lblStatOrders.Text = _db.Sales.Orders.ToString();

            int lowStock = _db.Products.Count(p => p.Stock < 5);
            lblStatLowStock.Text = lowStock.ToString();
            lblStatTotalProducts.Text = _db.Products.Count.ToString();
        }

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
                        RefreshAdminMetrics();
                        MessageBox.Show("Cập nhật sản phẩm thành công!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    RefreshAdminMetrics();
                    MessageBox.Show("Xóa sản phẩm thành công!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AddNewProductAdmin()
        {
            using (var prodForm = new ProductForm())
            {
                if (prodForm.ShowDialog(this) == DialogResult.OK)
                {
                    var newProduct = prodForm.ResultProduct;
                    _db.Products.Insert(0, newProduct);
                    _db.Save();

                    RefreshInventoryTable();
                    RefreshAdminMetrics();
                    MessageBox.Show("Thêm sản phẩm mới thành công!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void PaintRevenueChart(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int width = panelChart.Width;
            int height = panelChart.Height;

            int padLeft = 70;
            int padRight = 30;
            int padTop = 20;
            int padBottom = 30;

            int graphWidth = width - padLeft - padRight;
            int graphHeight = height - padTop - padBottom;

            var history = _db.Sales.History;
            if (history == null || history.Count < 2) return;

            decimal maxAmount = history.Max(h => h.Amount);
            if (maxAmount == 0) maxAmount = 10000000;
            maxAmount *= 1.15M;

            using (Pen gridPen = new Pen(Color.FromArgb(255, 255, 255, 5), 1))
            using (Font textFont = new Font("Segoe UI", 8F))
            using (Brush textBrush = new SolidBrush(ColorTextSecondary))
            {
                int gridCount = 4;
                for (int i = 0; i <= gridCount; i++)
                {
                    float y = padTop + (graphHeight * i / (float)gridCount);
                    g.DrawLine(gridPen, padLeft, y, width - padRight, y);

                    decimal gridVal = maxAmount - (maxAmount * i / (decimal)gridCount);
                    string labelVal = string.Format("{0:N0} Tr", gridVal / 1000000M);
                    g.DrawString(labelVal, textFont, textBrush, 10, y - 6);
                }
            }

            PointF[] points = new PointF[history.Count];
            for (int i = 0; i < history.Count; i++)
            {
                float x = padLeft + (graphWidth * i / (float)(history.Count - 1));
                float ratio = (float)(history[i].Amount / maxAmount);
                float y = padTop + graphHeight * (1 - ratio);
                points[i] = new PointF(x, y);
            }

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddLine(padLeft, padTop + graphHeight, points[0].X, points[0].Y);
                for (int i = 0; i < points.Length; i++)
                {
                    path.AddLine(path.GetLastPoint(), points[i]);
                }
                path.AddLine(points[points.Length - 1].X, points[points.Length - 1].Y, width - padRight, padTop + graphHeight);
                path.CloseFigure();

                using (LinearGradientBrush fillBrush = new LinearGradientBrush(
                    new PointF(0, padTop),
                    new PointF(0, padTop + graphHeight),
                    Color.FromArgb(50, 99, 102, 241),
                    Color.FromArgb(0, 99, 102, 241)
                ))
                {
                    g.FillPath(fillBrush, path);
                }
            }

            using (Pen linePen = new Pen(ColorPrimary, 3))
            {
                linePen.StartCap = LineCap.Round;
                linePen.EndCap = LineCap.Round;
                g.DrawLines(linePen, points);
            }

            using (Brush pointBrush = new SolidBrush(ColorAccent))
            using (Font textFont = new Font("Segoe UI", 8F))
            using (Brush textBrush = new SolidBrush(ColorTextSecondary))
            {
                for (int i = 0; i < points.Length; i++)
                {
                    g.FillEllipse(Brushes.White, points[i].X - 5, points[i].Y - 5, 10, 10);
                    g.FillEllipse(pointBrush, points[i].X - 3, points[i].Y - 3, 6, 6);

                    string dateText = history[i].Date;
                    g.DrawString(dateText, textFont, textBrush, points[i].X - 12, padTop + graphHeight + 10);
                }
            }
        }

        private void PanelHomeHero_Paint(object sender, PaintEventArgs e)
        {
            if (panelHomeHero == null) return;
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(panelHomeHero.ClientRectangle, Color.FromArgb(99, 102, 241), Color.FromArgb(6, 182, 212), 45F))
            {
                e.Graphics.FillRectangle(brush, panelHomeHero.ClientRectangle);
            }
        }

        private void CardRevenue_Paint(object sender, PaintEventArgs e)
        {
            var card = sender as Panel;
            if (card == null) return;
            using (var brush = new SolidBrush(ColorPrimary))
            {
                e.Graphics.FillRectangle(brush, 0, 0, 4, card.Height);
            }
        }

        private void CardOrders_Paint(object sender, PaintEventArgs e)
        {
            var card = sender as Panel;
            if (card == null) return;
            using (var brush = new SolidBrush(ColorAccent))
            {
                e.Graphics.FillRectangle(brush, 0, 0, 4, card.Height);
            }
        }

        private void CardLowStock_Paint(object sender, PaintEventArgs e)
        {
            var card = sender as Panel;
            if (card == null) return;
            using (var brush = new SolidBrush(Color.FromArgb(245, 158, 11)))
            {
                e.Graphics.FillRectangle(brush, 0, 0, 4, card.Height);
            }
        }

        private void CardTotalProd_Paint(object sender, PaintEventArgs e)
        {
            var card = sender as Panel;
            if (card == null) return;
            using (var brush = new SolidBrush(Color.FromArgb(16, 185, 129)))
            {
                e.Graphics.FillRectangle(brush, 0, 0, 4, card.Height);
            }
        }

        private void TxtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshStorefront();
        }

        private void TxtAdminSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshInventoryTable();
        }

    }
}
