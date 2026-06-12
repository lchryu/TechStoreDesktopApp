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

            // Reviews instantiations
            this.reviewPanel = new System.Windows.Forms.Panel();
            this.lblReviewHeader = new System.Windows.Forms.Label();
            this.lstReviews = new System.Windows.Forms.ListBox();
            this.lblUserReviewTitle = new System.Windows.Forms.Label();
            this.txtUserComment = new System.Windows.Forms.TextBox();
            this.cbUserStars = new System.Windows.Forms.ComboBox();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.reviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.pbImage);
            this.leftPanel.Location = new System.Drawing.Point(20, 20);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(300, 300);
            this.leftPanel.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(298, 298);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.ImageLocation = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?auto=format&fit=crop&w=500&q=80";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(20, 335);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(300, 30);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Gia: 29,990,000 d";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblStock.ForeColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(20, 370);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(300, 25);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Trang thai: Con hang (12)";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Controls.Add(this.lblCategory);
            this.rightPanel.Controls.Add(this.lblName);
            this.rightPanel.Controls.Add(this.lblDescTitle);
            this.rightPanel.Controls.Add(this.txtDesc);
            this.rightPanel.Controls.Add(this.lblSpecsTitle);
            this.rightPanel.Controls.Add(this.lstSpecs);
            this.rightPanel.Location = new System.Drawing.Point(340, 20);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(10);
            this.rightPanel.Size = new System.Drawing.Size(370, 370);
            this.rightPanel.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.lblCategory.Location = new System.Drawing.Point(10, 10);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(350, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "DIEN THOAI APPLE";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(10, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(350, 40);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "iPhone 15 Pro Max 256GB";
            // 
            // lblDescTitle
            // 
            this.lblDescTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDescTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblDescTitle.Location = new System.Drawing.Point(10, 75);
            this.lblDescTitle.Name = "lblDescTitle";
            this.lblDescTitle.Size = new System.Drawing.Size(350, 18);
            this.lblDescTitle.TabIndex = 2;
            this.lblDescTitle.Text = "MÔ TẢ SẢN PHẨM:";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.Location = new System.Drawing.Point(10, 95);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(350, 85);
            this.txtDesc.TabIndex = 3;
            this.txtDesc.Text = "Mau iPhone cao cap voi thiet ke titan, camera manh me, man hinh sac net va hieu nang phu hop cho cong viec lan giai tri.";
            // 
            // lblSpecsTitle
            // 
            this.lblSpecsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSpecsTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblSpecsTitle.Location = new System.Drawing.Point(10, 190);
            this.lblSpecsTitle.Name = "lblSpecsTitle";
            this.lblSpecsTitle.Size = new System.Drawing.Size(350, 18);
            this.lblSpecsTitle.TabIndex = 4;
            this.lblSpecsTitle.Text = "THÔNG SỐ KỸ THUẬT:";
            // 
            // lstSpecs
            // 
            this.lstSpecs.BackColor = System.Drawing.Color.White;
            this.lstSpecs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSpecs.ForeColor = System.Drawing.Color.Black;
            this.lstSpecs.Location = new System.Drawing.Point(10, 210);
            this.lstSpecs.Name = "lstSpecs";
            this.lstSpecs.Size = new System.Drawing.Size(350, 140);
            this.lstSpecs.TabIndex = 5;
            this.lstSpecs.Items.AddRange(new object[] { "Man hinh Super Retina XDR 6.7 inch", "Chip Apple A17 Pro", "Bo nho 256GB", "Camera chinh 48MP", "Bao hanh chinh hang 12 thang" });
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.footerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.btnAddToCart.BackColor = System.Drawing.Color.RoyalBlue;
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
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(590, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // reviewPanel
            // 
            this.reviewPanel.BackColor = System.Drawing.Color.White;
            this.reviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reviewPanel.Controls.Add(this.lblReviewHeader);
            this.reviewPanel.Controls.Add(this.lstReviews);
            this.reviewPanel.Controls.Add(this.lblUserReviewTitle);
            this.reviewPanel.Controls.Add(this.txtUserComment);
            this.reviewPanel.Controls.Add(this.cbUserStars);
            this.reviewPanel.Controls.Add(this.btnSubmitReview);
            this.reviewPanel.Location = new System.Drawing.Point(20, 410);
            this.reviewPanel.Name = "reviewPanel";
            this.reviewPanel.Size = new System.Drawing.Size(690, 210);
            this.reviewPanel.TabIndex = 5;
            // 
            // lblReviewHeader
            // 
            this.lblReviewHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblReviewHeader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblReviewHeader.Location = new System.Drawing.Point(10, 5);
            this.lblReviewHeader.Name = "lblReviewHeader";
            this.lblReviewHeader.Size = new System.Drawing.Size(300, 20);
            this.lblReviewHeader.Text = "Đánh Giá & Nhận Xét Từ Khách Hàng";
            // 
            // lstReviews
            // 
            this.lstReviews.BackColor = System.Drawing.Color.White;
            this.lstReviews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstReviews.ForeColor = System.Drawing.Color.Black;
            this.lstReviews.Location = new System.Drawing.Point(10, 30);
            this.lstReviews.Name = "lstReviews";
            this.lstReviews.Size = new System.Drawing.Size(668, 110);
            this.lstReviews.TabIndex = 1;
            this.lstReviews.Items.AddRange(new object[] { "Nguyen Van Khach - 5 sao: May dep, chay rat muot.", "Le Minh Anh - 4 sao: Camera tot, giao hang nhanh.", "Tran Hoang - 5 sao: Dong goi can than, dung hang chinh hang." });
            // 
            // lblUserReviewTitle
            // 
            this.lblUserReviewTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUserReviewTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblUserReviewTitle.Location = new System.Drawing.Point(10, 158);
            this.lblUserReviewTitle.Name = "lblUserReviewTitle";
            this.lblUserReviewTitle.Size = new System.Drawing.Size(120, 20);
            this.lblUserReviewTitle.Text = "Viết đánh giá:";
            this.lblUserReviewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserComment
            // 
            this.txtUserComment.Location = new System.Drawing.Point(130, 156);
            this.txtUserComment.Name = "txtUserComment";
            this.txtUserComment.Size = new System.Drawing.Size(320, 25);
            this.txtUserComment.TabIndex = 2;
            this.txtUserComment.Text = "San pham dung nhu mo ta";
            // 
            // cbUserStars
            // 
            this.cbUserStars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserStars.FormattingEnabled = true;
            this.cbUserStars.Location = new System.Drawing.Point(460, 156);
            this.cbUserStars.Name = "cbUserStars";
            this.cbUserStars.Size = new System.Drawing.Size(80, 25);
            this.cbUserStars.TabIndex = 3;
            this.cbUserStars.Items.AddRange(new object[] { "5 sao", "4 sao", "3 sao", "2 sao", "1 sao" });
            this.cbUserStars.Text = "5 sao";
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSubmitReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitReview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubmitReview.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReview.Location = new System.Drawing.Point(555, 153);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(120, 30);
            this.btnSubmitReview.TabIndex = 4;
            this.btnSubmitReview.Text = "Gửi Nhận Xét";
            this.btnSubmitReview.UseVisualStyleBackColor = false;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(734, 700);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.reviewPanel);
            this.Controls.Add(this.footerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Sản Phẩm";
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.reviewPanel.ResumeLayout(false);
            this.reviewPanel.PerformLayout();
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

        // Reviews Controls declarations
        private System.Windows.Forms.Panel reviewPanel;
        private System.Windows.Forms.Label lblReviewHeader;
        private System.Windows.Forms.ListBox lstReviews;
        private System.Windows.Forms.Label lblUserReviewTitle;
        private System.Windows.Forms.TextBox txtUserComment;
        private System.Windows.Forms.ComboBox cbUserStars;
        private System.Windows.Forms.Button btnSubmitReview;
    }
}
