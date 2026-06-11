using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    [System.ComponentModel.DesignerCategory("Form")]
    public partial class DetailForm : Form
    {
        private Product _product;

        private static readonly Dictionary<string, List<string>> _productReviews = new Dictionary<string, List<string>>();

        public DetailForm(Product product)
        {
            _product = product;
            InitializeComponent();

            // Initialize rating combo box
            cbUserStars.Items.AddRange(new object[] {
                "⭐⭐⭐⭐⭐",
                "⭐⭐⭐⭐",
                "⭐⭐⭐",
                "⭐⭐",
                "⭐"
            });
            cbUserStars.SelectedIndex = 0;
            
            // Wire click events manually
            btnAddToCart.Click += (s, e) => {
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
            btnClose.Click += (s, e) => {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
            btnSubmitReview.Click += BtnSubmitReview_Click;

            LoadProductDetails();
            LoadReviews();
        }

        private void LoadProductDetails()
        {
            this.Text = $"{_product.Name} - Chi Tiết Sản Phẩm";
            lblName.Text = _product.Name;
            lblCategory.Text = _product.Category.ToUpper();
            lblPrice.Text = string.Format("Giá: {0:N0} ₫", _product.Price);
            txtDesc.Text = _product.Description;

            // Populate list specs
            lstSpecs.Items.Clear();
            foreach (var spec in _product.Specs)
            {
                lstSpecs.Items.Add("• " + spec);
            }

            // Set stock status
            if (_product.Stock == 0)
            {
                lblStock.Text = "Trạng thái: Hết hàng";
                lblStock.ForeColor = Color.FromArgb(239, 68, 68);
                btnAddToCart.Enabled = false;
                btnAddToCart.BackColor = Color.FromArgb(71, 85, 105);
                btnAddToCart.Text = "Tạm Hết Hàng";
            }
            else if (_product.Stock < 5)
            {
                lblStock.Text = $"Trạng thái: Chỉ còn lại {_product.Stock} cái (Sắp hết)";
                lblStock.ForeColor = Color.FromArgb(245, 158, 11);
                btnAddToCart.Enabled = true;
            }
            else
            {
                lblStock.Text = $"Trạng thái: Còn hàng ({_product.Stock} cái)";
                lblStock.ForeColor = Color.FromArgb(16, 185, 129);
                btnAddToCart.Enabled = true;
            }

            // Load Image Async
            _ = LoadImageAsync(_product.ImageUrl);
        }

        private async Task LoadImageAsync(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] data = await client.GetByteArrayAsync(url);
                    using (MemoryStream ms = new MemoryStream(data))
                    {
                        pbImage.Image = Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                // Fallback: generate beautiful gradient image locally
                string productName = _product.Name;
                Bitmap bmp = new Bitmap(300, 300);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    
                    // Generate a hash color based on product name for visual variety
                    int hash = Math.Abs(productName.GetHashCode());
                    int r = (hash % 120) + 30;
                    int gVal = ((hash / 100) % 120) + 30;
                    int b = ((hash / 10000) % 120) + 30;
                    Color startColor = Color.FromArgb(r, gVal, b);
                    Color endColor = Color.FromArgb(Math.Min(r + 60, 255), Math.Min(gVal + 60, 255), Math.Min(b + 60, 255));

                    using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, 300, 300), startColor, endColor, 45F))
                    {
                        g.FillRectangle(brush, 0, 0, 300, 300);
                    }

                    // Draw overlay text representing the product brand/type
                    string brand = "TECH";
                    if (productName.ToLower().Contains("iphone")) brand = "APPLE";
                    else if (productName.ToLower().Contains("samsung") || productName.ToLower().Contains("galaxy")) brand = "SAMSUNG";
                    else if (productName.ToLower().Contains("xiaomi") || productName.ToLower().Contains("redmi")) brand = "XIAOMI";
                    else if (productName.ToLower().Contains("sony")) brand = "SONY";
                    else if (productName.ToLower().Contains("macbook") || productName.ToLower().Contains("dell") || productName.ToLower().Contains("rog")) brand = "LAPTOP";

                    using (Font brandFont = new Font("Segoe UI Black", 22, FontStyle.Bold))
                    using (Font nameFont = new Font("Segoe UI Semibold", 10F))
                    {
                        // Draw Brand
                        g.DrawString(brand, brandFont, Brushes.White, new PointF(25, 70));
                        // Draw a subtle line
                        g.DrawLine(new Pen(Color.FromArgb(150, 255, 255, 255), 3), 25, 115, 120, 115);
                        // Draw short name snippet
                        string displayName = productName.Length > 35 ? productName.Substring(0, 32) + "..." : productName;
                        g.DrawString(displayName, nameFont, Brushes.LightGray, new PointF(25, 130));
                    }
                }
                pbImage.Image = bmp;
            }
        }

        private void LoadReviews()
        {
            lstReviews.Items.Clear();
            if (!_productReviews.ContainsKey(_product.Id))
            {
                // Generate mock default reviews based on product category/name
                var defaultReviews = new List<string>();
                if (_product.Category.Contains("phone"))
                {
                    defaultReviews.Add("★★★★★ Nguyễn Văn Bình: Máy chạy cực kỳ mượt mà, chụp ảnh đẹp xuất sắc!");
                    defaultReviews.Add("★★★★☆ Trần Thị Mai: Pin trâu, màn hình nét nhưng sạc hơi ấm.");
                }
                else if (_product.Category.Contains("watch"))
                {
                    defaultReviews.Add("★★★★★ Lê Văn Hải: Đồng hồ thiết kế rất thể thao, cảm biến đo nhịp tim chuẩn.");
                    defaultReviews.Add("★★★★★ Phạm Lan Anh: Rất hài lòng, pin dùng được lâu và thông báo đẩy rất nhạy.");
                }
                else
                {
                    defaultReviews.Add("★★★★★ Vũ Đình Phong: Hàng đóng gói cẩn thận, dùng chất lượng tuyệt vời.");
                    defaultReviews.Add("★★★★☆ Đỗ Hoàng Quân: Giá thành hợp lý, dùng tốt trong tầm giá.");
                }
                _productReviews[_product.Id] = defaultReviews;
            }

            foreach (var rev in _productReviews[_product.Id])
            {
                lstReviews.Items.Add(rev);
            }
        }

        private void BtnSubmitReview_Click(object? sender, EventArgs e)
        {
            string comment = txtUserComment.Text.Trim();
            if (string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Vui lòng điền nội dung nhận xét!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string starsStr = cbUserStars.SelectedItem?.ToString() ?? "⭐⭐⭐⭐⭐";
            int starsCount = 5;
            if (starsStr == "⭐⭐⭐⭐⭐") starsCount = 5;
            else if (starsStr == "⭐⭐⭐⭐") starsCount = 4;
            else if (starsStr == "⭐⭐⭐") starsCount = 3;
            else if (starsStr == "⭐⭐") starsCount = 2;
            else if (starsStr == "⭐") starsCount = 1;

            string starRating = new string('★', starsCount) + new string('☆', 5 - starsCount);

            string fullReviewText = $"{starRating} Khách hàng (Bạn): {comment}";
            
            if (!_productReviews.ContainsKey(_product.Id))
            {
                _productReviews[_product.Id] = new List<string>();
            }
            _productReviews[_product.Id].Insert(0, fullReviewText); // Add on top

            txtUserComment.Clear();
            LoadReviews();
            MessageBox.Show("Cảm ơn bạn đã gửi đánh giá sản phẩm!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
