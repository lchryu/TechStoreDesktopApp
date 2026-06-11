using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.lblSuggestions = new System.Windows.Forms.Label();
            this.btnSuggestMacBook = new System.Windows.Forms.Button();
            this.btnSuggestIPhone = new System.Windows.Forms.Button();
            this.btnSuggestAudio = new System.Windows.Forms.Button();
            this.btnSuggestWatch = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblSpecs = new System.Windows.Forms.Label();
            this.txtSpecs = new System.Windows.Forms.TextBox();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHeader.Location = new System.Drawing.Point(20, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(400, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Sản Phẩm";
            // 
            // lblSub
            // 
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSub.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblSub.Location = new System.Drawing.Point(20, 48);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(590, 20);
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Vui lòng nhập đầy đủ thông tin chi tiết để bày bán sản phẩm tại cửa hàng.";
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(20, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(270, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên Sản Phẩm *";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(20, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 28);
            this.txtName.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(320, 85);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(270, 20);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Danh Mục *";
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.White;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.ForeColor = System.Drawing.Color.Black;
            this.cbCategory.Location = new System.Drawing.Point(320, 105);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(270, 28);
            this.cbCategory.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(20, 150);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(270, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Đơn Giá (₫) *";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(20, 170);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(270, 28);
            this.txtPrice.TabIndex = 7;
            // 
            // lblStock
            // 
            this.lblStock.ForeColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(320, 150);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(270, 20);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Số Lượng Kho *";
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.ForeColor = System.Drawing.Color.Black;
            this.txtStock.Location = new System.Drawing.Point(320, 170);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(270, 28);
            this.txtStock.TabIndex = 9;
            // 
            // lblImage
            // 
            this.lblImage.ForeColor = System.Drawing.Color.Black;
            this.lblImage.Location = new System.Drawing.Point(20, 215);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(580, 20);
            this.lblImage.TabIndex = 10;
            this.lblImage.Text = "Đường Dẫn Ảnh Sản Phẩm (URL) *";
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.BackColor = System.Drawing.Color.White;
            this.txtImageUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImageUrl.ForeColor = System.Drawing.Color.Black;
            this.txtImageUrl.Location = new System.Drawing.Point(20, 235);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(580, 28);
            this.txtImageUrl.TabIndex = 11;
            // 
            // lblSuggestions
            // 
            this.lblSuggestions.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblSuggestions.ForeColor = System.Drawing.Color.Gray;
            this.lblSuggestions.Location = new System.Drawing.Point(20, 275);
            this.lblSuggestions.Name = "lblSuggestions";
            this.lblSuggestions.Size = new System.Drawing.Size(110, 20);
            this.lblSuggestions.TabIndex = 12;
            this.lblSuggestions.Text = "Gợi ý ảnh nhanh:";
            // 
            // btnSuggestMacBook
            // 
            this.btnSuggestMacBook.BackColor = System.Drawing.Color.White;
            this.btnSuggestMacBook.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSuggestMacBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuggestMacBook.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSuggestMacBook.ForeColor = System.Drawing.Color.Black;
            this.btnSuggestMacBook.Location = new System.Drawing.Point(130, 270);
            this.btnSuggestMacBook.Name = "btnSuggestMacBook";
            this.btnSuggestMacBook.Size = new System.Drawing.Size(70, 23);
            this.btnSuggestMacBook.TabIndex = 13;
            this.btnSuggestMacBook.Text = "MacBook";
            this.btnSuggestMacBook.UseVisualStyleBackColor = false;
            // 
            // btnSuggestIPhone
            // 
            this.btnSuggestIPhone.BackColor = System.Drawing.Color.White;
            this.btnSuggestIPhone.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSuggestIPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuggestIPhone.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSuggestIPhone.ForeColor = System.Drawing.Color.Black;
            this.btnSuggestIPhone.Location = new System.Drawing.Point(210, 270);
            this.btnSuggestIPhone.Name = "btnSuggestIPhone";
            this.btnSuggestIPhone.Size = new System.Drawing.Size(70, 23);
            this.btnSuggestIPhone.TabIndex = 14;
            this.btnSuggestIPhone.Text = "iPhone";
            this.btnSuggestIPhone.UseVisualStyleBackColor = false;
            // 
            // btnSuggestAudio
            // 
            this.btnSuggestAudio.BackColor = System.Drawing.Color.White;
            this.btnSuggestAudio.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSuggestAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuggestAudio.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSuggestAudio.ForeColor = System.Drawing.Color.Black;
            this.btnSuggestAudio.Location = new System.Drawing.Point(285, 270);
            this.btnSuggestAudio.Name = "btnSuggestAudio";
            this.btnSuggestAudio.Size = new System.Drawing.Size(70, 23);
            this.btnSuggestAudio.TabIndex = 15;
            this.btnSuggestAudio.Text = "Tai nghe";
            this.btnSuggestAudio.UseVisualStyleBackColor = false;
            // 
            // btnSuggestWatch
            // 
            this.btnSuggestWatch.BackColor = System.Drawing.Color.White;
            this.btnSuggestWatch.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSuggestWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuggestWatch.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSuggestWatch.ForeColor = System.Drawing.Color.Black;
            this.btnSuggestWatch.Location = new System.Drawing.Point(365, 270);
            this.btnSuggestWatch.Name = "btnSuggestWatch";
            this.btnSuggestWatch.Size = new System.Drawing.Size(70, 23);
            this.btnSuggestWatch.TabIndex = 16;
            this.btnSuggestWatch.Text = "Smartwatch";
            this.btnSuggestWatch.UseVisualStyleBackColor = false;
            // 
            // lblDesc
            // 
            this.lblDesc.ForeColor = System.Drawing.Color.Black;
            this.lblDesc.Location = new System.Drawing.Point(20, 310);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(580, 20);
            this.lblDesc.TabIndex = 17;
            this.lblDesc.Text = "Mô Tả Chi Tiết *";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.Location = new System.Drawing.Point(20, 330);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(580, 75);
            this.txtDesc.TabIndex = 18;
            // 
            // lblSpecs
            // 
            this.lblSpecs.ForeColor = System.Drawing.Color.Black;
            this.lblSpecs.Location = new System.Drawing.Point(20, 420);
            this.lblSpecs.Name = "lblSpecs";
            this.lblSpecs.Size = new System.Drawing.Size(580, 20);
            this.lblSpecs.TabIndex = 19;
            this.lblSpecs.Text = "Thông Số Kỹ Thuật (Phân cách bằng dấu phẩy)";
            // 
            // txtSpecs
            // 
            this.txtSpecs.BackColor = System.Drawing.Color.White;
            this.txtSpecs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecs.ForeColor = System.Drawing.Color.Black;
            this.txtSpecs.Location = new System.Drawing.Point(20, 440);
            this.txtSpecs.Name = "txtSpecs";
            this.txtSpecs.PlaceholderText = "Ví dụ: M3 Pro Chip, 18GB RAM, 512GB SSD";
            this.txtSpecs.Size = new System.Drawing.Size(580, 28);
            this.txtSpecs.TabIndex = 20;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.footerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.footerPanel.Controls.Add(this.btnSave);
            this.footerPanel.Controls.Add(this.btnCancel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 479);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(634, 65);
            this.footerPanel.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(340, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu Thay Đổi";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(490, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy Bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(634, 544);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.txtImageUrl);
            this.Controls.Add(this.lblSuggestions);
            this.Controls.Add(this.btnSuggestMacBook);
            this.Controls.Add(this.btnSuggestIPhone);
            this.Controls.Add(this.btnSuggestAudio);
            this.Controls.Add(this.btnSuggestWatch);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblSpecs);
            this.Controls.Add(this.txtSpecs);
            this.Controls.Add(this.footerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sản Phẩm";
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.Label lblSuggestions;
        private System.Windows.Forms.Button btnSuggestMacBook;
        private System.Windows.Forms.Button btnSuggestIPhone;
        private System.Windows.Forms.Button btnSuggestAudio;
        private System.Windows.Forms.Button btnSuggestWatch;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblSpecs;
        private System.Windows.Forms.TextBox txtSpecs;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
