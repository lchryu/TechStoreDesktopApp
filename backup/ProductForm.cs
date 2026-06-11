using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TechStoreWinApp
{

    [System.ComponentModel.DesignerCategory("Form")]
    public partial class ProductForm : Form
    {
        private Product? _existingProduct;
        public Product ResultProduct { get; private set; } = new Product();

        public ProductForm(Product? existingProduct = null)
        {
            _existingProduct = existingProduct;
            InitializeComponent();

            // Populate categories dynamic mapping
            cbCategory.Items.Clear();
            cbCategory.Items.Add(new CategoryItem("Điện thoại Apple", "phone_apple"));
            cbCategory.Items.Add(new CategoryItem("Điện thoại Samsung", "phone_samsung"));
            cbCategory.Items.Add(new CategoryItem("Điện thoại Xiaomi", "phone_xiaomi"));
            cbCategory.Items.Add(new CategoryItem("Đồng hồ thông minh", "watch"));
            cbCategory.Items.Add(new CategoryItem("Tai nghe & Phụ kiện", "accessory"));
            cbCategory.Items.Add(new CategoryItem("Máy tính xách tay", "laptop"));
            cbCategory.SelectedIndex = 0;
            
            // Wire events
            btnSuggestMacBook.Click += (s, e) => txtImageUrl.Text = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?auto=format&fit=crop&w=500&q=80";
            btnSuggestIPhone.Click += (s, e) => txtImageUrl.Text = "https://images.unsplash.com/photo-1567581935884-3349727552db?auto=format&fit=crop&w=500&q=80";
            btnSuggestAudio.Click += (s, e) => txtImageUrl.Text = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?auto=format&fit=crop&w=500&q=80";
            btnSuggestWatch.Click += (s, e) => txtImageUrl.Text = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?auto=format&fit=crop&w=500&q=80";

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            LoadProductData();
        }

        private void LoadProductData()
        {
            if (_existingProduct != null)
            {
                this.Text = "Chỉnh Sửa Sản Phẩm";
                lblHeader.Text = "Chỉnh Sửa Sản Phẩm";
                txtName.Text = _existingProduct.Name;
                
                // Set selected category item matching key
                foreach (CategoryItem item in cbCategory.Items)
                {
                    if (item.Value == _existingProduct.Category)
                    {
                        cbCategory.SelectedItem = item;
                        break;
                    }
                }

                txtPrice.Text = _existingProduct.Price.ToString("F0");
                txtStock.Text = _existingProduct.Stock.ToString();
                txtImageUrl.Text = _existingProduct.ImageUrl;
                txtDesc.Text = _existingProduct.Description;
                txtSpecs.Text = string.Join(", ", _existingProduct.Specs);
            }
            else
            {
                this.Text = "Thêm Sản Phẩm Mới";
                lblHeader.Text = "Thêm Sản Phẩm Mới";
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng điền Tên Sản Phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 1000)
            {
                MessageBox.Show("Giá bán không hợp lệ (phải là số >= 1.000)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }
            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Số lượng tồn kho không hợp lệ (phải là số >= 0)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtImageUrl.Text))
            {
                MessageBox.Show("Vui lòng nhập Đường Dẫn Ảnh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtImageUrl.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                MessageBox.Show("Vui lòng nhập Mô Tả Sản Phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDesc.Focus();
                return;
            }

            // Populate ResultProduct
            ResultProduct.Id = _existingProduct?.Id ?? "p_" + DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
            ResultProduct.Name = txtName.Text.Trim();
            
            var selectedCat = cbCategory.SelectedItem as CategoryItem;
            ResultProduct.Category = selectedCat?.Value ?? "laptop";
            
            ResultProduct.Price = price;
            ResultProduct.Stock = stock;
            ResultProduct.ImageUrl = txtImageUrl.Text.Trim();
            ResultProduct.Description = txtDesc.Text.Trim();

            // Specs parsing
            ResultProduct.Specs.Clear();
            if (!string.IsNullOrWhiteSpace(txtSpecs.Text))
            {
                string[] parts = txtSpecs.Text.Split(',');
                foreach (var part in parts)
                {
                    string cleaned = part.Trim();
                    if (!string.IsNullOrEmpty(cleaned))
                    {
                        ResultProduct.Specs.Add(cleaned);
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    public class CategoryItem
    {
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;

        public CategoryItem(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString() => Name;
    }
}
