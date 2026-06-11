using System;
using System.Drawing;
using System.Windows.Forms;

namespace TechStoreWinApp
{
    partial class MainForm
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
            btnMenuHome = new Button();
            btnMenuApple = new Button();
            btnMenuSamsung = new Button();
            btnMenuXiaomi = new Button();
            btnMenuWatches = new Button();
            btnMenuAccessories = new Button();
            btnMenuCart = new Button();
            btnMenuProfile = new Button();
            line2 = new Panel();
            btnMenuAdmin = new Button();
            btnMenuLogout = new Button();
            panelContent = new Panel();
            panelHome = new Panel();
            panelHomeHero = new Panel();
            lblHomeHeroTitle = new Label();
            lblHomeHeroSub = new Label();
            lblHomeFeaturedHeader = new Label();
            flpHomeFeatured = new FlowLayoutPanel();
            panelShop = new Panel();
            lblCategoryTitle = new Label();
            txtCustomerSearch = new TextBox();
            flpProducts = new FlowLayoutPanel();
            panelCartView = new Panel();
            lblCartTitle = new Label();
            panelCartLeftCol = new Panel();
            lblCartLeftTitle = new Label();
            flpCartLines = new FlowLayoutPanel();
            lblCartTotalAmount = new Label();
            panelCartRightCol = new Panel();
            lblCartRightTitle = new Label();
            lblCartCheckoutName = new Label();
            txtCheckoutName = new TextBox();
            lblCartCheckoutPhone = new Label();
            txtCheckoutPhone = new TextBox();
            lblCartCheckoutAddress = new Label();
            txtCheckoutAddress = new TextBox();
            lblCartCheckoutPayment = new Label();
            cbCheckoutPayment = new ComboBox();
            btnPlaceOrderSubmit = new Button();
            panelProfile = new Panel();
            lblProfileTitle = new Label();
            panelProfileLeftCol = new Panel();
            lblProfileLeftTitle = new Label();
            lblProfUsername = new Label();
            lblProfileFullName = new Label();
            txtProfFullName = new TextBox();
            lblProfilePhone = new Label();
            txtProfPhone = new TextBox();
            lblProfileAddress = new Label();
            txtProfAddress = new TextBox();
            btnProfileSave = new Button();
            panelProfileRightCol = new Panel();
            lblProfileRightTitle = new Label();
            lstOrderHistory = new ListBox();
            panelAdmin = new Panel();
            panelAdminTitleRow = new Panel();
            lblAdminTitle = new Label();
            btnAdminAddProduct = new Button();
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
            panelAdminDataLayout = new TableLayoutPanel();
            panelAdminChartCard = new Panel();
            lblAdminChartTitle = new Label();
            panelChart = new Panel();
            panelAdminInfoCard = new Panel();
            lblAdminInfoTitle = new Label();
            lblAdminStatusDB = new Label();
            lblAdminStatusSync = new Label();
            lblAdminStatusOnline = new Label();
            txtAdminInfoNote = new TextBox();
            panelAdminTableCard = new Panel();
            panelAdminTableHeaderRow = new Panel();
            lblAdminTableTitle = new Label();
            txtAdminSearch = new TextBox();
            dgvInventory = new DataGridView();
            panelSidebar.SuspendLayout();
            panelContent.SuspendLayout();
            panelHome.SuspendLayout();
            panelHomeHero.SuspendLayout();
            panelShop.SuspendLayout();
            panelCartView.SuspendLayout();
            panelCartLeftCol.SuspendLayout();
            panelCartRightCol.SuspendLayout();
            panelProfile.SuspendLayout();
            panelProfileLeftCol.SuspendLayout();
            panelProfileRightCol.SuspendLayout();
            panelAdmin.SuspendLayout();
            panelAdminTitleRow.SuspendLayout();
            panelAdminMetricsLayout.SuspendLayout();
            cardRevenue.SuspendLayout();
            cardOrders.SuspendLayout();
            cardLowStock.SuspendLayout();
            cardTotalProd.SuspendLayout();
            panelAdminDataLayout.SuspendLayout();
            panelAdminChartCard.SuspendLayout();
            panelAdminInfoCard.SuspendLayout();
            panelAdminTableCard.SuspendLayout();
            panelAdminTableHeaderRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(21, 28, 44);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Controls.Add(lblUserInfo);
            panelSidebar.Controls.Add(lblUserRole);
            panelSidebar.Controls.Add(line1);
            panelSidebar.Controls.Add(btnMenuHome);
            panelSidebar.Controls.Add(btnMenuApple);
            panelSidebar.Controls.Add(btnMenuSamsung);
            panelSidebar.Controls.Add(btnMenuXiaomi);
            panelSidebar.Controls.Add(btnMenuWatches);
            panelSidebar.Controls.Add(btnMenuAccessories);
            panelSidebar.Controls.Add(btnMenuCart);
            panelSidebar.Controls.Add(btnMenuProfile);
            panelSidebar.Controls.Add(line2);
            panelSidebar.Controls.Add(btnMenuAdmin);
            panelSidebar.Controls.Add(btnMenuLogout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(10);
            panelSidebar.Size = new Size(240, 781);
            panelSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(15, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(210, 30);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "⚡ TechStore";
            // 
            // lblUserInfo
            // 
            lblUserInfo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUserInfo.ForeColor = Color.FromArgb(6, 182, 212);
            lblUserInfo.Location = new Point(15, 65);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(210, 20);
            lblUserInfo.TabIndex = 1;
            lblUserInfo.Text = "Xin chào, Khách";
            // 
            // lblUserRole
            // 
            lblUserRole.Font = new Font("Segoe UI", 8F);
            lblUserRole.ForeColor = Color.FromArgb(148, 163, 184);
            lblUserRole.Location = new Point(15, 85);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(210, 15);
            lblUserRole.TabIndex = 2;
            lblUserRole.Text = "Vai trò: Khách hàng";
            // 
            // line1
            // 
            line1.BackColor = Color.FromArgb(40, 50, 70);
            line1.Location = new Point(15, 110);
            line1.Name = "line1";
            line1.Size = new Size(210, 1);
            line1.TabIndex = 3;
            // 
            // btnMenuHome
            // 
            btnMenuHome.BackColor = Color.Transparent;
            btnMenuHome.FlatAppearance.BorderSize = 0;
            btnMenuHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnMenuHome.FlatStyle = FlatStyle.Flat;
            btnMenuHome.Font = new Font("Segoe UI", 9.5F);
            btnMenuHome.ForeColor = Color.FromArgb(248, 250, 252);
            btnMenuHome.Location = new Point(15, 125);
            btnMenuHome.Name = "btnMenuHome";
            btnMenuHome.Padding = new Padding(10, 0, 0, 0);
            btnMenuHome.Size = new Size(210, 40);
            btnMenuHome.TabIndex = 4;
            btnMenuHome.Text = " ";
            btnMenuHome.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuHome.UseVisualStyleBackColor = false;
            // 
            // btnMenuApple
            // 
            btnMenuApple.BackColor = Color.Transparent;
            btnMenuApple.FlatAppearance.BorderSize = 0;
            btnMenuApple.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnMenuApple.FlatStyle = FlatStyle.Flat;
            btnMenuApple.Font = new Font("Segoe UI", 9.5F);
            btnMenuApple.ForeColor = Color.FromArgb(248, 250, 252);
            btnMenuApple.Location = new Point(15, 173);
            btnMenuApple.Name = "btnMenuApple";
            btnMenuApple.Padding = new Padding(10, 0, 0, 0);
            btnMenuApple.Size = new Size(210, 40);
            btnMenuApple.TabIndex = 5;
            btnMenuApple.Text = "🍏 Điện thoại Apple";
            btnMenuApple.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuApple.UseVisualStyleBackColor = false;
            // 
            // btnMenuSamsung
            // 
            btnMenuSamsung.BackColor = Color.Transparent;
            btnMenuSamsung.FlatAppearance.BorderSize = 0;
            btnMenuSamsung.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnMenuSamsung.FlatStyle = FlatStyle.Flat;
            btnMenuSamsung.Font = new Font("Segoe UI", 9.5F);
            btnMenuSamsung.ForeColor = Color.FromArgb(248, 250, 252);
            btnMenuSamsung.Location = new Point(15, 221);
            btnMenuSamsung.Name = "btnMenuSamsung";
            btnMenuSamsung.Padding = new Padding(10, 0, 0, 0);
            btnMenuSamsung.Size = new Size(210, 40);
            btnMenuSamsung.TabIndex = 6;
            btnMenuSamsung.Text = "📱 Điện thoại Samsung";
            btnMenuSamsung.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuSamsung.UseVisualStyleBackColor = false;
            // 
            // btnMenuXiaomi
            // 
            btnMenuXiaomi.BackColor = Color.Transparent;
            btnMenuXiaomi.FlatAppearance.BorderSize = 0;
            btnMenuXiaomi.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnMenuXiaomi.FlatStyle = FlatStyle.Flat;
            btnMenuXiaomi.Font = new Font("Segoe UI", 9.5F);
            btnMenuXiaomi.ForeColor = Color.FromArgb(248, 250, 252);
            btnMenuXiaomi.Location = new Point(15, 269);
            btnMenuXiaomi.Name = "btnMenuXiaomi";
            btnMenuXiaomi.Padding = new Padding(10, 0, 0, 0);
            btnMenuXiaomi.Size = new Size(210, 40);
            btnMenuXiaomi.TabIndex = 7;
            btnMenuXiaomi.Text = "💎 Điện thoại Xiaomi";
            btnMenuXiaomi.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuXiaomi.UseVisualStyleBackColor = false;
            // 
            // btnMenuWatches
            // 
            btnMenuWatches.BackColor = Color.Transparent;
            btnMenuWatches.FlatAppearance.BorderSize = 0;
            btnMenuWatches.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnMenuWatches.FlatStyle = FlatStyle.Flat;
            btnMenuWatches.Font = new Font("Segoe UI", 9.5F);
            btnMenuWatches.ForeColor = Color.FromArgb(248, 250, 252);
            btnMenuWatches.Location = new Point(15, 317);
            btnMenuWatches.Name = "btnMenuWatches";
            btnMenuWatches.Padding = new Padding(10, 0, 0, 0);
            btnMenuWatches.Size = new Size(210, 40);
            btnMenuWatches.TabIndex = 8;
            btnMenuWatches.Text = "⌚ Đồng hồ thông minh";
            btnMenuWatches.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuWatches.UseVisualStyleBackColor = false;
            // 
            // btnMenuAccessories
            // 
            btnMenuAccessories.BackColor = Color.Transparent;
            btnMenuAccessories.FlatAppearance.BorderSize = 0;
            btnMenuAccessories.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnMenuAccessories.FlatStyle = FlatStyle.Flat;
            btnMenuAccessories.Font = new Font("Segoe UI", 9.5F);
            btnMenuAccessories.ForeColor = Color.FromArgb(248, 250, 252);
            btnMenuAccessories.Location = new Point(15, 365);
            btnMenuAccessories.Name = "btnMenuAccessories";
            btnMenuAccessories.Padding = new Padding(10, 0, 0, 0);
            btnMenuAccessories.Size = new Size(210, 40);
            btnMenuAccessories.TabIndex = 9;
            btnMenuAccessories.Text = "🎧 Tai nghe & Phụ kiện";
            btnMenuAccessories.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuAccessories.UseVisualStyleBackColor = false;
            // 
            // btnMenuCart
            // 
            btnMenuCart.BackColor = Color.Transparent;
            btnMenuCart.FlatAppearance.BorderSize = 0;
            btnMenuCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnMenuCart.FlatStyle = FlatStyle.Flat;
            btnMenuCart.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnMenuCart.ForeColor = Color.FromArgb(248, 250, 252);
            btnMenuCart.Location = new Point(15, 413);
            btnMenuCart.Name = "btnMenuCart";
            btnMenuCart.Padding = new Padding(10, 0, 0, 0);
            btnMenuCart.Size = new Size(210, 40);
            btnMenuCart.TabIndex = 10;
            btnMenuCart.Text = "\U0001f6d2 Giỏ Hàng (0)";
            btnMenuCart.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuCart.UseVisualStyleBackColor = false;
            // 
            // btnMenuProfile
            // 
            btnMenuProfile.BackColor = Color.Transparent;
            btnMenuProfile.FlatAppearance.BorderSize = 0;
            btnMenuProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnMenuProfile.FlatStyle = FlatStyle.Flat;
            btnMenuProfile.Font = new Font("Segoe UI", 9.5F);
            btnMenuProfile.ForeColor = Color.FromArgb(248, 250, 252);
            btnMenuProfile.Location = new Point(15, 461);
            btnMenuProfile.Name = "btnMenuProfile";
            btnMenuProfile.Padding = new Padding(10, 0, 0, 0);
            btnMenuProfile.Size = new Size(210, 40);
            btnMenuProfile.TabIndex = 11;
            btnMenuProfile.Text = "👤 Hồ Sơ Cá Nhân";
            btnMenuProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuProfile.UseVisualStyleBackColor = false;
            // 
            // line2
            // 
            line2.BackColor = Color.FromArgb(40, 50, 70);
            line2.Location = new Point(15, 509);
            line2.Name = "line2";
            line2.Size = new Size(210, 1);
            line2.TabIndex = 12;
            // 
            // btnMenuAdmin
            // 
            btnMenuAdmin.BackColor = Color.Transparent;
            btnMenuAdmin.FlatAppearance.BorderSize = 0;
            btnMenuAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnMenuAdmin.FlatStyle = FlatStyle.Flat;
            btnMenuAdmin.Font = new Font("Segoe UI", 9.5F);
            btnMenuAdmin.ForeColor = Color.FromArgb(6, 182, 212);
            btnMenuAdmin.Location = new Point(15, 519);
            btnMenuAdmin.Name = "btnMenuAdmin";
            btnMenuAdmin.Padding = new Padding(10, 0, 0, 0);
            btnMenuAdmin.Size = new Size(210, 40);
            btnMenuAdmin.TabIndex = 13;
            btnMenuAdmin.Text = "⚙️ Quản Trị Admin";
            btnMenuAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuAdmin.UseVisualStyleBackColor = false;
            btnMenuAdmin.Visible = false;
            // 
            // btnMenuLogout
            // 
            btnMenuLogout.BackColor = Color.Transparent;
            btnMenuLogout.Dock = DockStyle.Bottom;
            btnMenuLogout.FlatAppearance.BorderSize = 0;
            btnMenuLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59);
            btnMenuLogout.FlatStyle = FlatStyle.Flat;
            btnMenuLogout.Font = new Font("Segoe UI", 9.5F);
            btnMenuLogout.ForeColor = Color.FromArgb(239, 68, 68);
            btnMenuLogout.Location = new Point(10, 731);
            btnMenuLogout.Name = "btnMenuLogout";
            btnMenuLogout.Padding = new Padding(10, 0, 0, 0);
            btnMenuLogout.Size = new Size(220, 40);
            btnMenuLogout.TabIndex = 14;
            btnMenuLogout.Text = "🚪 Đăng Xuất";
            btnMenuLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuLogout.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(11, 15, 25);
            panelContent.Controls.Add(panelHome);
            panelContent.Controls.Add(panelShop);
            panelContent.Controls.Add(panelCartView);
            panelContent.Controls.Add(panelProfile);
            panelContent.Controls.Add(panelAdmin);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(240, 0);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(1044, 781);
            panelContent.TabIndex = 1;
            // 
            // panelHome
            // 
            panelHome.AutoScroll = true;
            panelHome.BackColor = Color.FromArgb(11, 15, 25);
            panelHome.Controls.Add(panelHomeHero);
            panelHome.Controls.Add(lblHomeFeaturedHeader);
            panelHome.Controls.Add(flpHomeFeatured);
            panelHome.Dock = DockStyle.Fill;
            panelHome.Location = new Point(20, 20);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1004, 741);
            panelHome.TabIndex = 0;
            panelHome.Visible = false;
            // 
            // panelHomeHero
            // 
            panelHomeHero.BackColor = Color.FromArgb(21, 28, 44);
            panelHomeHero.Controls.Add(lblHomeHeroTitle);
            panelHomeHero.Controls.Add(lblHomeHeroSub);
            panelHomeHero.Location = new Point(0, 0);
            panelHomeHero.Name = "panelHomeHero";
            panelHomeHero.Size = new Size(1000, 160);
            panelHomeHero.TabIndex = 0;
            panelHomeHero.Paint += PanelHomeHero_Paint;
            // 
            // lblHomeHeroTitle
            // 
            lblHomeHeroTitle.AutoSize = true;
            lblHomeHeroTitle.BackColor = Color.Transparent;
            lblHomeHeroTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHomeHeroTitle.ForeColor = Color.White;
            lblHomeHeroTitle.Location = new Point(30, 25);
            lblHomeHeroTitle.Name = "lblHomeHeroTitle";
            lblHomeHeroTitle.Size = new Size(446, 37);
            lblHomeHeroTitle.TabIndex = 0;
            lblHomeHeroTitle.Text = "⚡ Siêu Thị Công Nghệ TechStore";
            // 
            // lblHomeHeroSub
            // 
            lblHomeHeroSub.BackColor = Color.Transparent;
            lblHomeHeroSub.Font = new Font("Segoe UI", 10F);
            lblHomeHeroSub.ForeColor = Color.FromArgb(240, 240, 240);
            lblHomeHeroSub.Location = new Point(30, 75);
            lblHomeHeroSub.Name = "lblHomeHeroSub";
            lblHomeHeroSub.Size = new Size(900, 45);
            lblHomeHeroSub.TabIndex = 1;
            lblHomeHeroSub.Text = "Chào mừng quý khách! Khám phá các mẫu điện thoại Apple, Samsung, Xiaomi mới nhất cùng vô số phụ kiện chính hãng.";
            // 
            // lblHomeFeaturedHeader
            // 
            lblHomeFeaturedHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHomeFeaturedHeader.ForeColor = Color.White;
            lblHomeFeaturedHeader.Location = new Point(0, 190);
            lblHomeFeaturedHeader.Name = "lblHomeFeaturedHeader";
            lblHomeFeaturedHeader.Size = new Size(400, 25);
            lblHomeFeaturedHeader.TabIndex = 1;
            lblHomeFeaturedHeader.Text = "SẢN PHẨM KHUYẾN MÃI NỔI BẬT";
            // 
            // flpHomeFeatured
            // 
            flpHomeFeatured.AutoScroll = true;
            flpHomeFeatured.Location = new Point(0, 230);
            flpHomeFeatured.Name = "flpHomeFeatured";
            flpHomeFeatured.Padding = new Padding(0, 0, 0, 10);
            flpHomeFeatured.Size = new Size(1000, 480);
            flpHomeFeatured.TabIndex = 2;
            // 
            // panelShop
            // 
            panelShop.BackColor = Color.FromArgb(11, 15, 25);
            panelShop.Controls.Add(lblCategoryTitle);
            panelShop.Controls.Add(txtCustomerSearch);
            panelShop.Controls.Add(flpProducts);
            panelShop.Dock = DockStyle.Fill;
            panelShop.Location = new Point(20, 20);
            panelShop.Name = "panelShop";
            panelShop.Size = new Size(1004, 741);
            panelShop.TabIndex = 1;
            panelShop.Visible = false;
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCategoryTitle.ForeColor = Color.White;
            lblCategoryTitle.Location = new Point(0, 0);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(400, 35);
            lblCategoryTitle.TabIndex = 0;
            lblCategoryTitle.Text = "Cửa Hàng";
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.BackColor = Color.FromArgb(21, 28, 44);
            txtCustomerSearch.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerSearch.ForeColor = Color.White;
            txtCustomerSearch.Location = new Point(750, 5);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.PlaceholderText = "Tìm kiếm sản phẩm...";
            txtCustomerSearch.Size = new Size(250, 24);
            txtCustomerSearch.TabIndex = 1;
            txtCustomerSearch.TextChanged += TxtCustomerSearch_TextChanged;
            // 
            // flpProducts
            // 
            flpProducts.AutoScroll = true;
            flpProducts.Location = new Point(0, 50);
            flpProducts.Name = "flpProducts";
            flpProducts.Padding = new Padding(0, 10, 0, 10);
            flpProducts.Size = new Size(1000, 680);
            flpProducts.TabIndex = 2;
            // 
            // panelCartView
            // 
            panelCartView.BackColor = Color.FromArgb(11, 15, 25);
            panelCartView.Controls.Add(lblCartTitle);
            panelCartView.Controls.Add(panelCartLeftCol);
            panelCartView.Controls.Add(panelCartRightCol);
            panelCartView.Dock = DockStyle.Fill;
            panelCartView.Location = new Point(20, 20);
            panelCartView.Name = "panelCartView";
            panelCartView.Size = new Size(1004, 741);
            panelCartView.TabIndex = 2;
            panelCartView.Visible = false;
            // 
            // lblCartTitle
            // 
            lblCartTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCartTitle.ForeColor = Color.White;
            lblCartTitle.Location = new Point(0, 0);
            lblCartTitle.Name = "lblCartTitle";
            lblCartTitle.Size = new Size(500, 35);
            lblCartTitle.TabIndex = 0;
            lblCartTitle.Text = "Giỏ Hàng & Thanh Toán Đơn Hàng";
            // 
            // panelCartLeftCol
            // 
            panelCartLeftCol.BackColor = Color.FromArgb(21, 28, 44);
            panelCartLeftCol.Controls.Add(lblCartLeftTitle);
            panelCartLeftCol.Controls.Add(flpCartLines);
            panelCartLeftCol.Controls.Add(lblCartTotalAmount);
            panelCartLeftCol.Location = new Point(0, 50);
            panelCartLeftCol.Name = "panelCartLeftCol";
            panelCartLeftCol.Padding = new Padding(15);
            panelCartLeftCol.Size = new Size(580, 680);
            panelCartLeftCol.TabIndex = 1;
            // 
            // lblCartLeftTitle
            // 
            lblCartLeftTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCartLeftTitle.ForeColor = Color.White;
            lblCartLeftTitle.Location = new Point(15, 15);
            lblCartLeftTitle.Name = "lblCartLeftTitle";
            lblCartLeftTitle.Size = new Size(200, 20);
            lblCartLeftTitle.TabIndex = 0;
            lblCartLeftTitle.Text = "DANH SÁCH GIỎ HÀNG";
            // 
            // flpCartLines
            // 
            flpCartLines.AutoScroll = true;
            flpCartLines.Location = new Point(15, 45);
            flpCartLines.Name = "flpCartLines";
            flpCartLines.Size = new Size(550, 540);
            flpCartLines.TabIndex = 1;
            // 
            // lblCartTotalAmount
            // 
            lblCartTotalAmount.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCartTotalAmount.ForeColor = Color.FromArgb(6, 182, 212);
            lblCartTotalAmount.Location = new Point(15, 600);
            lblCartTotalAmount.Name = "lblCartTotalAmount";
            lblCartTotalAmount.Size = new Size(550, 30);
            lblCartTotalAmount.TabIndex = 2;
            lblCartTotalAmount.Text = "Tổng phụ: 0 ₫";
            lblCartTotalAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelCartRightCol
            // 
            panelCartRightCol.BackColor = Color.FromArgb(21, 28, 44);
            panelCartRightCol.Controls.Add(lblCartRightTitle);
            panelCartRightCol.Controls.Add(lblCartCheckoutName);
            panelCartRightCol.Controls.Add(txtCheckoutName);
            panelCartRightCol.Controls.Add(lblCartCheckoutPhone);
            panelCartRightCol.Controls.Add(txtCheckoutPhone);
            panelCartRightCol.Controls.Add(lblCartCheckoutAddress);
            panelCartRightCol.Controls.Add(txtCheckoutAddress);
            panelCartRightCol.Controls.Add(lblCartCheckoutPayment);
            panelCartRightCol.Controls.Add(cbCheckoutPayment);
            panelCartRightCol.Controls.Add(btnPlaceOrderSubmit);
            panelCartRightCol.Location = new Point(600, 50);
            panelCartRightCol.Name = "panelCartRightCol";
            panelCartRightCol.Padding = new Padding(20);
            panelCartRightCol.Size = new Size(400, 680);
            panelCartRightCol.TabIndex = 2;
            // 
            // lblCartRightTitle
            // 
            lblCartRightTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCartRightTitle.ForeColor = Color.White;
            lblCartRightTitle.Location = new Point(20, 15);
            lblCartRightTitle.Name = "lblCartRightTitle";
            lblCartRightTitle.Size = new Size(200, 20);
            lblCartRightTitle.TabIndex = 0;
            lblCartRightTitle.Text = "THÔNG TIN GIAO HÀNG";
            // 
            // lblCartCheckoutName
            // 
            lblCartCheckoutName.ForeColor = Color.FromArgb(148, 163, 184);
            lblCartCheckoutName.Location = new Point(20, 55);
            lblCartCheckoutName.Name = "lblCartCheckoutName";
            lblCartCheckoutName.Size = new Size(360, 18);
            lblCartCheckoutName.TabIndex = 1;
            lblCartCheckoutName.Text = "Họ và Tên *";
            // 
            // txtCheckoutName
            // 
            txtCheckoutName.BackColor = Color.FromArgb(11, 15, 25);
            txtCheckoutName.BorderStyle = BorderStyle.FixedSingle;
            txtCheckoutName.ForeColor = Color.White;
            txtCheckoutName.Location = new Point(20, 75);
            txtCheckoutName.Name = "txtCheckoutName";
            txtCheckoutName.Size = new Size(360, 24);
            txtCheckoutName.TabIndex = 2;
            // 
            // lblCartCheckoutPhone
            // 
            lblCartCheckoutPhone.ForeColor = Color.FromArgb(148, 163, 184);
            lblCartCheckoutPhone.Location = new Point(20, 120);
            lblCartCheckoutPhone.Name = "lblCartCheckoutPhone";
            lblCartCheckoutPhone.Size = new Size(360, 18);
            lblCartCheckoutPhone.TabIndex = 3;
            lblCartCheckoutPhone.Text = "Số Điện Thoại *";
            // 
            // txtCheckoutPhone
            // 
            txtCheckoutPhone.BackColor = Color.FromArgb(11, 15, 25);
            txtCheckoutPhone.BorderStyle = BorderStyle.FixedSingle;
            txtCheckoutPhone.ForeColor = Color.White;
            txtCheckoutPhone.Location = new Point(20, 140);
            txtCheckoutPhone.Name = "txtCheckoutPhone";
            txtCheckoutPhone.Size = new Size(360, 24);
            txtCheckoutPhone.TabIndex = 4;
            // 
            // lblCartCheckoutAddress
            // 
            lblCartCheckoutAddress.ForeColor = Color.FromArgb(148, 163, 184);
            lblCartCheckoutAddress.Location = new Point(20, 185);
            lblCartCheckoutAddress.Name = "lblCartCheckoutAddress";
            lblCartCheckoutAddress.Size = new Size(360, 18);
            lblCartCheckoutAddress.TabIndex = 5;
            lblCartCheckoutAddress.Text = "Địa Chỉ Nhận Hàng *";
            // 
            // txtCheckoutAddress
            // 
            txtCheckoutAddress.BackColor = Color.FromArgb(11, 15, 25);
            txtCheckoutAddress.BorderStyle = BorderStyle.FixedSingle;
            txtCheckoutAddress.ForeColor = Color.White;
            txtCheckoutAddress.Location = new Point(20, 205);
            txtCheckoutAddress.Name = "txtCheckoutAddress";
            txtCheckoutAddress.Size = new Size(360, 24);
            txtCheckoutAddress.TabIndex = 6;
            // 
            // lblCartCheckoutPayment
            // 
            lblCartCheckoutPayment.ForeColor = Color.FromArgb(148, 163, 184);
            lblCartCheckoutPayment.Location = new Point(20, 250);
            lblCartCheckoutPayment.Name = "lblCartCheckoutPayment";
            lblCartCheckoutPayment.Size = new Size(360, 18);
            lblCartCheckoutPayment.TabIndex = 7;
            lblCartCheckoutPayment.Text = "Phương Thức Thanh Toán";
            // 
            // cbCheckoutPayment
            // 
            cbCheckoutPayment.BackColor = Color.FromArgb(11, 15, 25);
            cbCheckoutPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCheckoutPayment.ForeColor = Color.White;
            cbCheckoutPayment.Items.AddRange(new object[] { "Thanh toán khi nhận hàng (COD)", "Chuyển khoản ngân hàng (Mô phỏng)", "Ví MoMo / ZaloPay" });
            cbCheckoutPayment.Location = new Point(20, 270);
            cbCheckoutPayment.Name = "cbCheckoutPayment";
            cbCheckoutPayment.Size = new Size(360, 25);
            cbCheckoutPayment.TabIndex = 8;
            // 
            // btnPlaceOrderSubmit
            // 
            btnPlaceOrderSubmit.BackColor = Color.FromArgb(99, 102, 241);
            btnPlaceOrderSubmit.FlatAppearance.BorderSize = 0;
            btnPlaceOrderSubmit.FlatStyle = FlatStyle.Flat;
            btnPlaceOrderSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPlaceOrderSubmit.ForeColor = Color.White;
            btnPlaceOrderSubmit.Location = new Point(20, 340);
            btnPlaceOrderSubmit.Name = "btnPlaceOrderSubmit";
            btnPlaceOrderSubmit.Size = new Size(360, 45);
            btnPlaceOrderSubmit.TabIndex = 9;
            btnPlaceOrderSubmit.Text = "Xác Nhận Thanh Toán";
            btnPlaceOrderSubmit.UseVisualStyleBackColor = false;
            // 
            // panelProfile
            // 
            panelProfile.BackColor = Color.FromArgb(11, 15, 25);
            panelProfile.Controls.Add(lblProfileTitle);
            panelProfile.Controls.Add(panelProfileLeftCol);
            panelProfile.Controls.Add(panelProfileRightCol);
            panelProfile.Dock = DockStyle.Fill;
            panelProfile.Location = new Point(20, 20);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(1004, 741);
            panelProfile.TabIndex = 3;
            panelProfile.Visible = false;
            // 
            // lblProfileTitle
            // 
            lblProfileTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblProfileTitle.ForeColor = Color.White;
            lblProfileTitle.Location = new Point(0, 0);
            lblProfileTitle.Name = "lblProfileTitle";
            lblProfileTitle.Size = new Size(500, 35);
            lblProfileTitle.TabIndex = 0;
            lblProfileTitle.Text = "Hồ Sơ Cá Nhân & Lịch Sử Đơn Hàng";
            // 
            // panelProfileLeftCol
            // 
            panelProfileLeftCol.BackColor = Color.FromArgb(21, 28, 44);
            panelProfileLeftCol.Controls.Add(lblProfileLeftTitle);
            panelProfileLeftCol.Controls.Add(lblProfUsername);
            panelProfileLeftCol.Controls.Add(lblProfileFullName);
            panelProfileLeftCol.Controls.Add(txtProfFullName);
            panelProfileLeftCol.Controls.Add(lblProfilePhone);
            panelProfileLeftCol.Controls.Add(txtProfPhone);
            panelProfileLeftCol.Controls.Add(lblProfileAddress);
            panelProfileLeftCol.Controls.Add(txtProfAddress);
            panelProfileLeftCol.Controls.Add(btnProfileSave);
            panelProfileLeftCol.Location = new Point(0, 50);
            panelProfileLeftCol.Name = "panelProfileLeftCol";
            panelProfileLeftCol.Padding = new Padding(20);
            panelProfileLeftCol.Size = new Size(420, 680);
            panelProfileLeftCol.TabIndex = 1;
            // 
            // lblProfileLeftTitle
            // 
            lblProfileLeftTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProfileLeftTitle.ForeColor = Color.White;
            lblProfileLeftTitle.Location = new Point(20, 15);
            lblProfileLeftTitle.Name = "lblProfileLeftTitle";
            lblProfileLeftTitle.Size = new Size(200, 20);
            lblProfileLeftTitle.TabIndex = 0;
            lblProfileLeftTitle.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // lblProfUsername
            // 
            lblProfUsername.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblProfUsername.ForeColor = Color.FromArgb(6, 182, 212);
            lblProfUsername.Location = new Point(20, 50);
            lblProfUsername.Name = "lblProfUsername";
            lblProfUsername.Size = new Size(380, 20);
            lblProfUsername.TabIndex = 1;
            lblProfUsername.Text = "Tên tài khoản: user";
            // 
            // lblProfileFullName
            // 
            lblProfileFullName.ForeColor = Color.FromArgb(148, 163, 184);
            lblProfileFullName.Location = new Point(20, 90);
            lblProfileFullName.Name = "lblProfileFullName";
            lblProfileFullName.Size = new Size(380, 18);
            lblProfileFullName.TabIndex = 2;
            lblProfileFullName.Text = "Họ và Tên";
            // 
            // txtProfFullName
            // 
            txtProfFullName.BackColor = Color.FromArgb(11, 15, 25);
            txtProfFullName.BorderStyle = BorderStyle.FixedSingle;
            txtProfFullName.ForeColor = Color.White;
            txtProfFullName.Location = new Point(20, 110);
            txtProfFullName.Name = "txtProfFullName";
            txtProfFullName.Size = new Size(380, 24);
            txtProfFullName.TabIndex = 3;
            // 
            // lblProfilePhone
            // 
            lblProfilePhone.ForeColor = Color.FromArgb(148, 163, 184);
            lblProfilePhone.Location = new Point(20, 155);
            lblProfilePhone.Name = "lblProfilePhone";
            lblProfilePhone.Size = new Size(380, 18);
            lblProfilePhone.TabIndex = 4;
            lblProfilePhone.Text = "Số Điện Thoại";
            // 
            // txtProfPhone
            // 
            txtProfPhone.BackColor = Color.FromArgb(11, 15, 25);
            txtProfPhone.BorderStyle = BorderStyle.FixedSingle;
            txtProfPhone.ForeColor = Color.White;
            txtProfPhone.Location = new Point(20, 175);
            txtProfPhone.Name = "txtProfPhone";
            txtProfPhone.Size = new Size(380, 24);
            txtProfPhone.TabIndex = 5;
            // 
            // lblProfileAddress
            // 
            lblProfileAddress.ForeColor = Color.FromArgb(148, 163, 184);
            lblProfileAddress.Location = new Point(20, 220);
            lblProfileAddress.Name = "lblProfileAddress";
            lblProfileAddress.Size = new Size(380, 18);
            lblProfileAddress.TabIndex = 6;
            lblProfileAddress.Text = "Địa Chỉ Giao Hàng";
            // 
            // txtProfAddress
            // 
            txtProfAddress.BackColor = Color.FromArgb(11, 15, 25);
            txtProfAddress.BorderStyle = BorderStyle.FixedSingle;
            txtProfAddress.ForeColor = Color.White;
            txtProfAddress.Location = new Point(20, 240);
            txtProfAddress.Multiline = true;
            txtProfAddress.Name = "txtProfAddress";
            txtProfAddress.Size = new Size(380, 80);
            txtProfAddress.TabIndex = 7;
            // 
            // btnProfileSave
            // 
            btnProfileSave.BackColor = Color.FromArgb(99, 102, 241);
            btnProfileSave.FlatAppearance.BorderSize = 0;
            btnProfileSave.FlatStyle = FlatStyle.Flat;
            btnProfileSave.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnProfileSave.ForeColor = Color.White;
            btnProfileSave.Location = new Point(20, 340);
            btnProfileSave.Name = "btnProfileSave";
            btnProfileSave.Size = new Size(380, 40);
            btnProfileSave.TabIndex = 8;
            btnProfileSave.Text = "Cập Nhật Hồ Sơ";
            btnProfileSave.UseVisualStyleBackColor = false;
            // 
            // panelProfileRightCol
            // 
            panelProfileRightCol.BackColor = Color.FromArgb(21, 28, 44);
            panelProfileRightCol.Controls.Add(lblProfileRightTitle);
            panelProfileRightCol.Controls.Add(lstOrderHistory);
            panelProfileRightCol.Location = new Point(440, 50);
            panelProfileRightCol.Name = "panelProfileRightCol";
            panelProfileRightCol.Padding = new Padding(20);
            panelProfileRightCol.Size = new Size(560, 680);
            panelProfileRightCol.TabIndex = 2;
            // 
            // lblProfileRightTitle
            // 
            lblProfileRightTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProfileRightTitle.ForeColor = Color.White;
            lblProfileRightTitle.Location = new Point(20, 15);
            lblProfileRightTitle.Name = "lblProfileRightTitle";
            lblProfileRightTitle.Size = new Size(200, 20);
            lblProfileRightTitle.TabIndex = 0;
            lblProfileRightTitle.Text = "LỊCH SỬ MUA HÀNG";
            // 
            // lstOrderHistory
            // 
            lstOrderHistory.BackColor = Color.FromArgb(11, 15, 25);
            lstOrderHistory.BorderStyle = BorderStyle.None;
            lstOrderHistory.Font = new Font("Segoe UI", 9F);
            lstOrderHistory.ForeColor = Color.FromArgb(248, 250, 252);
            lstOrderHistory.Location = new Point(20, 45);
            lstOrderHistory.Name = "lstOrderHistory";
            lstOrderHistory.Size = new Size(520, 600);
            lstOrderHistory.TabIndex = 1;
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = Color.FromArgb(11, 15, 25);
            panelAdmin.Controls.Add(panelAdminTitleRow);
            panelAdmin.Controls.Add(panelAdminMetricsLayout);
            panelAdmin.Controls.Add(panelAdminDataLayout);
            panelAdmin.Controls.Add(panelAdminTableCard);
            panelAdmin.Dock = DockStyle.Fill;
            panelAdmin.Location = new Point(20, 20);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(1004, 741);
            panelAdmin.TabIndex = 4;
            panelAdmin.Visible = false;
            // 
            // panelAdminTitleRow
            // 
            panelAdminTitleRow.Controls.Add(lblAdminTitle);
            panelAdminTitleRow.Controls.Add(btnAdminAddProduct);
            panelAdminTitleRow.Dock = DockStyle.Top;
            panelAdminTitleRow.Location = new Point(0, 320);
            panelAdminTitleRow.Name = "panelAdminTitleRow";
            panelAdminTitleRow.Size = new Size(1004, 45);
            panelAdminTitleRow.TabIndex = 0;
            // 
            // lblAdminTitle
            // 
            lblAdminTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAdminTitle.ForeColor = Color.White;
            lblAdminTitle.Location = new Point(0, 0);
            lblAdminTitle.Name = "lblAdminTitle";
            lblAdminTitle.Size = new Size(400, 35);
            lblAdminTitle.TabIndex = 0;
            lblAdminTitle.Text = "Bảng Điều Khiển Admin";
            // 
            // btnAdminAddProduct
            // 
            btnAdminAddProduct.BackColor = Color.FromArgb(99, 102, 241);
            btnAdminAddProduct.FlatAppearance.BorderSize = 0;
            btnAdminAddProduct.FlatStyle = FlatStyle.Flat;
            btnAdminAddProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdminAddProduct.ForeColor = Color.White;
            btnAdminAddProduct.Location = new Point(840, 0);
            btnAdminAddProduct.Name = "btnAdminAddProduct";
            btnAdminAddProduct.Size = new Size(160, 32);
            btnAdminAddProduct.TabIndex = 1;
            btnAdminAddProduct.Text = "➕ Thêm Sản Phẩm Mới";
            btnAdminAddProduct.UseVisualStyleBackColor = false;
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
            panelAdminMetricsLayout.Dock = DockStyle.Top;
            panelAdminMetricsLayout.Location = new Point(0, 230);
            panelAdminMetricsLayout.Name = "panelAdminMetricsLayout";
            panelAdminMetricsLayout.Padding = new Padding(0, 5, 0, 5);
            panelAdminMetricsLayout.RowCount = 1;
            panelAdminMetricsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelAdminMetricsLayout.Size = new Size(1004, 90);
            panelAdminMetricsLayout.TabIndex = 1;
            // 
            // cardRevenue
            // 
            cardRevenue.BackColor = Color.FromArgb(21, 28, 44);
            cardRevenue.Controls.Add(lblTitleRev);
            cardRevenue.Controls.Add(lblStatRevenue);
            cardRevenue.Dock = DockStyle.Fill;
            cardRevenue.Location = new Point(0, 5);
            cardRevenue.Margin = new Padding(0, 0, 15, 0);
            cardRevenue.Name = "cardRevenue";
            cardRevenue.Padding = new Padding(15);
            cardRevenue.Size = new Size(236, 80);
            cardRevenue.TabIndex = 0;
            cardRevenue.Paint += CardRevenue_Paint;
            // 
            // lblTitleRev
            // 
            lblTitleRev.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTitleRev.ForeColor = Color.FromArgb(148, 163, 184);
            lblTitleRev.Location = new Point(15, 10);
            lblTitleRev.Name = "lblTitleRev";
            lblTitleRev.Size = new Size(200, 20);
            lblTitleRev.TabIndex = 0;
            lblTitleRev.Text = "Tổng Doanh Thu";
            // 
            // lblStatRevenue
            // 
            lblStatRevenue.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblStatRevenue.ForeColor = Color.White;
            lblStatRevenue.Location = new Point(15, 30);
            lblStatRevenue.Name = "lblStatRevenue";
            lblStatRevenue.Size = new Size(200, 30);
            lblStatRevenue.TabIndex = 1;
            lblStatRevenue.Text = "0 ₫";
            lblStatRevenue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cardOrders
            // 
            cardOrders.BackColor = Color.FromArgb(21, 28, 44);
            cardOrders.Controls.Add(lblTitleOrd);
            cardOrders.Controls.Add(lblStatOrders);
            cardOrders.Dock = DockStyle.Fill;
            cardOrders.Location = new Point(251, 5);
            cardOrders.Margin = new Padding(0, 0, 15, 0);
            cardOrders.Name = "cardOrders";
            cardOrders.Padding = new Padding(15);
            cardOrders.Size = new Size(236, 80);
            cardOrders.TabIndex = 1;
            cardOrders.Paint += CardOrders_Paint;
            // 
            // lblTitleOrd
            // 
            lblTitleOrd.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTitleOrd.ForeColor = Color.FromArgb(148, 163, 184);
            lblTitleOrd.Location = new Point(15, 10);
            lblTitleOrd.Name = "lblTitleOrd";
            lblTitleOrd.Size = new Size(200, 20);
            lblTitleOrd.TabIndex = 0;
            lblTitleOrd.Text = "Đơn Hàng Đã Bán";
            // 
            // lblStatOrders
            // 
            lblStatOrders.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblStatOrders.ForeColor = Color.White;
            lblStatOrders.Location = new Point(15, 30);
            lblStatOrders.Name = "lblStatOrders";
            lblStatOrders.Size = new Size(200, 30);
            lblStatOrders.TabIndex = 1;
            lblStatOrders.Text = "0";
            lblStatOrders.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cardLowStock
            // 
            cardLowStock.BackColor = Color.FromArgb(21, 28, 44);
            cardLowStock.Controls.Add(lblTitleLow);
            cardLowStock.Controls.Add(lblStatLowStock);
            cardLowStock.Dock = DockStyle.Fill;
            cardLowStock.Location = new Point(502, 5);
            cardLowStock.Margin = new Padding(0, 0, 15, 0);
            cardLowStock.Name = "cardLowStock";
            cardLowStock.Padding = new Padding(15);
            cardLowStock.Size = new Size(236, 80);
            cardLowStock.TabIndex = 2;
            cardLowStock.Paint += CardLowStock_Paint;
            // 
            // lblTitleLow
            // 
            lblTitleLow.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTitleLow.ForeColor = Color.FromArgb(148, 163, 184);
            lblTitleLow.Location = new Point(15, 10);
            lblTitleLow.Name = "lblTitleLow";
            lblTitleLow.Size = new Size(200, 20);
            lblTitleLow.TabIndex = 0;
            lblTitleLow.Text = "Cảnh Báo Sắp Hết";
            // 
            // lblStatLowStock
            // 
            lblStatLowStock.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblStatLowStock.ForeColor = Color.White;
            lblStatLowStock.Location = new Point(15, 30);
            lblStatLowStock.Name = "lblStatLowStock";
            lblStatLowStock.Size = new Size(200, 30);
            lblStatLowStock.TabIndex = 1;
            lblStatLowStock.Text = "0";
            lblStatLowStock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cardTotalProd
            // 
            cardTotalProd.BackColor = Color.FromArgb(21, 28, 44);
            cardTotalProd.Controls.Add(lblTitleTot);
            cardTotalProd.Controls.Add(lblStatTotalProducts);
            cardTotalProd.Dock = DockStyle.Fill;
            cardTotalProd.Location = new Point(753, 5);
            cardTotalProd.Margin = new Padding(0, 0, 15, 0);
            cardTotalProd.Name = "cardTotalProd";
            cardTotalProd.Padding = new Padding(15);
            cardTotalProd.Size = new Size(236, 80);
            cardTotalProd.TabIndex = 3;
            cardTotalProd.Paint += CardTotalProd_Paint;
            // 
            // lblTitleTot
            // 
            lblTitleTot.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTitleTot.ForeColor = Color.FromArgb(148, 163, 184);
            lblTitleTot.Location = new Point(15, 10);
            lblTitleTot.Name = "lblTitleTot";
            lblTitleTot.Size = new Size(200, 20);
            lblTitleTot.TabIndex = 0;
            lblTitleTot.Text = "Sản Phẩm Đang Bán";
            // 
            // lblStatTotalProducts
            // 
            lblStatTotalProducts.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblStatTotalProducts.ForeColor = Color.White;
            lblStatTotalProducts.Location = new Point(15, 30);
            lblStatTotalProducts.Name = "lblStatTotalProducts";
            lblStatTotalProducts.Size = new Size(200, 30);
            lblStatTotalProducts.TabIndex = 1;
            lblStatTotalProducts.Text = "0";
            lblStatTotalProducts.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelAdminDataLayout
            // 
            panelAdminDataLayout.ColumnCount = 2;
            panelAdminDataLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            panelAdminDataLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            panelAdminDataLayout.Controls.Add(panelAdminChartCard, 0, 0);
            panelAdminDataLayout.Controls.Add(panelAdminInfoCard, 1, 0);
            panelAdminDataLayout.Dock = DockStyle.Top;
            panelAdminDataLayout.Location = new Point(0, 0);
            panelAdminDataLayout.Name = "panelAdminDataLayout";
            panelAdminDataLayout.Padding = new Padding(0, 5, 0, 5);
            panelAdminDataLayout.RowCount = 1;
            panelAdminDataLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelAdminDataLayout.Size = new Size(1004, 230);
            panelAdminDataLayout.TabIndex = 2;
            // 
            // panelAdminChartCard
            // 
            panelAdminChartCard.BackColor = Color.FromArgb(21, 28, 44);
            panelAdminChartCard.Controls.Add(lblAdminChartTitle);
            panelAdminChartCard.Controls.Add(panelChart);
            panelAdminChartCard.Dock = DockStyle.Fill;
            panelAdminChartCard.Location = new Point(0, 5);
            panelAdminChartCard.Margin = new Padding(0, 0, 10, 0);
            panelAdminChartCard.Name = "panelAdminChartCard";
            panelAdminChartCard.Padding = new Padding(12);
            panelAdminChartCard.Size = new Size(642, 220);
            panelAdminChartCard.TabIndex = 0;
            // 
            // lblAdminChartTitle
            // 
            lblAdminChartTitle.Dock = DockStyle.Top;
            lblAdminChartTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblAdminChartTitle.ForeColor = Color.White;
            lblAdminChartTitle.Location = new Point(12, 12);
            lblAdminChartTitle.Name = "lblAdminChartTitle";
            lblAdminChartTitle.Size = new Size(618, 22);
            lblAdminChartTitle.TabIndex = 0;
            lblAdminChartTitle.Text = "Biểu đồ doanh thu tuần";
            // 
            // panelChart
            // 
            panelChart.BackColor = Color.Transparent;
            panelChart.Dock = DockStyle.Fill;
            panelChart.Location = new Point(12, 12);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(618, 196);
            panelChart.TabIndex = 1;
            panelChart.Paint += PaintRevenueChart;
            // 
            // panelAdminInfoCard
            // 
            panelAdminInfoCard.BackColor = Color.FromArgb(21, 28, 44);
            panelAdminInfoCard.Controls.Add(lblAdminInfoTitle);
            panelAdminInfoCard.Controls.Add(lblAdminStatusDB);
            panelAdminInfoCard.Controls.Add(lblAdminStatusSync);
            panelAdminInfoCard.Controls.Add(lblAdminStatusOnline);
            panelAdminInfoCard.Controls.Add(txtAdminInfoNote);
            panelAdminInfoCard.Dock = DockStyle.Fill;
            panelAdminInfoCard.Location = new Point(662, 5);
            panelAdminInfoCard.Margin = new Padding(10, 0, 0, 0);
            panelAdminInfoCard.Name = "panelAdminInfoCard";
            panelAdminInfoCard.Padding = new Padding(15);
            panelAdminInfoCard.Size = new Size(342, 220);
            panelAdminInfoCard.TabIndex = 1;
            // 
            // lblAdminInfoTitle
            // 
            lblAdminInfoTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblAdminInfoTitle.ForeColor = Color.White;
            lblAdminInfoTitle.Location = new Point(15, 10);
            lblAdminInfoTitle.Name = "lblAdminInfoTitle";
            lblAdminInfoTitle.Size = new Size(200, 22);
            lblAdminInfoTitle.TabIndex = 0;
            lblAdminInfoTitle.Text = "Hệ Thống Trực Tuyến";
            // 
            // lblAdminStatusDB
            // 
            lblAdminStatusDB.ForeColor = Color.FromArgb(148, 163, 184);
            lblAdminStatusDB.Location = new Point(15, 45);
            lblAdminStatusDB.Name = "lblAdminStatusDB";
            lblAdminStatusDB.Size = new Size(300, 20);
            lblAdminStatusDB.TabIndex = 1;
            lblAdminStatusDB.Text = "• CSDL: database.json";
            // 
            // lblAdminStatusSync
            // 
            lblAdminStatusSync.ForeColor = Color.FromArgb(148, 163, 184);
            lblAdminStatusSync.Location = new Point(15, 70);
            lblAdminStatusSync.Name = "lblAdminStatusSync";
            lblAdminStatusSync.Size = new Size(300, 20);
            lblAdminStatusSync.TabIndex = 2;
            lblAdminStatusSync.Text = "• Cập nhật kho: Thời gian thực";
            // 
            // lblAdminStatusOnline
            // 
            lblAdminStatusOnline.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAdminStatusOnline.ForeColor = Color.FromArgb(16, 185, 129);
            lblAdminStatusOnline.Location = new Point(15, 95);
            lblAdminStatusOnline.Name = "lblAdminStatusOnline";
            lblAdminStatusOnline.Size = new Size(300, 20);
            lblAdminStatusOnline.TabIndex = 3;
            lblAdminStatusOnline.Text = "• Trạng thái: Hoạt động";
            // 
            // txtAdminInfoNote
            // 
            txtAdminInfoNote.BackColor = Color.FromArgb(11, 15, 25);
            txtAdminInfoNote.BorderStyle = BorderStyle.None;
            txtAdminInfoNote.ForeColor = Color.FromArgb(148, 163, 184);
            txtAdminInfoNote.Location = new Point(15, 125);
            txtAdminInfoNote.Multiline = true;
            txtAdminInfoNote.Name = "txtAdminInfoNote";
            txtAdminInfoNote.ReadOnly = true;
            txtAdminInfoNote.Size = new Size(300, 80);
            txtAdminInfoNote.TabIndex = 4;
            txtAdminInfoNote.Text = "Cơ sở dữ liệu được đồng bộ hóa. Khi Khách hàng đặt mua sản phẩm, lượng tồn kho sẽ tự động giảm đi và số tiền hóa đơn sẽ cộng trực tiếp vào biểu đồ doanh thu bên trái.";
            // 
            // panelAdminTableCard
            // 
            panelAdminTableCard.BackColor = Color.FromArgb(21, 28, 44);
            panelAdminTableCard.Controls.Add(panelAdminTableHeaderRow);
            panelAdminTableCard.Controls.Add(dgvInventory);
            panelAdminTableCard.Dock = DockStyle.Fill;
            panelAdminTableCard.Location = new Point(0, 0);
            panelAdminTableCard.Name = "panelAdminTableCard";
            panelAdminTableCard.Padding = new Padding(12);
            panelAdminTableCard.Size = new Size(1004, 741);
            panelAdminTableCard.TabIndex = 3;
            // 
            // panelAdminTableHeaderRow
            // 
            panelAdminTableHeaderRow.Controls.Add(lblAdminTableTitle);
            panelAdminTableHeaderRow.Controls.Add(txtAdminSearch);
            panelAdminTableHeaderRow.Dock = DockStyle.Top;
            panelAdminTableHeaderRow.Location = new Point(12, 12);
            panelAdminTableHeaderRow.Name = "panelAdminTableHeaderRow";
            panelAdminTableHeaderRow.Size = new Size(980, 35);
            panelAdminTableHeaderRow.TabIndex = 0;
            // 
            // lblAdminTableTitle
            // 
            lblAdminTableTitle.AutoSize = true;
            lblAdminTableTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAdminTableTitle.ForeColor = Color.White;
            lblAdminTableTitle.Location = new Point(0, 3);
            lblAdminTableTitle.Name = "lblAdminTableTitle";
            lblAdminTableTitle.Size = new Size(155, 20);
            lblAdminTableTitle.TabIndex = 0;
            lblAdminTableTitle.Text = "Danh Sách Kho Hàng";
            // 
            // txtAdminSearch
            // 
            txtAdminSearch.BackColor = Color.FromArgb(11, 15, 25);
            txtAdminSearch.BorderStyle = BorderStyle.FixedSingle;
            txtAdminSearch.ForeColor = Color.White;
            txtAdminSearch.Location = new Point(740, 3);
            txtAdminSearch.Name = "txtAdminSearch";
            txtAdminSearch.PlaceholderText = "Tìm kiếm sản phẩm...";
            txtAdminSearch.Size = new Size(235, 24);
            txtAdminSearch.TabIndex = 1;
            txtAdminSearch.TextChanged += TxtAdminSearch_TextChanged;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.BackgroundColor = Color.FromArgb(21, 28, 44);
            dgvInventory.BorderStyle = BorderStyle.None;
            dgvInventory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.EnableHeadersVisualStyles = false;
            dgvInventory.GridColor = Color.FromArgb(51, 65, 85);
            dgvInventory.Location = new Point(12, 12);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(980, 717);
            dgvInventory.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 15, 25);
            ClientSize = new Size(1284, 781);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 9.5F);
            ForeColor = Color.FromArgb(248, 250, 252);
            MinimumSize = new Size(1100, 750);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechStore - Hệ Thống Bán Hàng Công Nghệ & Quản Lý";
            panelSidebar.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelHome.ResumeLayout(false);
            panelHomeHero.ResumeLayout(false);
            panelHomeHero.PerformLayout();
            panelShop.ResumeLayout(false);
            panelShop.PerformLayout();
            panelCartView.ResumeLayout(false);
            panelCartLeftCol.ResumeLayout(false);
            panelCartRightCol.ResumeLayout(false);
            panelCartRightCol.PerformLayout();
            panelProfile.ResumeLayout(false);
            panelProfileLeftCol.ResumeLayout(false);
            panelProfileLeftCol.PerformLayout();
            panelProfileRightCol.ResumeLayout(false);
            panelAdmin.ResumeLayout(false);
            panelAdminTitleRow.ResumeLayout(false);
            panelAdminMetricsLayout.ResumeLayout(false);
            cardRevenue.ResumeLayout(false);
            cardOrders.ResumeLayout(false);
            cardLowStock.ResumeLayout(false);
            cardTotalProd.ResumeLayout(false);
            panelAdminDataLayout.ResumeLayout(false);
            panelAdminChartCard.ResumeLayout(false);
            panelAdminInfoCard.ResumeLayout(false);
            panelAdminInfoCard.PerformLayout();
            panelAdminTableCard.ResumeLayout(false);
            panelAdminTableHeaderRow.ResumeLayout(false);
            panelAdminTableHeaderRow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Button btnMenuHome;
        private System.Windows.Forms.Button btnMenuApple;
        private System.Windows.Forms.Button btnMenuSamsung;
        private System.Windows.Forms.Button btnMenuXiaomi;
        private System.Windows.Forms.Button btnMenuWatches;
        private System.Windows.Forms.Button btnMenuAccessories;
        private System.Windows.Forms.Button btnMenuCart;
        private System.Windows.Forms.Button btnMenuProfile;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.Button btnMenuAdmin;
        private System.Windows.Forms.Button btnMenuLogout;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelHomeHero;
        private System.Windows.Forms.Label lblHomeHeroTitle;
        private System.Windows.Forms.Label lblHomeHeroSub;
        private System.Windows.Forms.Label lblHomeFeaturedHeader;
        private System.Windows.Forms.FlowLayoutPanel flpHomeFeatured;
        private System.Windows.Forms.Panel panelShop;
        private System.Windows.Forms.Label lblCategoryTitle;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.FlowLayoutPanel flpProducts;
        private System.Windows.Forms.Panel panelCartView;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.Panel panelCartLeftCol;
        private System.Windows.Forms.Label lblCartLeftTitle;
        private System.Windows.Forms.FlowLayoutPanel flpCartLines;
        private System.Windows.Forms.Label lblCartTotalAmount;
        private System.Windows.Forms.Panel panelCartRightCol;
        private System.Windows.Forms.Label lblCartRightTitle;
        private System.Windows.Forms.Label lblCartCheckoutName;
        private System.Windows.Forms.TextBox txtCheckoutName;
        private System.Windows.Forms.Label lblCartCheckoutPhone;
        private System.Windows.Forms.TextBox txtCheckoutPhone;
        private System.Windows.Forms.Label lblCartCheckoutAddress;
        private System.Windows.Forms.TextBox txtCheckoutAddress;
        private System.Windows.Forms.Label lblCartCheckoutPayment;
        private System.Windows.Forms.ComboBox cbCheckoutPayment;
        private System.Windows.Forms.Button btnPlaceOrderSubmit;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Label lblProfileTitle;
        private System.Windows.Forms.Panel panelProfileLeftCol;
        private System.Windows.Forms.Label lblProfileLeftTitle;
        private System.Windows.Forms.Label lblProfUsername;
        private System.Windows.Forms.Label lblProfileFullName;
        private System.Windows.Forms.TextBox txtProfFullName;
        private System.Windows.Forms.Label lblProfilePhone;
        private System.Windows.Forms.TextBox txtProfPhone;
        private System.Windows.Forms.Label lblProfileAddress;
        private System.Windows.Forms.TextBox txtProfAddress;
        private System.Windows.Forms.Button btnProfileSave;
        private System.Windows.Forms.Panel panelProfileRightCol;
        private System.Windows.Forms.Label lblProfileRightTitle;
        private System.Windows.Forms.ListBox lstOrderHistory;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Panel panelAdminTitleRow;
        private System.Windows.Forms.Label lblAdminTitle;
        private System.Windows.Forms.Button btnAdminAddProduct;
        private System.Windows.Forms.TableLayoutPanel panelAdminMetricsLayout;
        private System.Windows.Forms.Panel cardRevenue;
        private System.Windows.Forms.Label lblTitleRev;
        private System.Windows.Forms.Label lblStatRevenue;
        private System.Windows.Forms.Panel cardOrders;
        private System.Windows.Forms.Label lblTitleOrd;
        private System.Windows.Forms.Label lblStatOrders;
        private System.Windows.Forms.Panel cardLowStock;
        private System.Windows.Forms.Label lblTitleLow;
        private System.Windows.Forms.Label lblStatLowStock;
        private System.Windows.Forms.Panel cardTotalProd;
        private System.Windows.Forms.Label lblTitleTot;
        private System.Windows.Forms.Label lblStatTotalProducts;
        private System.Windows.Forms.TableLayoutPanel panelAdminDataLayout;
        private System.Windows.Forms.Panel panelAdminChartCard;
        private System.Windows.Forms.Label lblAdminChartTitle;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelAdminInfoCard;
        private System.Windows.Forms.Label lblAdminInfoTitle;
        private System.Windows.Forms.Label lblAdminStatusDB;
        private System.Windows.Forms.Label lblAdminStatusSync;
        private System.Windows.Forms.Label lblAdminStatusOnline;
        private System.Windows.Forms.TextBox txtAdminInfoNote;
        private System.Windows.Forms.Panel panelAdminTableCard;
        private System.Windows.Forms.Panel panelAdminTableHeaderRow;
        private System.Windows.Forms.Label lblAdminTableTitle;
        private System.Windows.Forms.TextBox txtAdminSearch;
        private System.Windows.Forms.DataGridView dgvInventory;
    }
}
