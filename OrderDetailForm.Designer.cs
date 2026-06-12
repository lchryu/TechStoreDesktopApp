using System.Drawing;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    partial class OrderDetailForm
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
            this.lblTitle = new Label();
            this.lblOrderId = new Label();
            this.lblOrderDate = new Label();
            this.lblStatus = new Label();
            this.line1 = new Panel();
            this.lblItemsTitle = new Label();
            this.lstItems = new ListBox();
            this.line2 = new Panel();
            this.lblTotalAmount = new Label();
            this.btnClose = new Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.DarkBlue;
            this.lblTitle.Location = new Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(360, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HÓA ĐƠN CHI TIẾT";
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrderId
            // 
            this.lblOrderId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblOrderId.Location = new Point(30, 65);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new Size(340, 20);
            this.lblOrderId.TabIndex = 1;
            this.lblOrderId.Text = "Ma don hang: #DH182418";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.ForeColor = Color.FromArgb(64, 64, 64);
            this.lblOrderDate.Location = new Point(30, 90);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new Size(340, 20);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Ngay dat hang: 11/06/2026";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblStatus.ForeColor = Color.DarkOrange;
            this.lblStatus.Location = new Point(30, 115);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(340, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Trang thai: Cho xu ly";
            // 
            // line1
            // 
            this.line1.BackColor = Color.DarkGray;
            this.line1.Location = new Point(30, 145);
            this.line1.Name = "line1";
            this.line1.Size = new Size(340, 1);
            this.line1.TabIndex = 4;
            // 
            // lblItemsTitle
            // 
            this.lblItemsTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.lblItemsTitle.Location = new Point(30, 155);
            this.lblItemsTitle.Name = "lblItemsTitle";
            this.lblItemsTitle.Size = new Size(340, 20);
            this.lblItemsTitle.TabIndex = 5;
            this.lblItemsTitle.Text = "Danh sách sản phẩm:";
            // 
            // lstItems
            // 
            this.lstItems.BackColor = Color.White;
            this.lstItems.BorderStyle = BorderStyle.None;
            this.lstItems.Font = new Font("Segoe UI", 10F);
            this.lstItems.ForeColor = Color.Black;
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 17;
            this.lstItems.Location = new Point(30, 180);
            this.lstItems.Name = "lstItems";
            this.lstItems.SelectionMode = SelectionMode.None;
            this.lstItems.Size = new Size(340, 119);
            this.lstItems.TabIndex = 6;
            this.lstItems.Items.AddRange(new object[] { "Tai Nghe Sony WH-1000XM5 x1 - 8,490,000 d", "Phi van chuyen: 0 d", "Voucher TECH10: -500,000 d" });
            // 
            // line2
            // 
            this.line2.BackColor = Color.DarkGray;
            this.line2.Location = new Point(30, 315);
            this.line2.Name = "line2";
            this.line2.Size = new Size(340, 1);
            this.line2.TabIndex = 7;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTotalAmount.ForeColor = Color.Red;
            this.lblTotalAmount.Location = new Point(30, 330);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new Size(340, 25);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "TONG TIEN: 7,990,000 d";
            this.lblTotalAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.Location = new Point(30, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(340, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "ĐÓNG HÓA ĐƠN";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 17F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(245, 245, 245);
            this.ClientSize = new Size(400, 440);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.lblItemsTitle);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnClose);
            this.Font = new Font("Segoe UI", 9.5F);
            this.ForeColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderDetailForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Đơn Hàng";
            this.ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblOrderId;
        private Label lblOrderDate;
        private Label lblStatus;
        private Panel line1;
        private Label lblItemsTitle;
        private ListBox lstItems;
        private Panel line2;
        private Label lblTotalAmount;
        private Button btnClose;
    }
}
