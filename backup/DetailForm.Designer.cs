using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    partial class DetailForm
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescTitle = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblSpecsTitle = new System.Windows.Forms.Label();
            this.lstSpecs = new System.Windows.Forms.ListBox();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(11, 15, 25);
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.pbImage);
            this.leftPanel.Location = new System.Drawing.Point(20, 20);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(300, 300);
            this.leftPanel.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(298, 298);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(34, 211, 238);
            this.lblPrice.Location = new System.Drawing.Point(20, 335);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(300, 30);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Giá: 0 ₫";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblStock.Location = new System.Drawing.Point(20, 370);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(300, 25);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Trạng thái: Còn hàng";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightPanel.Controls.Add(this.lblCategory);
            this.rightPanel.Controls.Add(this.lblName);
            this.rightPanel.Controls.Add(this.lblDescTitle);
            this.rightPanel.Controls.Add(this.txtDesc);
            this.rightPanel.Controls.Add(this.lblSpecsTitle);
            this.rightPanel.Controls.Add(this.lstSpecs);
            this.rightPanel.Location = new System.Drawing.Point(340, 20);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(370, 370);
            this.rightPanel.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblCategory.Location = new System.Drawing.Point(0, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(370, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "DANH MỤC";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(0, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(370, 45);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên Sản Phẩm";
            // 
            // lblDescTitle
            // 
            this.lblDescTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDescTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblDescTitle.Location = new System.Drawing.Point(0, 75);
            this.lblDescTitle.Name = "lblDescTitle";
            this.lblDescTitle.Size = new System.Drawing.Size(370, 18);
            this.lblDescTitle.TabIndex = 2;
            this.lblDescTitle.Text = "MÔ TẢ SẢN PHẨM";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(21, 28, 44);
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.txtDesc.Location = new System.Drawing.Point(0, 95);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(370, 85);
            this.txtDesc.TabIndex = 3;
            // 
            // lblSpecsTitle
            // 
            this.lblSpecsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSpecsTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSpecsTitle.Location = new System.Drawing.Point(0, 190);
            this.lblSpecsTitle.Name = "lblSpecsTitle";
            this.lblSpecsTitle.Size = new System.Drawing.Size(370, 18);
            this.lblSpecsTitle.TabIndex = 4;
            this.lblSpecsTitle.Text = "THÔNG SỐ KỸ THUẬT";
            // 
            // lstSpecs
            // 
            this.lstSpecs.BackColor = System.Drawing.Color.FromArgb(11, 15, 25);
            this.lstSpecs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSpecs.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.lstSpecs.Location = new System.Drawing.Point(0, 210);
            this.lstSpecs.Name = "lstSpecs";
            this.lstSpecs.Size = new System.Drawing.Size(370, 150);
            this.lstSpecs.TabIndex = 5;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(11, 15, 25);
            this.footerPanel.Controls.Add(this.btnAddToCart);
            this.footerPanel.Controls.Add(this.btnClose);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 399);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(734, 65);
            this.footerPanel.TabIndex = 4;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(390, 15);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(180, 35);
            this.btnAddToCart.TabIndex = 0;
            this.btnAddToCart.Text = "Thêm Vào Giỏ Hàng";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.btnClose.Location = new System.Drawing.Point(590, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(21, 28, 44);
            this.ClientSize = new System.Drawing.Size(734, 464);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.footerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Sản Phẩm";
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescTitle;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblSpecsTitle;
        private System.Windows.Forms.ListBox lstSpecs;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnClose;
    }
}
