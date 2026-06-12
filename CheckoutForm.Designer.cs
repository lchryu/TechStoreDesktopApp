using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    partial class CheckoutForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lstSummary = new System.Windows.Forms.ListBox();
            this.line = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.summaryPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông Tin Giao Hàng";
            // 
            // lblName
            // 
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(20, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(320, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ và Tên *";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(20, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 28);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Nguyen Van Khach";
            // 
            // lblPhone
            // 
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(20, 125);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(320, 20);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Số Điện Thoại *";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(20, 145);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(320, 28);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.Text = "0987654321";
            // 
            // lblAddress
            // 
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(20, 190);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(320, 20);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Địa Chỉ Nhận Hàng *";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(20, 210);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(320, 28);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Text = "456 Duong CMT8, Quan 3, TP.HCM";
            // 
            // lblPayment
            // 
            this.lblPayment.ForeColor = System.Drawing.Color.Black;
            this.lblPayment.Location = new System.Drawing.Point(20, 255);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(320, 20);
            this.lblPayment.TabIndex = 7;
            this.lblPayment.Text = "Phương Thức Thanh Toán";
            // 
            // cbPayment
            // 
            this.cbPayment.BackColor = System.Drawing.Color.White;
            this.cbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayment.ForeColor = System.Drawing.Color.Black;
            this.cbPayment.Items.AddRange(new object[] {
            "Thanh toán khi nhận hàng (COD)",
            "Chuyển khoản ngân hàng (Mô phỏng)",
            "Ví điện tử MoMo/ZaloPay (Mô phỏng)"});
            this.cbPayment.Location = new System.Drawing.Point(20, 275);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(320, 28);
            this.cbPayment.TabIndex = 8;
            this.cbPayment.Text = "Thanh toan khi nhan hang (COD)";
            // 
            // summaryPanel
            // 
            this.summaryPanel.BackColor = System.Drawing.Color.White;
            this.summaryPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summaryPanel.Controls.Add(this.lblSummaryTitle);
            this.summaryPanel.Controls.Add(this.lstSummary);
            this.summaryPanel.Controls.Add(this.line);
            this.summaryPanel.Controls.Add(this.lblTotal);
            this.summaryPanel.Location = new System.Drawing.Point(365, 20);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(300, 360);
            this.summaryPanel.TabIndex = 9;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.Black;
            this.lblSummaryTitle.Location = new System.Drawing.Point(15, 15);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(270, 25);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "TÓM TẮT ĐƠN HÀNG";
            // 
            // lstSummary
            // 
            this.lstSummary.BackColor = System.Drawing.Color.White;
            this.lstSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSummary.ForeColor = System.Drawing.Color.Black;
            this.lstSummary.Location = new System.Drawing.Point(15, 45);
            this.lstSummary.Name = "lstSummary";
            this.lstSummary.Size = new System.Drawing.Size(270, 220);
            this.lstSummary.TabIndex = 1;
            this.lstSummary.Items.AddRange(new object[] { "iPhone 15 Pro Max 256GB x1", "Tai Nghe Sony WH-1000XM5 x1", "Apple Watch Ultra 2 Titan x1" });
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.LightGray;
            this.line.Location = new System.Drawing.Point(15, 275);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(270, 1);
            this.line.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(15, 290);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(270, 30);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Tong Cong: 60,470,000 d";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.footerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.footerPanel.Controls.Add(this.btnConfirm);
            this.footerPanel.Controls.Add(this.btnCancel);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 399);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(684, 65);
            this.footerPanel.TabIndex = 10;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(340, 15);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(180, 35);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Xác Nhận Đặt Hàng";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(540, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy Bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(684, 464);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.cbPayment);
            this.Controls.Add(this.summaryPanel);
            this.Controls.Add(this.footerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh Toán Đơn Hàng";
            this.summaryPanel.ResumeLayout(false);
            this.footerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.ListBox lstSummary;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}
