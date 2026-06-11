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

        public DetailForm(Product product)
        {
            _product = product;
            InitializeComponent();
            
            // Wire click events manually (can also be done in InitializeComponent, but cleaner here)
            btnAddToCart.Click += (s, e) => {
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
            btnClose.Click += (s, e) => {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            LoadProductDetails();
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
                // Fallback drawing if image fails to load or offline
                Bitmap bmp = new Bitmap(300, 300);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.FromArgb(15, 23, 42));
                    using (Font font = new Font("Segoe UI", 24, FontStyle.Bold))
                    {
                        g.DrawString("Tech", font, Brushes.Gray, new PointF(85, 100));
                        g.DrawString("Image", font, Brushes.Gray, new PointF(85, 140));
                    }
                }
                pbImage.Image = bmp;
            }
        }
    }
}
