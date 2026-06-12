using System.Drawing;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    partial class AdminForm
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
            panelSidebar = new Panel();
            lblLogo = new Label();
            lblUserInfo = new Label();
            lblUserRole = new Label();
            line1 = new Panel();
            btnMenuDashboard = new Button();
            btnMenuInventory = new Button();
            btnMenuOrders = new Button();
            btnMenuUsers = new Button();
            btnMenuVouchers = new Button();
            btnMenuFeedback = new Button();
            btnMenuSettings = new Button();
            line2 = new Panel();
            btnMenuLogout = new Button();
            panelContent = new Panel();

            // 5. Vouchers Controls
            panelVouchers = new Panel();
            panelVouchersHeader = new Panel();
            lblVouchersTitle = new Label();
            dgvVouchers = new DataGridView();
            colVchCode = new DataGridViewTextBoxColumn();
            colVchDesc = new DataGridViewTextBoxColumn();
            colVchPercent = new DataGridViewTextBoxColumn();
            colVchMax = new DataGridViewTextBoxColumn();
            panelVouchersActions = new Panel();
            lblVchCode = new Label();
            txtVchCode = new TextBox();
            lblVchDesc = new Label();
            txtVchDesc = new TextBox();
            lblVchPercent = new Label();
            txtVchPercent = new TextBox();
            lblVchMax = new Label();
            txtVchMax = new TextBox();
            btnVchAdd = new Button();
            btnVchDelete = new Button();

            // 6. Feedback Controls
            panelFeedback = new Panel();
            panelFeedbackHeader = new Panel();
            lblFeedbackTitle = new Label();
            dgvFeedback = new DataGridView();
            colFbId = new DataGridViewTextBoxColumn();
            colFbName = new DataGridViewTextBoxColumn();
            colFbEmail = new DataGridViewTextBoxColumn();
            colFbDate = new DataGridViewTextBoxColumn();
            colFbStatus = new DataGridViewTextBoxColumn();
            colFbMsg = new DataGridViewTextBoxColumn();
            panelFeedbackActions = new Panel();
            btnFeedbackResolve = new Button();
            btnFeedbackDelete = new Button();

            // 7. Settings Controls
            panelSettings = new Panel();
            panelSettingsHeader = new Panel();
            lblSettingsTitle = new Label();
            panelSettingsBody = new Panel();
            lblSettingsStoreName = new Label();
            txtSettingsStoreName = new TextBox();
            lblSettingsHotline = new Label();
            txtSettingsHotline = new TextBox();
            lblSettingsEmail = new Label();
            txtSettingsEmail = new TextBox();
            lblSettingsAddress = new Label();
            txtSettingsAddress = new TextBox();
            chkSettingsMaintenance = new CheckBox();
            btnSettingsSave = new Button();
            
            // 1. Dashboard Controls
            panelDashboard = new Panel();
            lblDashboardHeader = new Label();
            panelAdminMetricsLayout = new TableLayoutPanel();
            cardRevenue = new Panel();
            lblTitleRev = new Label();
            lblStatRevenue = new Label();
            cardOrders = new Panel();
            lblTitleOrd = new Label();
            lblStatOrders = new Label();
            cardLowStock = new Panel();
            lblTitleLow = new Label();
            lblStatLowStock = new Label();
            cardTotalProd = new Panel();
            lblTitleTot = new Label();
            lblStatTotalProducts = new Label();
            panelAdminChartCard = new Panel();
            lblAdminChartTitle = new Label();
            panelChart = new Panel();
            panelPieChart = new Panel();
            lstSalesHistory = new ListBox();
            panelRevenueChart = new Panel();
            pbPieChartMock = new PictureBox();
            pbRevenueChartMock = new PictureBox();

            // 2. Inventory Controls
            panelInventory = new Panel();
            panelInventoryHeader = new Panel();
            lblInventoryTitle = new Label();
            txtAdminSearch = new TextBox();
            btnAdminAddProduct = new Button();
            dgvInventory = new DataGridView();
            colInvId = new DataGridViewTextBoxColumn();
            colInvName = new DataGridViewTextBoxColumn();
            colInvCategory = new DataGridViewTextBoxColumn();
            colInvPrice = new DataGridViewTextBoxColumn();
            colInvStock = new DataGridViewTextBoxColumn();
            colInvStatus = new DataGridViewTextBoxColumn();
            colInvEdit = new DataGridViewButtonColumn();
            colInvDelete = new DataGridViewButtonColumn();

            // 3. Orders Controls
            panelOrders = new Panel();
            panelOrdersHeader = new Panel();
            lblOrdersTitle = new Label();
            dgvOrders = new DataGridView();
            colOrdId = new DataGridViewTextBoxColumn();
            colOrdDate = new DataGridViewTextBoxColumn();
            colOrdCustomer = new DataGridViewTextBoxColumn();
            colOrdTotal = new DataGridViewTextBoxColumn();
            colOrdStatus = new DataGridViewTextBoxColumn();
            colOrdUserRef = new DataGridViewTextBoxColumn();
            panelOrdersActions = new Panel();
            btnOrderDetails = new Button();
            btnOrderShipping = new Button();
            btnOrderComplete = new Button();
            btnOrderCancel = new Button();

            // 4. Users Controls
            panelUsers = new Panel();
            panelUsersHeader = new Panel();
            lblUsersTitle = new Label();
            dgvUsers = new DataGridView();
            colUsrUsername = new DataGridViewTextBoxColumn();
            colUsrFullName = new DataGridViewTextBoxColumn();
            colUsrPhone = new DataGridViewTextBoxColumn();
            colUsrAddress = new DataGridViewTextBoxColumn();
            colUsrRole = new DataGridViewTextBoxColumn();
            panelUsersActions = new Panel();
            btnMakeAdmin = new Button();
            btnMakeCustomer = new Button();
            btnDeleteUser = new Button();

            panelSidebar.SuspendLayout();
            panelContent.SuspendLayout();
            panelDashboard.SuspendLayout();
            panelAdminMetricsLayout.SuspendLayout();
            cardRevenue.SuspendLayout();
            cardOrders.SuspendLayout();
            cardLowStock.SuspendLayout();
            cardTotalProd.SuspendLayout();
            panelAdminChartCard.SuspendLayout();
            panelChart.SuspendLayout();
            panelInventory.SuspendLayout();
            panelInventoryHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panelOrders.SuspendLayout();
            panelOrdersHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            panelOrdersActions.SuspendLayout();
            panelUsers.SuspendLayout();
            panelUsersHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panelUsersActions.SuspendLayout();

            panelVouchers.SuspendLayout();
            panelVouchersHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVouchers).BeginInit();
            panelVouchersActions.SuspendLayout();

            panelFeedback.SuspendLayout();
            panelFeedbackHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFeedback).BeginInit();
            panelFeedbackActions.SuspendLayout();

            panelSettings.SuspendLayout();
            panelSettingsHeader.SuspendLayout();
            panelSettingsBody.SuspendLayout();
            SuspendLayout();

            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(224, 224, 224);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Controls.Add(lblUserInfo);
            panelSidebar.Controls.Add(lblUserRole);
            panelSidebar.Controls.Add(line1);
            panelSidebar.Controls.Add(btnMenuDashboard);
            panelSidebar.Controls.Add(btnMenuInventory);
            panelSidebar.Controls.Add(btnMenuOrders);
            panelSidebar.Controls.Add(btnMenuUsers);
            panelSidebar.Controls.Add(btnMenuVouchers);
            panelSidebar.Controls.Add(btnMenuFeedback);
            panelSidebar.Controls.Add(btnMenuSettings);
            panelSidebar.Controls.Add(line2);
            panelSidebar.Controls.Add(btnMenuLogout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(10);
            panelSidebar.Size = new Size(240, 750);
            panelSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblLogo.ForeColor = Color.DarkBlue;
            lblLogo.Location = new Point(15, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(210, 30);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "⚙️ TechStore Admin";
            // 
            // lblUserInfo
            // 
            lblUserInfo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUserInfo.ForeColor = Color.RoyalBlue;
            lblUserInfo.Location = new Point(15, 65);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(210, 20);
            lblUserInfo.TabIndex = 1;
            lblUserInfo.Text = "Xin chào, Admin";
            // 
            // lblUserRole
            // 
            lblUserRole.Font = new Font("Segoe UI", 8F);
            lblUserRole.ForeColor = Color.FromArgb(64, 64, 64);
            lblUserRole.Location = new Point(15, 85);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(210, 15);
            lblUserRole.TabIndex = 2;
            lblUserRole.Text = "Vai trò: Quản trị viên";
            // 
            // line1
            // 
            line1.BackColor = Color.DarkGray;
            line1.Location = new Point(15, 110);
            line1.Name = "line1";
            line1.Size = new Size(210, 1);
            line1.TabIndex = 3;
            // 
            // btnMenuDashboard
            // 
            btnMenuDashboard.BackColor = Color.Transparent;
            btnMenuDashboard.FlatAppearance.BorderSize = 0;
            btnMenuDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuDashboard.FlatStyle = FlatStyle.Flat;
            btnMenuDashboard.Font = new Font("Segoe UI", 9.5F);
            btnMenuDashboard.ForeColor = Color.Black;
            btnMenuDashboard.Location = new Point(15, 125);
            btnMenuDashboard.Name = "btnMenuDashboard";
            btnMenuDashboard.Padding = new Padding(10, 0, 0, 0);
            btnMenuDashboard.Size = new Size(210, 40);
            btnMenuDashboard.TabIndex = 4;
            btnMenuDashboard.Text = "📊 Doanh Thu & Thống Kê";
            btnMenuDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuDashboard.UseVisualStyleBackColor = false;
            // 
            // btnMenuInventory
            // 
            btnMenuInventory.BackColor = Color.Transparent;
            btnMenuInventory.FlatAppearance.BorderSize = 0;
            btnMenuInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuInventory.FlatStyle = FlatStyle.Flat;
            btnMenuInventory.Font = new Font("Segoe UI", 9.5F);
            btnMenuInventory.ForeColor = Color.Black;
            btnMenuInventory.Location = new Point(15, 175);
            btnMenuInventory.Name = "btnMenuInventory";
            btnMenuInventory.Padding = new Padding(10, 0, 0, 0);
            btnMenuInventory.Size = new Size(210, 40);
            btnMenuInventory.TabIndex = 5;
            btnMenuInventory.Text = "📦 Quản Lý Kho Hàng";
            btnMenuInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuInventory.UseVisualStyleBackColor = false;
            // 
            // btnMenuOrders
            // 
            btnMenuOrders.BackColor = Color.Transparent;
            btnMenuOrders.FlatAppearance.BorderSize = 0;
            btnMenuOrders.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuOrders.FlatStyle = FlatStyle.Flat;
            btnMenuOrders.Font = new Font("Segoe UI", 9.5F);
            btnMenuOrders.ForeColor = Color.Black;
            btnMenuOrders.Location = new Point(15, 225);
            btnMenuOrders.Name = "btnMenuOrders";
            btnMenuOrders.Padding = new Padding(10, 0, 0, 0);
            btnMenuOrders.Size = new Size(210, 40);
            btnMenuOrders.TabIndex = 6;
            btnMenuOrders.Text = "📋 Quản Lý Đơn Hàng";
            btnMenuOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuOrders.UseVisualStyleBackColor = false;
            // 
            // btnMenuUsers
            // 
            btnMenuUsers.BackColor = Color.Transparent;
            btnMenuUsers.FlatAppearance.BorderSize = 0;
            btnMenuUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuUsers.FlatStyle = FlatStyle.Flat;
            btnMenuUsers.Font = new Font("Segoe UI", 9.5F);
            btnMenuUsers.ForeColor = Color.Black;
            btnMenuUsers.Location = new Point(15, 275);
            btnMenuUsers.Name = "btnMenuUsers";
            btnMenuUsers.Padding = new Padding(10, 0, 0, 0);
            btnMenuUsers.Size = new Size(210, 40);
            btnMenuUsers.TabIndex = 7;
            btnMenuUsers.Text = "👥 Quản Lý Người Dùng";
            btnMenuUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuUsers.UseVisualStyleBackColor = false;
            // 
            // btnMenuVouchers
            // 
            btnMenuVouchers.BackColor = Color.Transparent;
            btnMenuVouchers.FlatAppearance.BorderSize = 0;
            btnMenuVouchers.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuVouchers.FlatStyle = FlatStyle.Flat;
            btnMenuVouchers.Font = new Font("Segoe UI", 9.5F);
            btnMenuVouchers.ForeColor = Color.Black;
            btnMenuVouchers.Location = new Point(15, 325);
            btnMenuVouchers.Name = "btnMenuVouchers";
            btnMenuVouchers.Padding = new Padding(10, 0, 0, 0);
            btnMenuVouchers.Size = new Size(210, 40);
            btnMenuVouchers.TabIndex = 8;
            btnMenuVouchers.Text = "🎟️ Quản Lý Vouchers";
            btnMenuVouchers.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuVouchers.UseVisualStyleBackColor = false;
            // 
            // btnMenuFeedback
            // 
            btnMenuFeedback.BackColor = Color.Transparent;
            btnMenuFeedback.FlatAppearance.BorderSize = 0;
            btnMenuFeedback.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuFeedback.FlatStyle = FlatStyle.Flat;
            btnMenuFeedback.Font = new Font("Segoe UI", 9.5F);
            btnMenuFeedback.ForeColor = Color.Black;
            btnMenuFeedback.Location = new Point(15, 375);
            btnMenuFeedback.Name = "btnMenuFeedback";
            btnMenuFeedback.Padding = new Padding(10, 0, 0, 0);
            btnMenuFeedback.Size = new Size(210, 40);
            btnMenuFeedback.TabIndex = 9;
            btnMenuFeedback.Text = "💬 Phản Hồi Khách Hàng";
            btnMenuFeedback.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuFeedback.UseVisualStyleBackColor = false;
            // 
            // btnMenuSettings
            // 
            btnMenuSettings.BackColor = Color.Transparent;
            btnMenuSettings.FlatAppearance.BorderSize = 0;
            btnMenuSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuSettings.FlatStyle = FlatStyle.Flat;
            btnMenuSettings.Font = new Font("Segoe UI", 9.5F);
            btnMenuSettings.ForeColor = Color.Black;
            btnMenuSettings.Location = new Point(15, 425);
            btnMenuSettings.Name = "btnMenuSettings";
            btnMenuSettings.Padding = new Padding(10, 0, 0, 0);
            btnMenuSettings.Size = new Size(210, 40);
            btnMenuSettings.TabIndex = 10;
            btnMenuSettings.Text = "⚙️ Cấu Hình Hệ Thống";
            btnMenuSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuSettings.UseVisualStyleBackColor = false;
            // 
            // line2
            // 
            line2.BackColor = Color.DarkGray;
            line2.Location = new Point(15, 480);
            line2.Name = "line2";
            line2.Size = new Size(210, 1);
            line2.TabIndex = 11;
            // 
            // btnMenuLogout
            // 
            btnMenuLogout.BackColor = Color.Transparent;
            btnMenuLogout.Dock = DockStyle.Bottom;
            btnMenuLogout.FlatAppearance.BorderSize = 0;
            btnMenuLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuLogout.FlatStyle = FlatStyle.Flat;
            btnMenuLogout.Font = new Font("Segoe UI", 9.5F);
            btnMenuLogout.ForeColor = Color.Red;
            btnMenuLogout.Location = new Point(10, 700);
            btnMenuLogout.Name = "btnMenuLogout";
            btnMenuLogout.Padding = new Padding(10, 0, 0, 0);
            btnMenuLogout.Size = new Size(220, 40);
            btnMenuLogout.TabIndex = 9;
            btnMenuLogout.Text = "🚪 Đăng Xuất";
            btnMenuLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuLogout.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(240, 240, 240);
            panelContent.Controls.Add(panelDashboard);
            panelContent.Controls.Add(panelInventory);
            panelContent.Controls.Add(panelOrders);
            panelContent.Controls.Add(panelUsers);
            panelContent.Controls.Add(panelVouchers);
            panelContent.Controls.Add(panelFeedback);
            panelContent.Controls.Add(panelSettings);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(240, 0);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(1040, 750);
            panelContent.TabIndex = 1;
            // 
            // panelDashboard
            // 
            panelDashboard.Controls.Add(lblDashboardHeader);
            panelDashboard.Controls.Add(panelAdminMetricsLayout);
            panelDashboard.Controls.Add(panelAdminChartCard);
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.Location = new Point(20, 20);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(1000, 710);
            panelDashboard.TabIndex = 0;
            // 
            // lblDashboardHeader
            // 
            lblDashboardHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblDashboardHeader.ForeColor = Color.DarkBlue;
            lblDashboardHeader.Location = new Point(0, 0);
            lblDashboardHeader.Name = "lblDashboardHeader";
            lblDashboardHeader.Size = new Size(400, 35);
            lblDashboardHeader.TabIndex = 0;
            lblDashboardHeader.Text = "Doanh Thu & Chỉ Số Thống Kê";
            // 
            // panelAdminMetricsLayout
            // 
            panelAdminMetricsLayout.ColumnCount = 4;
            panelAdminMetricsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelAdminMetricsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelAdminMetricsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelAdminMetricsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelAdminMetricsLayout.Controls.Add(cardRevenue, 0, 0);
            panelAdminMetricsLayout.Controls.Add(cardOrders, 1, 0);
            panelAdminMetricsLayout.Controls.Add(cardLowStock, 2, 0);
            panelAdminMetricsLayout.Controls.Add(cardTotalProd, 3, 0);
            panelAdminMetricsLayout.Location = new Point(0, 50);
            panelAdminMetricsLayout.Name = "panelAdminMetricsLayout";
            panelAdminMetricsLayout.RowCount = 1;
            panelAdminMetricsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelAdminMetricsLayout.Size = new Size(1000, 95);
            panelAdminMetricsLayout.TabIndex = 1;
            // 
            // cardRevenue
            // 
            cardRevenue.BackColor = Color.White;
            cardRevenue.BorderStyle = BorderStyle.FixedSingle;
            cardRevenue.Controls.Add(lblTitleRev);
            cardRevenue.Controls.Add(lblStatRevenue);
            cardRevenue.Dock = DockStyle.Fill;
            cardRevenue.Location = new Point(3, 3);
            cardRevenue.Name = "cardRevenue";
            cardRevenue.Padding = new Padding(15, 10, 15, 10);
            cardRevenue.Size = new Size(244, 89);
            cardRevenue.TabIndex = 0;
            // 
            // lblTitleRev
            // 
            lblTitleRev.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitleRev.Location = new Point(15, 15);
            lblTitleRev.Name = "lblTitleRev";
            lblTitleRev.Size = new Size(210, 20);
            lblTitleRev.TabIndex = 0;
            lblTitleRev.Text = "TỔNG DOANH THU";
            // 
            // lblStatRevenue
            // 
            lblStatRevenue.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStatRevenue.ForeColor = Color.ForestGreen;
            lblStatRevenue.Location = new Point(15, 40);
            lblStatRevenue.Name = "lblStatRevenue";
            lblStatRevenue.Size = new Size(210, 30);
            lblStatRevenue.TabIndex = 1;
            lblStatRevenue.Text = "128,850,000 d";
            // 
            // cardOrders
            // 
            cardOrders.BackColor = Color.White;
            cardOrders.BorderStyle = BorderStyle.FixedSingle;
            cardOrders.Controls.Add(lblTitleOrd);
            cardOrders.Controls.Add(lblStatOrders);
            cardOrders.Dock = DockStyle.Fill;
            cardOrders.Location = new Point(253, 3);
            cardOrders.Name = "cardOrders";
            cardOrders.Padding = new Padding(15, 10, 15, 10);
            cardOrders.Size = new Size(244, 89);
            cardOrders.TabIndex = 1;
            // 
            // lblTitleOrd
            // 
            lblTitleOrd.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitleOrd.Location = new Point(15, 15);
            lblTitleOrd.Name = "lblTitleOrd";
            lblTitleOrd.Size = new Size(210, 20);
            lblTitleOrd.TabIndex = 0;
            lblTitleOrd.Text = "SỐ ĐƠN HÀNG DUYỆT";
            // 
            // lblStatOrders
            // 
            lblStatOrders.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStatOrders.ForeColor = Color.RoyalBlue;
            lblStatOrders.Location = new Point(15, 40);
            lblStatOrders.Name = "lblStatOrders";
            lblStatOrders.Size = new Size(210, 30);
            lblStatOrders.TabIndex = 1;
            lblStatOrders.Text = "6";
            // 
            // cardLowStock
            // 
            cardLowStock.BackColor = Color.White;
            cardLowStock.BorderStyle = BorderStyle.FixedSingle;
            cardLowStock.Controls.Add(lblTitleLow);
            cardLowStock.Controls.Add(lblStatLowStock);
            cardLowStock.Dock = DockStyle.Fill;
            cardLowStock.Location = new Point(503, 3);
            cardLowStock.Name = "cardLowStock";
            cardLowStock.Padding = new Padding(15, 10, 15, 10);
            cardLowStock.Size = new Size(244, 89);
            cardLowStock.TabIndex = 2;
            // 
            // lblTitleLow
            // 
            lblTitleLow.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitleLow.Location = new Point(15, 15);
            lblTitleLow.Name = "lblTitleLow";
            lblTitleLow.Size = new Size(210, 20);
            lblTitleLow.TabIndex = 0;
            lblTitleLow.Text = "HÀNG SẮP HẾT (< 5)";
            // 
            // lblStatLowStock
            // 
            lblStatLowStock.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStatLowStock.ForeColor = Color.Red;
            lblStatLowStock.Location = new Point(15, 40);
            lblStatLowStock.Name = "lblStatLowStock";
            lblStatLowStock.Size = new Size(210, 30);
            lblStatLowStock.TabIndex = 1;
            lblStatLowStock.Text = "4";
            // 
            // cardTotalProd
            // 
            cardTotalProd.BackColor = Color.White;
            cardTotalProd.BorderStyle = BorderStyle.FixedSingle;
            cardTotalProd.Controls.Add(lblTitleTot);
            cardTotalProd.Controls.Add(lblStatTotalProducts);
            cardTotalProd.Dock = DockStyle.Fill;
            cardTotalProd.Location = new Point(753, 3);
            cardTotalProd.Name = "cardTotalProd";
            cardTotalProd.Padding = new Padding(15, 10, 15, 10);
            cardTotalProd.Size = new Size(244, 89);
            cardTotalProd.TabIndex = 3;
            // 
            // lblTitleTot
            // 
            lblTitleTot.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitleTot.Location = new Point(15, 15);
            lblTitleTot.Name = "lblTitleTot";
            lblTitleTot.Size = new Size(210, 20);
            lblTitleTot.TabIndex = 0;
            lblTitleTot.Text = "TỔNG ĐẦU SẢN PHẨM";
            // 
            // lblStatTotalProducts
            // 
            lblStatTotalProducts.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStatTotalProducts.ForeColor = Color.Black;
            lblStatTotalProducts.Location = new Point(15, 40);
            lblStatTotalProducts.Name = "lblStatTotalProducts";
            lblStatTotalProducts.Size = new Size(210, 30);
            lblStatTotalProducts.TabIndex = 1;
            lblStatTotalProducts.Text = "21";
            // 
            // panelAdminChartCard
            // 
            panelAdminChartCard.BackColor = Color.White;
            panelAdminChartCard.BorderStyle = BorderStyle.FixedSingle;
            panelAdminChartCard.Controls.Add(lblAdminChartTitle);
            panelAdminChartCard.Controls.Add(panelChart);
            panelAdminChartCard.Location = new Point(0, 170);
            panelAdminChartCard.Name = "panelAdminChartCard";
            panelAdminChartCard.Padding = new Padding(15);
            panelAdminChartCard.Size = new Size(1000, 520);
            panelAdminChartCard.TabIndex = 2;
            // 
            // lblAdminChartTitle
            // 
            lblAdminChartTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAdminChartTitle.ForeColor = Color.Black;
            lblAdminChartTitle.Location = new Point(15, 15);
            lblAdminChartTitle.Name = "lblAdminChartTitle";
            lblAdminChartTitle.Size = new Size(300, 20);
            lblAdminChartTitle.TabIndex = 0;
            lblAdminChartTitle.Text = "LỊCH SỬ BIẾN ĐỘNG DOANH THU THEO NGÀY";
            // 
            // 
            // 
            // panelChart
            // 
            panelChart.Controls.Add(panelRevenueChart);
            panelChart.Controls.Add(lstSalesHistory);
            panelChart.Controls.Add(panelPieChart);
            panelChart.Location = new Point(15, 45);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(970, 450);
            panelChart.TabIndex = 1;
            // 
            // lstSalesHistory
            // 
            lstSalesHistory.BorderStyle = BorderStyle.None;
            lstSalesHistory.Dock = DockStyle.Left;
            lstSalesHistory.Width = 280;
            lstSalesHistory.Font = new Font("Segoe UI", 10F);
            lstSalesHistory.FormattingEnabled = true;
            lstSalesHistory.ItemHeight = 17;
            lstSalesHistory.Location = new Point(0, 0);
            lstSalesHistory.Name = "lstSalesHistory";
            lstSalesHistory.Size = new Size(280, 450);
            lstSalesHistory.TabIndex = 0;
            lstSalesHistory.Items.AddRange(new object[] { "Ngay: 08/06/2026      | Doanh thu: 2,450,000 d", "Ngay: 09/06/2026      | Doanh thu: 18,490,000 d", "Ngay: 10/06/2026      | Doanh thu: 39,990,000 d", "Ngay: 11/06/2026      | Doanh thu: 67,920,000 d" });
            // 
            // panelPieChart
            // 
            panelPieChart.Controls.Add(pbPieChartMock);
            panelPieChart.Dock = DockStyle.Right;
            panelPieChart.Width = 380;
            panelPieChart.BackColor = Color.White;
            panelPieChart.Name = "panelPieChart";
            panelPieChart.BorderStyle = BorderStyle.None;
            panelPieChart.Paint += PanelPieChart_Paint;
            // 
            // pbPieChartMock
            // 
            pbPieChartMock.Dock = DockStyle.Fill;
            pbPieChartMock.SizeMode = PictureBoxSizeMode.Zoom;
            pbPieChartMock.Name = "pbPieChartMock";
            // 
            // panelRevenueChart
            // 
            panelRevenueChart.Controls.Add(pbRevenueChartMock);
            panelRevenueChart.Dock = DockStyle.Fill;
            panelRevenueChart.BackColor = Color.White;
            panelRevenueChart.Name = "panelRevenueChart";
            panelRevenueChart.BorderStyle = BorderStyle.None;
            panelRevenueChart.Paint += PanelRevenueChart_Paint;
            // 
            // pbRevenueChartMock
            // 
            pbRevenueChartMock.Dock = DockStyle.Fill;
            pbRevenueChartMock.SizeMode = PictureBoxSizeMode.Zoom;
            pbRevenueChartMock.Name = "pbRevenueChartMock";
            // 
            // panelInventory
            // 
            panelInventory.Controls.Add(panelInventoryHeader);
            panelInventory.Controls.Add(dgvInventory);
            panelInventory.Dock = DockStyle.Fill;
            panelInventory.Location = new Point(20, 20);
            panelInventory.Name = "panelInventory";
            panelInventory.Size = new Size(1000, 710);
            panelInventory.TabIndex = 1;
            panelInventory.Visible = false;
            // 
            // panelInventoryHeader
            // 
            panelInventoryHeader.Controls.Add(lblInventoryTitle);
            panelInventoryHeader.Controls.Add(txtAdminSearch);
            panelInventoryHeader.Controls.Add(btnAdminAddProduct);
            panelInventoryHeader.Dock = DockStyle.Top;
            panelInventoryHeader.Location = new Point(0, 0);
            panelInventoryHeader.Name = "panelInventoryHeader";
            panelInventoryHeader.Size = new Size(1000, 50);
            panelInventoryHeader.TabIndex = 0;
            // 
            // lblInventoryTitle
            // 
            lblInventoryTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblInventoryTitle.ForeColor = Color.DarkBlue;
            lblInventoryTitle.Location = new Point(0, 5);
            lblInventoryTitle.Name = "lblInventoryTitle";
            lblInventoryTitle.Size = new Size(350, 30);
            lblInventoryTitle.TabIndex = 0;
            lblInventoryTitle.Text = "Quản Lý Danh Mục Kho Hàng";
            // 
            // txtAdminSearch
            // 
            txtAdminSearch.BorderStyle = BorderStyle.FixedSingle;
            txtAdminSearch.Location = new Point(520, 12);
            txtAdminSearch.Name = "txtAdminSearch";
            txtAdminSearch.PlaceholderText = "Tìm kiếm sản phẩm trong kho...";
            txtAdminSearch.Size = new Size(280, 25);
            txtAdminSearch.TabIndex = 1;
            // 
            // btnAdminAddProduct
            // 
            btnAdminAddProduct.BackColor = Color.ForestGreen;
            btnAdminAddProduct.FlatAppearance.BorderSize = 0;
            btnAdminAddProduct.FlatStyle = FlatStyle.Flat;
            btnAdminAddProduct.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdminAddProduct.ForeColor = Color.White;
            btnAdminAddProduct.Location = new Point(815, 8);
            btnAdminAddProduct.Name = "btnAdminAddProduct";
            btnAdminAddProduct.Size = new Size(180, 32);
            btnAdminAddProduct.TabIndex = 2;
            btnAdminAddProduct.Text = "➕ Thêm Sản Phẩm Mới";
            btnAdminAddProduct.UseVisualStyleBackColor = false;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Columns.AddRange(new DataGridViewColumn[] {
            colInvId,
            colInvName,
            colInvCategory,
            colInvPrice,
            colInvStock,
            colInvStatus,
            colInvEdit,
            colInvDelete});
            dgvInventory.Location = new Point(0, 60);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowTemplate.Height = 35;
            dgvInventory.Size = new Size(1000, 630);
            dgvInventory.TabIndex = 1;
            dgvInventory.Rows.Add("p1", "iPhone 15 Pro Max 256GB", "Apple", "29,990,000 d", "12", "Con hang", "Sua", "Xoa");
            dgvInventory.Rows.Add("p3", "Samsung Galaxy S24 Ultra", "Samsung", "31,990,000 d", "9", "Con hang", "Sua", "Xoa");
            dgvInventory.Rows.Add("p5", "Xiaomi 14 Ultra 5G", "Xiaomi", "27,990,000 d", "4", "Sap het", "Sua", "Xoa");
            dgvInventory.Rows.Add("p6", "MacBook Pro 14 inch M3", "Laptop", "39,990,000 d", "8", "Con hang", "Sua", "Xoa");
            dgvInventory.Rows.Add("p8", "Apple Watch Ultra 2 Titan", "Smartwatch", "21,990,000 d", "3", "Sap het", "Sua", "Xoa");
            dgvInventory.Rows.Add("p10", "Tai Nghe Sony WH-1000XM5", "Phu kien", "8,490,000 d", "4", "Sap het", "Sua", "Xoa");
            // 
            // colInvId
            // 
            colInvId.HeaderText = "Mã SP";
            colInvId.Name = "colInvId";
            colInvId.ReadOnly = true;
            colInvId.Width = 90;
            // 
            // colInvName
            // 
            colInvName.HeaderText = "Tên Sản Phẩm";
            colInvName.Name = "colInvName";
            colInvName.ReadOnly = true;
            colInvName.Width = 320;
            // 
            // colInvCategory
            // 
            colInvCategory.HeaderText = "Danh mục";
            colInvCategory.Name = "colInvCategory";
            colInvCategory.ReadOnly = true;
            colInvCategory.Width = 140;
            // 
            // colInvPrice
            // 
            colInvPrice.HeaderText = "Giá bán";
            colInvPrice.Name = "colInvPrice";
            colInvPrice.ReadOnly = true;
            colInvPrice.Width = 140;
            // 
            // colInvStock
            // 
            colInvStock.HeaderText = "Tồn Kho";
            colInvStock.Name = "colInvStock";
            colInvStock.ReadOnly = true;
            colInvStock.Width = 90;
            // 
            // colInvStatus
            // 
            colInvStatus.HeaderText = "Trạng thái";
            colInvStatus.Name = "colInvStatus";
            colInvStatus.ReadOnly = true;
            colInvStatus.Width = 100;
            // 
            // colInvEdit
            // 
            colInvEdit.HeaderText = "Sửa";
            colInvEdit.Name = "colInvEdit";
            colInvEdit.ReadOnly = true;
            colInvEdit.Text = "Sửa ✏️";
            colInvEdit.UseColumnTextForButtonValue = true;
            colInvEdit.Width = 60;
            // 
            // colInvDelete
            // 
            colInvDelete.HeaderText = "Xóa";
            colInvDelete.Name = "colInvDelete";
            colInvDelete.ReadOnly = true;
            colInvDelete.Text = "Xóa 🗑️";
            colInvDelete.UseColumnTextForButtonValue = true;
            colInvDelete.Width = 60;
            // 
            // panelOrders
            // 
            panelOrders.Controls.Add(panelOrdersHeader);
            panelOrders.Controls.Add(dgvOrders);
            panelOrders.Controls.Add(panelOrdersActions);
            panelOrders.Dock = DockStyle.Fill;
            panelOrders.Location = new Point(20, 20);
            panelOrders.Name = "panelOrders";
            panelOrders.Size = new Size(1000, 710);
            panelOrders.TabIndex = 2;
            panelOrders.Visible = false;
            // 
            // panelOrdersHeader
            // 
            panelOrdersHeader.Controls.Add(lblOrdersTitle);
            panelOrdersHeader.Dock = DockStyle.Top;
            panelOrdersHeader.Location = new Point(0, 0);
            panelOrdersHeader.Name = "panelOrdersHeader";
            panelOrdersHeader.Size = new Size(1000, 50);
            panelOrdersHeader.TabIndex = 0;
            // 
            // lblOrdersTitle
            // 
            lblOrdersTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblOrdersTitle.ForeColor = Color.DarkBlue;
            lblOrdersTitle.Location = new Point(0, 5);
            lblOrdersTitle.Name = "lblOrdersTitle";
            lblOrdersTitle.Size = new Size(400, 30);
            lblOrdersTitle.TabIndex = 0;
            lblOrdersTitle.Text = "Quản Lý Đơn Hàng Khách Đặt";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] {
            colOrdId,
            colOrdDate,
            colOrdCustomer,
            colOrdTotal,
            colOrdStatus,
            colOrdUserRef});
            dgvOrders.Location = new Point(0, 60);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.RowTemplate.Height = 35;
            dgvOrders.Size = new Size(1000, 560);
            dgvOrders.TabIndex = 1;
            dgvOrders.Rows.Add("DH182418", "11/06/2026", "Nguyen Van Khach", "8,490,000 d", "Cho xu ly", "user");
            dgvOrders.Rows.Add("DH165802", "11/06/2026", "Nguyen Van Khach", "8,490,000 d", "Cho xu ly", "user");
            dgvOrders.Rows.Add("DH1024", "08/06/2026", "Nguyen Van Khach", "2,450,000 d", "Dang giao", "user");
            dgvOrders.Rows.Add("DH2048", "10/06/2026", "Nguyen Van Khach", "39,990,000 d", "Da giao", "user");
            // 
            // colOrdId
            // 
            colOrdId.HeaderText = "Mã Đơn Hàng";
            colOrdId.Name = "colOrdId";
            colOrdId.ReadOnly = true;
            colOrdId.Width = 120;
            // 
            // colOrdDate
            // 
            colOrdDate.HeaderText = "Ngày Đặt";
            colOrdDate.Name = "colOrdDate";
            colOrdDate.ReadOnly = true;
            colOrdDate.Width = 140;
            // 
            // colOrdCustomer
            // 
            colOrdCustomer.HeaderText = "Khách Hàng";
            colOrdCustomer.Name = "colOrdCustomer";
            colOrdCustomer.ReadOnly = true;
            colOrdCustomer.Width = 220;
            // 
            // colOrdTotal
            // 
            colOrdTotal.HeaderText = "Tổng Tiền";
            colOrdTotal.Name = "colOrdTotal";
            colOrdTotal.ReadOnly = true;
            colOrdTotal.Width = 180;
            // 
            // colOrdStatus
            // 
            colOrdStatus.HeaderText = "Trạng Thái";
            colOrdStatus.Name = "colOrdStatus";
            colOrdStatus.ReadOnly = true;
            colOrdStatus.Width = 180;
            // 
            // colOrdUserRef
            // 
            colOrdUserRef.HeaderText = "UserRef";
            colOrdUserRef.Name = "colOrdUserRef";
            colOrdUserRef.ReadOnly = true;
            colOrdUserRef.Visible = false; // Hidden reference column
            // 
            // panelOrdersActions
            // 
            panelOrdersActions.BackColor = Color.White;
            panelOrdersActions.BorderStyle = BorderStyle.FixedSingle;
            panelOrdersActions.Controls.Add(btnOrderDetails);
            panelOrdersActions.Controls.Add(btnOrderShipping);
            panelOrdersActions.Controls.Add(btnOrderComplete);
            panelOrdersActions.Controls.Add(btnOrderCancel);
            panelOrdersActions.Location = new Point(0, 630);
            panelOrdersActions.Name = "panelOrdersActions";
            panelOrdersActions.Size = new Size(1000, 65);
            panelOrdersActions.TabIndex = 2;
            // 
            // btnOrderDetails
            // 
            btnOrderDetails.BackColor = Color.RoyalBlue;
            btnOrderDetails.FlatAppearance.BorderSize = 0;
            btnOrderDetails.FlatStyle = FlatStyle.Flat;
            btnOrderDetails.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnOrderDetails.ForeColor = Color.White;
            btnOrderDetails.Location = new Point(15, 12);
            btnOrderDetails.Name = "btnOrderDetails";
            btnOrderDetails.Size = new Size(170, 40);
            btnOrderDetails.TabIndex = 0;
            btnOrderDetails.Text = "🔍 Xem Chi Tiết";
            btnOrderDetails.UseVisualStyleBackColor = false;
            // 
            // btnOrderShipping
            // 
            btnOrderShipping.BackColor = Color.DarkOrange;
            btnOrderShipping.FlatAppearance.BorderSize = 0;
            btnOrderShipping.FlatStyle = FlatStyle.Flat;
            btnOrderShipping.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnOrderShipping.ForeColor = Color.White;
            btnOrderShipping.Location = new Point(440, 12);
            btnOrderShipping.Name = "btnOrderShipping";
            btnOrderShipping.Size = new Size(170, 40);
            btnOrderShipping.TabIndex = 1;
            btnOrderShipping.Text = "🚚 Giao Hàng";
            btnOrderShipping.UseVisualStyleBackColor = false;
            // 
            // btnOrderComplete
            // 
            btnOrderComplete.BackColor = Color.ForestGreen;
            btnOrderComplete.FlatAppearance.BorderSize = 0;
            btnOrderComplete.FlatStyle = FlatStyle.Flat;
            btnOrderComplete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnOrderComplete.ForeColor = Color.White;
            btnOrderComplete.Location = new Point(625, 12);
            btnOrderComplete.Name = "btnOrderComplete";
            btnOrderComplete.Size = new Size(170, 40);
            btnOrderComplete.TabIndex = 2;
            btnOrderComplete.Text = "✓ Đã Giao Hàng";
            btnOrderComplete.UseVisualStyleBackColor = false;
            // 
            // btnOrderCancel
            // 
            btnOrderCancel.BackColor = Color.Red;
            btnOrderCancel.FlatAppearance.BorderSize = 0;
            btnOrderCancel.FlatStyle = FlatStyle.Flat;
            btnOrderCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnOrderCancel.ForeColor = Color.White;
            btnOrderCancel.Location = new Point(810, 12);
            btnOrderCancel.Name = "btnOrderCancel";
            btnOrderCancel.Size = new Size(170, 40);
            btnOrderCancel.TabIndex = 3;
            btnOrderCancel.Text = "✕ Hủy Đơn";
            btnOrderCancel.UseVisualStyleBackColor = false;
            // 
            // panelUsers
            // 
            panelUsers.Controls.Add(panelUsersHeader);
            panelUsers.Controls.Add(dgvUsers);
            panelUsers.Controls.Add(panelUsersActions);
            panelUsers.Dock = DockStyle.Fill;
            panelUsers.Location = new Point(20, 20);
            panelUsers.Name = "panelUsers";
            panelUsers.Size = new Size(1000, 710);
            panelUsers.TabIndex = 3;
            panelUsers.Visible = false;
            // 
            // panelUsersHeader
            // 
            panelUsersHeader.Controls.Add(lblUsersTitle);
            panelUsersHeader.Dock = DockStyle.Top;
            panelUsersHeader.Location = new Point(0, 0);
            panelUsersHeader.Name = "panelUsersHeader";
            panelUsersHeader.Size = new Size(1000, 50);
            panelUsersHeader.TabIndex = 0;
            // 
            // lblUsersTitle
            // 
            lblUsersTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblUsersTitle.ForeColor = Color.DarkBlue;
            lblUsersTitle.Location = new Point(0, 5);
            lblUsersTitle.Name = "lblUsersTitle";
            lblUsersTitle.Size = new Size(400, 30);
            lblUsersTitle.TabIndex = 0;
            lblUsersTitle.Text = "Quản Lý Danh Sách Tài Khoản";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] {
            colUsrUsername,
            colUsrFullName,
            colUsrPhone,
            colUsrAddress,
            colUsrRole});
            dgvUsers.Location = new Point(0, 60);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.RowTemplate.Height = 35;
            dgvUsers.Size = new Size(1000, 560);
            dgvUsers.TabIndex = 1;
            dgvUsers.Rows.Add("user", "Nguyen Van Khach", "0987654321", "456 Duong CMT8, Quan 3, TP.HCM", "customer");
            dgvUsers.Rows.Add("admin", "Tran Quan Tri", "0909090909", "123 Duong Le Loi, Quan 1, TP.HCM", "admin");
            // 
            // colUsrUsername
            // 
            colUsrUsername.HeaderText = "Tên Đăng Nhập";
            colUsrUsername.Name = "colUsrUsername";
            colUsrUsername.ReadOnly = true;
            colUsrUsername.Width = 140;
            // 
            // colUsrFullName
            // 
            colUsrFullName.HeaderText = "Họ và Tên";
            colUsrFullName.Name = "colUsrFullName";
            colUsrFullName.ReadOnly = true;
            colUsrFullName.Width = 200;
            // 
            // colUsrPhone
            // 
            colUsrPhone.HeaderText = "Số Điện Thoại";
            colUsrPhone.Name = "colUsrPhone";
            colUsrPhone.ReadOnly = true;
            colUsrPhone.Width = 130;
            // 
            // colUsrAddress
            // 
            colUsrAddress.HeaderText = "Địa Chỉ Thường Trú";
            colUsrAddress.Name = "colUsrAddress";
            colUsrAddress.ReadOnly = true;
            colUsrAddress.Width = 380;
            // 
            // colUsrRole
            // 
            colUsrRole.HeaderText = "Vai Trò";
            colUsrRole.Name = "colUsrRole";
            colUsrRole.ReadOnly = true;
            colUsrRole.Width = 130;
            // 
            // panelUsersActions
            // 
            panelUsersActions.BackColor = Color.White;
            panelUsersActions.BorderStyle = BorderStyle.FixedSingle;
            panelUsersActions.Controls.Add(btnMakeAdmin);
            panelUsersActions.Controls.Add(btnMakeCustomer);
            panelUsersActions.Controls.Add(btnDeleteUser);
            panelUsersActions.Location = new Point(0, 630);
            panelUsersActions.Name = "panelUsersActions";
            panelUsersActions.Size = new Size(1000, 65);
            panelUsersActions.TabIndex = 2;
            // 
            // btnMakeAdmin
            // 
            btnMakeAdmin.BackColor = Color.ForestGreen;
            btnMakeAdmin.FlatAppearance.BorderSize = 0;
            btnMakeAdmin.FlatStyle = FlatStyle.Flat;
            btnMakeAdmin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnMakeAdmin.ForeColor = Color.White;
            btnMakeAdmin.Location = new Point(15, 12);
            btnMakeAdmin.Name = "btnMakeAdmin";
            btnMakeAdmin.Size = new Size(180, 40);
            btnMakeAdmin.TabIndex = 0;
            btnMakeAdmin.Text = "🛡️ Cấp Quyền Admin";
            btnMakeAdmin.UseVisualStyleBackColor = false;
            // 
            // btnMakeCustomer
            // 
            btnMakeCustomer.BackColor = Color.RoyalBlue;
            btnMakeCustomer.FlatAppearance.BorderSize = 0;
            btnMakeCustomer.FlatStyle = FlatStyle.Flat;
            btnMakeCustomer.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnMakeCustomer.ForeColor = Color.White;
            btnMakeCustomer.Location = new Point(210, 12);
            btnMakeCustomer.Name = "btnMakeCustomer";
            btnMakeCustomer.Size = new Size(180, 40);
            btnMakeCustomer.TabIndex = 1;
            btnMakeCustomer.Text = "👤 Đặt làm Khách Hàng";
            btnMakeCustomer.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Red;
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(805, 12);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(180, 40);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "🗑️ Xóa Tài Khoản";
            btnDeleteUser.UseVisualStyleBackColor = false;

            // 
            // panelVouchers
            // 
            panelVouchers.Controls.Add(panelVouchersHeader);
            panelVouchers.Controls.Add(dgvVouchers);
            panelVouchers.Controls.Add(panelVouchersActions);
            panelVouchers.Dock = DockStyle.Fill;
            panelVouchers.Location = new Point(20, 20);
            panelVouchers.Name = "panelVouchers";
            panelVouchers.Size = new Size(1000, 710);
            panelVouchers.TabIndex = 4;
            panelVouchers.Visible = false;
            // 
            // panelVouchersHeader
            // 
            panelVouchersHeader.Controls.Add(lblVouchersTitle);
            panelVouchersHeader.Dock = DockStyle.Top;
            panelVouchersHeader.Location = new Point(0, 0);
            panelVouchersHeader.Name = "panelVouchersHeader";
            panelVouchersHeader.Size = new Size(1000, 50);
            panelVouchersHeader.TabIndex = 0;
            // 
            // lblVouchersTitle
            // 
            lblVouchersTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblVouchersTitle.ForeColor = Color.DarkBlue;
            lblVouchersTitle.Location = new Point(0, 5);
            lblVouchersTitle.Name = "lblVouchersTitle";
            lblVouchersTitle.Size = new Size(400, 30);
            lblVouchersTitle.TabIndex = 0;
            lblVouchersTitle.Text = "Quản Lý Mã Giảm Giá (Vouchers)";
            // 
            // dgvVouchers
            // 
            dgvVouchers.AllowUserToAddRows = false;
            dgvVouchers.AllowUserToDeleteRows = false;
            dgvVouchers.BackgroundColor = Color.White;
            dgvVouchers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVouchers.Columns.AddRange(new DataGridViewColumn[] {
            colVchCode,
            colVchDesc,
            colVchPercent,
            colVchMax});
            dgvVouchers.Location = new Point(0, 60);
            dgvVouchers.Name = "dgvVouchers";
            dgvVouchers.ReadOnly = true;
            dgvVouchers.RowHeadersVisible = false;
            dgvVouchers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVouchers.RowTemplate.Height = 35;
            dgvVouchers.Size = new Size(1000, 430);
            dgvVouchers.TabIndex = 1;
            dgvVouchers.Rows.Add("TECH10", "Giam 10% tong don hang", "10%", "500,000 d");
            dgvVouchers.Rows.Add("SALEOFF", "Giam 20% cho khach hang moi", "20%", "200,000 d");
            dgvVouchers.Rows.Add("FREESHIP", "Giam 5% ho tro phi ship", "5%", "50,000 d");
            dgvVouchers.Rows.Add("LAPTOP15", "Giam 15% cho don laptop", "15%", "1,000,000 d");
            // 
            // colVchCode
            // 
            colVchCode.HeaderText = "Mã Voucher";
            colVchCode.Name = "colVchCode";
            colVchCode.ReadOnly = true;
            colVchCode.Width = 150;
            // 
            // colVchDesc
            // 
            colVchDesc.HeaderText = "Mô Tả Khuyến Mãi";
            colVchDesc.Name = "colVchDesc";
            colVchDesc.ReadOnly = true;
            colVchDesc.Width = 450;
            // 
            // colVchPercent
            // 
            colVchPercent.HeaderText = "Phần Trăm Giảm";
            colVchPercent.Name = "colVchPercent";
            colVchPercent.ReadOnly = true;
            colVchPercent.Width = 180;
            // 
            // colVchMax
            // 
            colVchMax.HeaderText = "Giảm Tối Đa";
            colVchMax.Name = "colVchMax";
            colVchMax.ReadOnly = true;
            colVchMax.Width = 180;
            // 
            // panelVouchersActions
            // 
            panelVouchersActions.BackColor = Color.White;
            panelVouchersActions.BorderStyle = BorderStyle.FixedSingle;
            panelVouchersActions.Controls.Add(lblVchCode);
            panelVouchersActions.Controls.Add(txtVchCode);
            panelVouchersActions.Controls.Add(lblVchDesc);
            panelVouchersActions.Controls.Add(txtVchDesc);
            panelVouchersActions.Controls.Add(lblVchPercent);
            panelVouchersActions.Controls.Add(txtVchPercent);
            panelVouchersActions.Controls.Add(lblVchMax);
            panelVouchersActions.Controls.Add(txtVchMax);
            panelVouchersActions.Controls.Add(btnVchAdd);
            panelVouchersActions.Controls.Add(btnVchDelete);
            panelVouchersActions.Location = new Point(0, 500);
            panelVouchersActions.Name = "panelVouchersActions";
            panelVouchersActions.Size = new Size(1000, 195);
            panelVouchersActions.TabIndex = 2;
            // 
            // lblVchCode
            // 
            lblVchCode.Location = new Point(20, 20);
            lblVchCode.Size = new Size(100, 25);
            lblVchCode.Text = "Mã Voucher:";
            lblVchCode.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            // 
            // txtVchCode
            // 
            txtVchCode.Location = new Point(130, 17);
            txtVchCode.Size = new Size(200, 25);
            // 
            // lblVchDesc
            // 
            lblVchDesc.Location = new Point(380, 20);
            lblVchDesc.Size = new Size(100, 25);
            lblVchDesc.Text = "Mô Tả:";
            lblVchDesc.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            // 
            // txtVchDesc
            // 
            txtVchDesc.Location = new Point(490, 17);
            txtVchDesc.Size = new Size(450, 25);
            // 
            // lblVchPercent
            // 
            lblVchPercent.Location = new Point(20, 65);
            lblVchPercent.Size = new Size(100, 25);
            lblVchPercent.Text = "% Giảm:";
            lblVchPercent.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            // 
            // txtVchPercent
            // 
            txtVchPercent.Location = new Point(130, 62);
            txtVchPercent.Size = new Size(200, 25);
            // 
            // lblVchMax
            // 
            lblVchMax.Location = new Point(380, 65);
            lblVchMax.Size = new Size(100, 25);
            lblVchMax.Text = "Giảm Tối Đa (₫):";
            lblVchMax.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            // 
            // txtVchMax
            // 
            txtVchMax.Location = new Point(490, 62);
            txtVchMax.Size = new Size(200, 25);
            // 
            // btnVchAdd
            // 
            btnVchAdd.BackColor = Color.ForestGreen;
            btnVchAdd.FlatAppearance.BorderSize = 0;
            btnVchAdd.FlatStyle = FlatStyle.Flat;
            btnVchAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnVchAdd.ForeColor = Color.White;
            btnVchAdd.Location = new Point(760, 120);
            btnVchAdd.Name = "btnVchAdd";
            btnVchAdd.Size = new Size(180, 40);
            btnVchAdd.TabIndex = 8;
            btnVchAdd.Text = "➕ Thêm Voucher";
            btnVchAdd.UseVisualStyleBackColor = false;
            // 
            // btnVchDelete
            // 
            btnVchDelete.BackColor = Color.Red;
            btnVchDelete.FlatAppearance.BorderSize = 0;
            btnVchDelete.FlatStyle = FlatStyle.Flat;
            btnVchDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnVchDelete.ForeColor = Color.White;
            btnVchDelete.Location = new Point(560, 120);
            btnVchDelete.Name = "btnVchDelete";
            btnVchDelete.Size = new Size(180, 40);
            btnVchDelete.TabIndex = 9;
            btnVchDelete.Text = "🗑️ Xóa Voucher";
            btnVchDelete.UseVisualStyleBackColor = false;

            // 
            // panelFeedback
            // 
            panelFeedback.Controls.Add(panelFeedbackHeader);
            panelFeedback.Controls.Add(dgvFeedback);
            panelFeedback.Controls.Add(panelFeedbackActions);
            panelFeedback.Dock = DockStyle.Fill;
            panelFeedback.Location = new Point(20, 20);
            panelFeedback.Name = "panelFeedback";
            panelFeedback.Size = new Size(1000, 710);
            panelFeedback.TabIndex = 5;
            panelFeedback.Visible = false;
            // 
            // panelFeedbackHeader
            // 
            panelFeedbackHeader.Controls.Add(lblFeedbackTitle);
            panelFeedbackHeader.Dock = DockStyle.Top;
            panelFeedbackHeader.Location = new Point(0, 0);
            panelFeedbackHeader.Name = "panelFeedbackHeader";
            panelFeedbackHeader.Size = new Size(1000, 50);
            panelFeedbackHeader.TabIndex = 0;
            // 
            // lblFeedbackTitle
            // 
            lblFeedbackTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFeedbackTitle.ForeColor = Color.DarkBlue;
            lblFeedbackTitle.Location = new Point(0, 5);
            lblFeedbackTitle.Name = "lblFeedbackTitle";
            lblFeedbackTitle.Size = new Size(450, 30);
            lblFeedbackTitle.TabIndex = 0;
            lblFeedbackTitle.Text = "Quản Lý Phản Hồi & Góp Ý Khách Hàng";
            // 
            // dgvFeedback
            // 
            dgvFeedback.AllowUserToAddRows = false;
            dgvFeedback.AllowUserToDeleteRows = false;
            dgvFeedback.BackgroundColor = Color.White;
            dgvFeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeedback.Columns.AddRange(new DataGridViewColumn[] {
            colFbId,
            colFbName,
            colFbEmail,
            colFbDate,
            colFbStatus,
            colFbMsg});
            dgvFeedback.Location = new Point(0, 60);
            dgvFeedback.Name = "dgvFeedback";
            dgvFeedback.ReadOnly = true;
            dgvFeedback.RowHeadersVisible = false;
            dgvFeedback.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFeedback.RowTemplate.Height = 35;
            dgvFeedback.Size = new Size(1000, 560);
            dgvFeedback.TabIndex = 1;
            dgvFeedback.Rows.Add("FB001", "Nguyen Van Khach", "khachhang@example.com", "11/06/2026", "Moi", "Can tu van them ve iPhone 15 Pro Max va bao hanh.");
            dgvFeedback.Rows.Add("FB002", "Le Minh Anh", "minhanh@example.com", "10/06/2026", "Da xu ly", "Shop giao hang nhanh, san pham dong goi dep.");
            dgvFeedback.Rows.Add("FB003", "Tran Hoang", "hoang@example.com", "09/06/2026", "Moi", "Muon hoi them ve chuong trinh giam gia laptop.");
            // 
            // colFbId
            // 
            colFbId.HeaderText = "Mã PH";
            colFbId.Name = "colFbId";
            colFbId.ReadOnly = true;
            colFbId.Width = 80;
            // 
            // colFbName
            // 
            colFbName.HeaderText = "Họ và Tên";
            colFbName.Name = "colFbName";
            colFbName.ReadOnly = true;
            colFbName.Width = 160;
            // 
            // colFbEmail
            // 
            colFbEmail.HeaderText = "Email";
            colFbEmail.Name = "colFbEmail";
            colFbEmail.ReadOnly = true;
            colFbEmail.Width = 160;
            // 
            // colFbDate
            // 
            colFbDate.HeaderText = "Ngày Gửi";
            colFbDate.Name = "colFbDate";
            colFbDate.ReadOnly = true;
            colFbDate.Width = 110;
            // 
            // colFbStatus
            // 
            colFbStatus.HeaderText = "Trạng Thái";
            colFbStatus.Name = "colFbStatus";
            colFbStatus.ReadOnly = true;
            colFbStatus.Width = 120;
            // 
            // colFbMsg
            // 
            colFbMsg.HeaderText = "Nội Dung Phản Hồi";
            colFbMsg.Name = "colFbMsg";
            colFbMsg.ReadOnly = true;
            colFbMsg.Width = 350;
            // 
            // panelFeedbackActions
            // 
            panelFeedbackActions.BackColor = Color.White;
            panelFeedbackActions.BorderStyle = BorderStyle.FixedSingle;
            panelFeedbackActions.Controls.Add(btnFeedbackResolve);
            panelFeedbackActions.Controls.Add(btnFeedbackDelete);
            panelFeedbackActions.Location = new Point(0, 630);
            panelFeedbackActions.Name = "panelFeedbackActions";
            panelFeedbackActions.Size = new Size(1000, 65);
            panelFeedbackActions.TabIndex = 2;
            // 
            // btnFeedbackResolve
            // 
            btnFeedbackResolve.BackColor = Color.ForestGreen;
            btnFeedbackResolve.FlatAppearance.BorderSize = 0;
            btnFeedbackResolve.FlatStyle = FlatStyle.Flat;
            btnFeedbackResolve.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnFeedbackResolve.ForeColor = Color.White;
            btnFeedbackResolve.Location = new Point(15, 12);
            btnFeedbackResolve.Name = "btnFeedbackResolve";
            btnFeedbackResolve.Size = new Size(220, 40);
            btnFeedbackResolve.TabIndex = 0;
            btnFeedbackResolve.Text = "✓ Đánh Dấu Đã Giải Quyết";
            btnFeedbackResolve.UseVisualStyleBackColor = false;
            // 
            // btnFeedbackDelete
            // 
            btnFeedbackDelete.BackColor = Color.Red;
            btnFeedbackDelete.FlatAppearance.BorderSize = 0;
            btnFeedbackDelete.FlatStyle = FlatStyle.Flat;
            btnFeedbackDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnFeedbackDelete.ForeColor = Color.White;
            btnFeedbackDelete.Location = new Point(805, 12);
            btnFeedbackDelete.Name = "btnFeedbackDelete";
            btnFeedbackDelete.Size = new Size(180, 40);
            btnFeedbackDelete.TabIndex = 1;
            btnFeedbackDelete.Text = "🗑️ Xóa Phản Hồi";
            btnFeedbackDelete.UseVisualStyleBackColor = false;

            // 
            // panelSettings
            // 
            panelSettings.Controls.Add(panelSettingsHeader);
            panelSettings.Controls.Add(panelSettingsBody);
            panelSettings.Dock = DockStyle.Fill;
            panelSettings.Location = new Point(20, 20);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(1000, 710);
            panelSettings.TabIndex = 6;
            panelSettings.Visible = false;
            // 
            // panelSettingsHeader
            // 
            panelSettingsHeader.Controls.Add(lblSettingsTitle);
            panelSettingsHeader.Dock = DockStyle.Top;
            panelSettingsHeader.Location = new Point(0, 0);
            panelSettingsHeader.Name = "panelSettingsHeader";
            panelSettingsHeader.Size = new Size(1000, 50);
            panelSettingsHeader.TabIndex = 0;
            // 
            // lblSettingsTitle
            // 
            lblSettingsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSettingsTitle.ForeColor = Color.DarkBlue;
            lblSettingsTitle.Location = new Point(0, 5);
            lblSettingsTitle.Name = "lblSettingsTitle";
            lblSettingsTitle.Size = new Size(400, 30);
            lblSettingsTitle.TabIndex = 0;
            lblSettingsTitle.Text = "Cấu Hình Hệ Thống Cửa Hàng";
            // 
            // panelSettingsBody
            // 
            panelSettingsBody.BackColor = Color.White;
            panelSettingsBody.BorderStyle = BorderStyle.FixedSingle;
            panelSettingsBody.Controls.Add(lblSettingsStoreName);
            panelSettingsBody.Controls.Add(txtSettingsStoreName);
            panelSettingsBody.Controls.Add(lblSettingsHotline);
            panelSettingsBody.Controls.Add(txtSettingsHotline);
            panelSettingsBody.Controls.Add(lblSettingsEmail);
            panelSettingsBody.Controls.Add(txtSettingsEmail);
            panelSettingsBody.Controls.Add(lblSettingsAddress);
            panelSettingsBody.Controls.Add(txtSettingsAddress);
            panelSettingsBody.Controls.Add(chkSettingsMaintenance);
            panelSettingsBody.Controls.Add(btnSettingsSave);
            panelSettingsBody.Location = new Point(0, 60);
            panelSettingsBody.Name = "panelSettingsBody";
            panelSettingsBody.Size = new Size(1000, 635);
            panelSettingsBody.TabIndex = 1;
            // 
            // lblSettingsStoreName
            // 
            lblSettingsStoreName.Location = new Point(30, 40);
            lblSettingsStoreName.Size = new Size(200, 25);
            lblSettingsStoreName.Text = "Tên Cửa Hàng:";
            lblSettingsStoreName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // txtSettingsStoreName
            // 
            txtSettingsStoreName.Location = new Point(250, 37);
            txtSettingsStoreName.Size = new Size(600, 27);
            txtSettingsStoreName.Font = new Font("Segoe UI", 10F);
            txtSettingsStoreName.Text = "TechStore";
            // 
            // lblSettingsHotline
            // 
            lblSettingsHotline.Location = new Point(30, 100);
            lblSettingsHotline.Size = new Size(200, 25);
            lblSettingsHotline.Text = "Số Hotline Hỗ Trợ:";
            lblSettingsHotline.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // txtSettingsHotline
            // 
            txtSettingsHotline.Location = new Point(250, 97);
            txtSettingsHotline.Size = new Size(600, 27);
            txtSettingsHotline.Font = new Font("Segoe UI", 10F);
            txtSettingsHotline.Text = "1900-1234";
            // 
            // lblSettingsEmail
            // 
            lblSettingsEmail.Location = new Point(30, 160);
            lblSettingsEmail.Size = new Size(200, 25);
            lblSettingsEmail.Text = "Email Chăm Sóc Khách Hàng:";
            lblSettingsEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // txtSettingsEmail
            // 
            txtSettingsEmail.Location = new Point(250, 157);
            txtSettingsEmail.Size = new Size(600, 27);
            txtSettingsEmail.Font = new Font("Segoe UI", 10F);
            txtSettingsEmail.Text = "support@techstore.com";
            // 
            // lblSettingsAddress
            // 
            lblSettingsAddress.Location = new Point(30, 220);
            lblSettingsAddress.Size = new Size(200, 25);
            lblSettingsAddress.Text = "Địa Chỉ Trụ Sở Cửa Hàng:";
            lblSettingsAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            // 
            // txtSettingsAddress
            // 
            txtSettingsAddress.Location = new Point(250, 217);
            txtSettingsAddress.Size = new Size(600, 27);
            txtSettingsAddress.Font = new Font("Segoe UI", 10F);
            txtSettingsAddress.Text = "123 Duong Le Loi, Quan 1, TP. Ho Chi Minh";
            // 
            // chkSettingsMaintenance
            // 
            chkSettingsMaintenance.Location = new Point(250, 280);
            chkSettingsMaintenance.Size = new Size(400, 30);
            chkSettingsMaintenance.Text = "Bật Chế Độ Bảo Trì Hệ Thống (Khóa tính năng Khách Hàng)";
            chkSettingsMaintenance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkSettingsMaintenance.ForeColor = Color.Red;
            // 
            // btnSettingsSave
            // 
            btnSettingsSave.BackColor = Color.RoyalBlue;
            btnSettingsSave.FlatAppearance.BorderSize = 0;
            btnSettingsSave.FlatStyle = FlatStyle.Flat;
            btnSettingsSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSettingsSave.ForeColor = Color.White;
            btnSettingsSave.Location = new Point(250, 340);
            btnSettingsSave.Name = "btnSettingsSave";
            btnSettingsSave.Size = new Size(220, 45);
            btnSettingsSave.TabIndex = 8;
            btnSettingsSave.Text = "💾 Lưu Cấu Hình Hệ Thống";
            btnSettingsSave.UseVisualStyleBackColor = false;

            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1280, 750);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 9.5F);
            ForeColor = Color.Black;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechStore - Bảng Quản Trị Hệ Thống";
            panelSidebar.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelDashboard.ResumeLayout(false);
            panelAdminMetricsLayout.ResumeLayout(false);
            cardRevenue.ResumeLayout(false);
            cardOrders.ResumeLayout(false);
            cardLowStock.ResumeLayout(false);
            cardTotalProd.ResumeLayout(false);
            panelAdminChartCard.ResumeLayout(false);
            panelChart.ResumeLayout(false);
            panelInventory.ResumeLayout(false);
            panelInventoryHeader.ResumeLayout(false);
            panelInventoryHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panelOrders.ResumeLayout(false);
            panelOrdersHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            panelOrdersActions.ResumeLayout(false);
            panelUsers.ResumeLayout(false);
            panelUsersHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panelUsersActions.ResumeLayout(false);

            panelVouchers.ResumeLayout(false);
            panelVouchersHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVouchers).EndInit();
            panelVouchersActions.ResumeLayout(false);
            panelVouchersActions.PerformLayout();
            panelFeedback.ResumeLayout(false);
            panelFeedbackHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFeedback).EndInit();
            panelFeedbackActions.ResumeLayout(false);
            panelSettings.ResumeLayout(false);
            panelSettingsHeader.ResumeLayout(false);
            panelSettingsBody.ResumeLayout(false);
            panelSettingsBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label lblLogo;
        private Label lblUserInfo;
        private Label lblUserRole;
        private Panel line1;
        private Button btnMenuDashboard;
        private Button btnMenuInventory;
        private Button btnMenuOrders;
        private Button btnMenuUsers;
        private Panel line2;
        private Button btnMenuLogout;
        private Panel panelContent;

        // 1. Dashboard Controls
        private Panel panelDashboard;
        private Label lblDashboardHeader;
        private TableLayoutPanel panelAdminMetricsLayout;
        private Panel cardRevenue;
        private Label lblTitleRev;
        private Label lblStatRevenue;
        private Panel cardOrders;
        private Label lblTitleOrd;
        private Label lblStatOrders;
        private Panel cardLowStock;
        private Label lblTitleLow;
        private Label lblStatLowStock;
        private Panel cardTotalProd;
        private Label lblTitleTot;
        private Label lblStatTotalProducts;
        private Panel panelAdminChartCard;
        private Label lblAdminChartTitle;
        private Panel panelChart;
        private ListBox lstSalesHistory;
        private Panel panelPieChart;
        private Panel panelRevenueChart;
        private PictureBox pbPieChartMock;
        private PictureBox pbRevenueChartMock;

        // 2. Inventory Controls
        private Panel panelInventory;
        private Panel panelInventoryHeader;
        private Label lblInventoryTitle;
        private TextBox txtAdminSearch;
        private Button btnAdminAddProduct;
        private DataGridView dgvInventory;
        private DataGridViewTextBoxColumn colInvId;
        private DataGridViewTextBoxColumn colInvName;
        private DataGridViewTextBoxColumn colInvCategory;
        private DataGridViewTextBoxColumn colInvPrice;
        private DataGridViewTextBoxColumn colInvStock;
        private DataGridViewTextBoxColumn colInvStatus;
        private DataGridViewButtonColumn colInvEdit;
        private DataGridViewButtonColumn colInvDelete;

        // 3. Orders Controls
        private Panel panelOrders;
        private Panel panelOrdersHeader;
        private Label lblOrdersTitle;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn colOrdId;
        private DataGridViewTextBoxColumn colOrdDate;
        private DataGridViewTextBoxColumn colOrdCustomer;
        private DataGridViewTextBoxColumn colOrdTotal;
        private DataGridViewTextBoxColumn colOrdStatus;
        private DataGridViewTextBoxColumn colOrdUserRef;
        private Panel panelOrdersActions;
        private Button btnOrderDetails;
        private Button btnOrderShipping;
        private Button btnOrderComplete;
        private Button btnOrderCancel;

        // 4. Users Controls
        private Panel panelUsers;
        private Panel panelUsersHeader;
        private Label lblUsersTitle;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn colUsrUsername;
        private DataGridViewTextBoxColumn colUsrFullName;
        private DataGridViewTextBoxColumn colUsrPhone;
        private DataGridViewTextBoxColumn colUsrAddress;
        private DataGridViewTextBoxColumn colUsrRole;
        private Panel panelUsersActions;
        private Button btnMakeAdmin;
        private Button btnMakeCustomer;
        private Button btnDeleteUser;

        // 5. Vouchers Controls
        private Button btnMenuVouchers;
        private Panel panelVouchers;
        private Panel panelVouchersHeader;
        private Label lblVouchersTitle;
        private DataGridView dgvVouchers;
        private DataGridViewTextBoxColumn colVchCode;
        private DataGridViewTextBoxColumn colVchDesc;
        private DataGridViewTextBoxColumn colVchPercent;
        private DataGridViewTextBoxColumn colVchMax;
        private Panel panelVouchersActions;
        private Label lblVchCode;
        private TextBox txtVchCode;
        private Label lblVchDesc;
        private TextBox txtVchDesc;
        private Label lblVchPercent;
        private TextBox txtVchPercent;
        private Label lblVchMax;
        private TextBox txtVchMax;
        private Button btnVchAdd;
        private Button btnVchDelete;

        // 6. Feedback Controls
        private Button btnMenuFeedback;
        private Panel panelFeedback;
        private Panel panelFeedbackHeader;
        private Label lblFeedbackTitle;
        private DataGridView dgvFeedback;
        private DataGridViewTextBoxColumn colFbId;
        private DataGridViewTextBoxColumn colFbName;
        private DataGridViewTextBoxColumn colFbEmail;
        private DataGridViewTextBoxColumn colFbDate;
        private DataGridViewTextBoxColumn colFbStatus;
        private DataGridViewTextBoxColumn colFbMsg;
        private Panel panelFeedbackActions;
        private Button btnFeedbackResolve;
        private Button btnFeedbackDelete;

        // 7. Settings Controls
        private Button btnMenuSettings;
        private Panel panelSettings;
        private Panel panelSettingsHeader;
        private Label lblSettingsTitle;
        private Panel panelSettingsBody;
        private Label lblSettingsStoreName;
        private TextBox txtSettingsStoreName;
        private Label lblSettingsHotline;
        private TextBox txtSettingsHotline;
        private Label lblSettingsEmail;
        private TextBox txtSettingsEmail;
        private Label lblSettingsAddress;
        private TextBox txtSettingsAddress;
        private CheckBox chkSettingsMaintenance;
        private Button btnSettingsSave;
    }
}
