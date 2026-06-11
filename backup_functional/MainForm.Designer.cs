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
            btnMenuNews = new Button();
            btnMenuAbout = new Button();
            btnMenuLogout = new Button();
            panelContent = new Panel();
            
            // 1. Home Panel
            panelHome = new Panel();
            panelHomeHero = new Panel();
            lblHomeHeroTitle = new Label();
            lblHomeHeroSub = new Label();
            lblHomeFeaturedHeader = new Label();
            flpHomeFeatured = new FlowLayoutPanel();
            
            // 2. Shop Panel
            panelShop = new Panel();
            lblCategoryTitle = new Label();
            txtCustomerSearch = new TextBox();
            flpProducts = new FlowLayoutPanel();
            
            // 3. Cart Panel
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
            
            // 4. Profile Panel
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
            
            // 5. News Panel
            panelNews = new Panel();
            lblNewsTitle = new Label();
            flpNews = new FlowLayoutPanel();
            
            // 6. About Panel
            panelAbout = new Panel();
            lblAboutTitle = new Label();
            panelAboutLeft = new Panel();
            lblAboutText = new Label();
            panelAboutRight = new Panel();
            lblAboutFormTitle = new Label();
            lblAboutName = new Label();
            txtAboutName = new TextBox();
            lblAboutEmail = new Label();
            txtAboutEmail = new TextBox();
            lblAboutMsg = new Label();
            txtAboutMsg = new TextBox();
            btnSendAboutMsg = new Button();

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
            panelNews.SuspendLayout();
            panelAbout.SuspendLayout();
            panelAboutLeft.SuspendLayout();
            panelAboutRight.SuspendLayout();
            SuspendLayout();

            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(224, 224, 224);
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
            panelSidebar.Controls.Add(btnMenuNews);
            panelSidebar.Controls.Add(btnMenuAbout);
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
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.DarkBlue;
            lblLogo.Location = new Point(15, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(210, 30);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "⚡ TechStore";
            // 
            // lblUserInfo
            // 
            lblUserInfo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUserInfo.ForeColor = Color.RoyalBlue;
            lblUserInfo.Location = new Point(15, 65);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(210, 20);
            lblUserInfo.TabIndex = 1;
            lblUserInfo.Text = "Xin chào, Khách";
            // 
            // lblUserRole
            // 
            lblUserRole.Font = new Font("Segoe UI", 8F);
            lblUserRole.ForeColor = Color.FromArgb(64, 64, 64);
            lblUserRole.Location = new Point(15, 85);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(210, 15);
            lblUserRole.TabIndex = 2;
            lblUserRole.Text = "Vai trò: Khách hàng";
            // 
            // line1
            // 
            line1.BackColor = Color.DarkGray;
            line1.Location = new Point(15, 110);
            line1.Name = "line1";
            line1.Size = new Size(210, 1);
            line1.TabIndex = 3;
            // 
            // btnMenuHome
            // 
            btnMenuHome.BackColor = Color.Transparent;
            btnMenuHome.FlatAppearance.BorderSize = 0;
            btnMenuHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuHome.FlatStyle = FlatStyle.Flat;
            btnMenuHome.Font = new Font("Segoe UI", 9.5F);
            btnMenuHome.ForeColor = Color.Black;
            btnMenuHome.Location = new Point(15, 120);
            btnMenuHome.Name = "btnMenuHome";
            btnMenuHome.Padding = new Padding(10, 0, 0, 0);
            btnMenuHome.Size = new Size(210, 35);
            btnMenuHome.TabIndex = 4;
            btnMenuHome.Text = "🏠 Trang Chủ";
            btnMenuHome.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuHome.UseVisualStyleBackColor = false;
            // 
            // btnMenuApple
            // 
            btnMenuApple.BackColor = Color.Transparent;
            btnMenuApple.FlatAppearance.BorderSize = 0;
            btnMenuApple.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuApple.FlatStyle = FlatStyle.Flat;
            btnMenuApple.Font = new Font("Segoe UI", 9.5F);
            btnMenuApple.ForeColor = Color.Black;
            btnMenuApple.Location = new Point(15, 160);
            btnMenuApple.Name = "btnMenuApple";
            btnMenuApple.Padding = new Padding(10, 0, 0, 0);
            btnMenuApple.Size = new Size(210, 35);
            btnMenuApple.TabIndex = 5;
            btnMenuApple.Text = "🍏 Điện thoại Apple";
            btnMenuApple.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuApple.UseVisualStyleBackColor = false;
            // 
            // btnMenuSamsung
            // 
            btnMenuSamsung.BackColor = Color.Transparent;
            btnMenuSamsung.FlatAppearance.BorderSize = 0;
            btnMenuSamsung.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuSamsung.FlatStyle = FlatStyle.Flat;
            btnMenuSamsung.Font = new Font("Segoe UI", 9.5F);
            btnMenuSamsung.ForeColor = Color.Black;
            btnMenuSamsung.Location = new Point(15, 200);
            btnMenuSamsung.Name = "btnMenuSamsung";
            btnMenuSamsung.Padding = new Padding(10, 0, 0, 0);
            btnMenuSamsung.Size = new Size(210, 35);
            btnMenuSamsung.TabIndex = 6;
            btnMenuSamsung.Text = "📱 Điện thoại Samsung";
            btnMenuSamsung.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuSamsung.UseVisualStyleBackColor = false;
            // 
            // btnMenuXiaomi
            // 
            btnMenuXiaomi.BackColor = Color.Transparent;
            btnMenuXiaomi.FlatAppearance.BorderSize = 0;
            btnMenuXiaomi.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuXiaomi.FlatStyle = FlatStyle.Flat;
            btnMenuXiaomi.Font = new Font("Segoe UI", 9.5F);
            btnMenuXiaomi.ForeColor = Color.Black;
            btnMenuXiaomi.Location = new Point(15, 240);
            btnMenuXiaomi.Name = "btnMenuXiaomi";
            btnMenuXiaomi.Padding = new Padding(10, 0, 0, 0);
            btnMenuXiaomi.Size = new Size(210, 35);
            btnMenuXiaomi.TabIndex = 7;
            btnMenuXiaomi.Text = "💎 Điện thoại Xiaomi";
            btnMenuXiaomi.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuXiaomi.UseVisualStyleBackColor = false;
            // 
            // btnMenuWatches
            // 
            btnMenuWatches.BackColor = Color.Transparent;
            btnMenuWatches.FlatAppearance.BorderSize = 0;
            btnMenuWatches.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuWatches.FlatStyle = FlatStyle.Flat;
            btnMenuWatches.Font = new Font("Segoe UI", 9.5F);
            btnMenuWatches.ForeColor = Color.Black;
            btnMenuWatches.Location = new Point(15, 280);
            btnMenuWatches.Name = "btnMenuWatches";
            btnMenuWatches.Padding = new Padding(10, 0, 0, 0);
            btnMenuWatches.Size = new Size(210, 35);
            btnMenuWatches.TabIndex = 8;
            btnMenuWatches.Text = "⌚ Đồng hồ thông minh";
            btnMenuWatches.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuWatches.UseVisualStyleBackColor = false;
            // 
            // btnMenuAccessories
            // 
            btnMenuAccessories.BackColor = Color.Transparent;
            btnMenuAccessories.FlatAppearance.BorderSize = 0;
            btnMenuAccessories.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuAccessories.FlatStyle = FlatStyle.Flat;
            btnMenuAccessories.Font = new Font("Segoe UI", 9.5F);
            btnMenuAccessories.ForeColor = Color.Black;
            btnMenuAccessories.Location = new Point(15, 320);
            btnMenuAccessories.Name = "btnMenuAccessories";
            btnMenuAccessories.Padding = new Padding(10, 0, 0, 0);
            btnMenuAccessories.Size = new Size(210, 35);
            btnMenuAccessories.TabIndex = 9;
            btnMenuAccessories.Text = "🎧 Tai nghe & Phụ kiện";
            btnMenuAccessories.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuAccessories.UseVisualStyleBackColor = false;
            // 
            // btnMenuCart
            // 
            btnMenuCart.BackColor = Color.Transparent;
            btnMenuCart.FlatAppearance.BorderSize = 0;
            btnMenuCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuCart.FlatStyle = FlatStyle.Flat;
            btnMenuCart.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnMenuCart.ForeColor = Color.Black;
            btnMenuCart.Location = new Point(15, 360);
            btnMenuCart.Name = "btnMenuCart";
            btnMenuCart.Padding = new Padding(10, 0, 0, 0);
            btnMenuCart.Size = new Size(210, 35);
            btnMenuCart.TabIndex = 10;
            btnMenuCart.Text = "🛒 Giỏ Hàng (0)";
            btnMenuCart.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuCart.UseVisualStyleBackColor = false;
            // 
            // btnMenuProfile
            // 
            btnMenuProfile.BackColor = Color.Transparent;
            btnMenuProfile.FlatAppearance.BorderSize = 0;
            btnMenuProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuProfile.FlatStyle = FlatStyle.Flat;
            btnMenuProfile.Font = new Font("Segoe UI", 9.5F);
            btnMenuProfile.ForeColor = Color.Black;
            btnMenuProfile.Location = new Point(15, 400);
            btnMenuProfile.Name = "btnMenuProfile";
            btnMenuProfile.Padding = new Padding(10, 0, 0, 0);
            btnMenuProfile.Size = new Size(210, 35);
            btnMenuProfile.TabIndex = 11;
            btnMenuProfile.Text = "👤 Hồ Sơ Cá Nhân";
            btnMenuProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuProfile.UseVisualStyleBackColor = false;
            // 
            // line2
            // 
            line2.BackColor = Color.DarkGray;
            line2.Location = new Point(15, 445);
            line2.Name = "line2";
            line2.Size = new Size(210, 1);
            line2.TabIndex = 12;
            // 
            // btnMenuNews
            // 
            btnMenuNews.BackColor = Color.Transparent;
            btnMenuNews.FlatAppearance.BorderSize = 0;
            btnMenuNews.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuNews.FlatStyle = FlatStyle.Flat;
            btnMenuNews.Font = new Font("Segoe UI", 9.5F);
            btnMenuNews.ForeColor = Color.Black;
            btnMenuNews.Location = new Point(15, 455);
            btnMenuNews.Name = "btnMenuNews";
            btnMenuNews.Padding = new Padding(10, 0, 0, 0);
            btnMenuNews.Size = new Size(210, 35);
            btnMenuNews.TabIndex = 13;
            btnMenuNews.Text = "📰 Tin Tức Công Nghệ";
            btnMenuNews.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuNews.UseVisualStyleBackColor = false;
            // 
            // btnMenuAbout
            // 
            btnMenuAbout.BackColor = Color.Transparent;
            btnMenuAbout.FlatAppearance.BorderSize = 0;
            btnMenuAbout.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 200, 200);
            btnMenuAbout.FlatStyle = FlatStyle.Flat;
            btnMenuAbout.Font = new Font("Segoe UI", 9.5F);
            btnMenuAbout.ForeColor = Color.Black;
            btnMenuAbout.Location = new Point(15, 495);
            btnMenuAbout.Name = "btnMenuAbout";
            btnMenuAbout.Padding = new Padding(10, 0, 0, 0);
            btnMenuAbout.Size = new Size(210, 35);
            btnMenuAbout.TabIndex = 14;
            btnMenuAbout.Text = "📞 Giới Thiệu & Liên Hệ";
            btnMenuAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuAbout.UseVisualStyleBackColor = false;
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
            btnMenuLogout.TabIndex = 15;
            btnMenuLogout.Text = "🚪 Đăng Xuất";
            btnMenuLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuLogout.UseVisualStyleBackColor = false;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(240, 240, 240);
            panelContent.Controls.Add(panelHome);
            panelContent.Controls.Add(panelShop);
            panelContent.Controls.Add(panelCartView);
            panelContent.Controls.Add(panelProfile);
            panelContent.Controls.Add(panelNews);
            panelContent.Controls.Add(panelAbout);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(240, 0);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(1040, 750);
            panelContent.TabIndex = 1;
            // 
            // panelHome
            // 
            panelHome.AutoScroll = true;
            panelHome.BackColor = Color.FromArgb(240, 240, 240);
            panelHome.Controls.Add(panelHomeHero);
            panelHome.Controls.Add(lblHomeFeaturedHeader);
            panelHome.Controls.Add(flpHomeFeatured);
            panelHome.Dock = DockStyle.Fill;
            panelHome.Location = new Point(20, 20);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1000, 710);
            panelHome.TabIndex = 0;
            panelHome.Visible = false;
            // 
            // panelHomeHero
            // 
            panelHomeHero.BackColor = Color.RoyalBlue;
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
            lblHomeFeaturedHeader.ForeColor = Color.Black;
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
            panelShop.BackColor = Color.FromArgb(240, 240, 240);
            panelShop.Controls.Add(lblCategoryTitle);
            panelShop.Controls.Add(txtCustomerSearch);
            panelShop.Controls.Add(flpProducts);
            panelShop.Dock = DockStyle.Fill;
            panelShop.Location = new Point(20, 20);
            panelShop.Name = "panelShop";
            panelShop.Size = new Size(1000, 710);
            panelShop.TabIndex = 1;
            panelShop.Visible = false;
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCategoryTitle.ForeColor = Color.RoyalBlue;
            lblCategoryTitle.Location = new Point(0, 0);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(400, 35);
            lblCategoryTitle.TabIndex = 0;
            lblCategoryTitle.Text = "Cửa Hàng";
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.BackColor = Color.White;
            txtCustomerSearch.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerSearch.ForeColor = Color.Black;
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
            flpProducts.Size = new Size(1000, 650);
            flpProducts.TabIndex = 2;
            // 
            // panelCartView
            // 
            panelCartView.BackColor = Color.FromArgb(240, 240, 240);
            panelCartView.Controls.Add(lblCartTitle);
            panelCartView.Controls.Add(panelCartLeftCol);
            panelCartView.Controls.Add(panelCartRightCol);
            panelCartView.Dock = DockStyle.Fill;
            panelCartView.Location = new Point(20, 20);
            panelCartView.Name = "panelCartView";
            panelCartView.Size = new Size(1000, 710);
            panelCartView.TabIndex = 2;
            panelCartView.Visible = false;
            // 
            // lblCartTitle
            // 
            lblCartTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCartTitle.ForeColor = Color.DarkBlue;
            lblCartTitle.Location = new Point(0, 0);
            lblCartTitle.Name = "lblCartTitle";
            lblCartTitle.Size = new Size(500, 35);
            lblCartTitle.TabIndex = 0;
            lblCartTitle.Text = "Giỏ Hàng & Thanh Toán Đơn Hàng";
            // 
            // panelCartLeftCol
            // 
            panelCartLeftCol.BackColor = Color.White;
            panelCartLeftCol.BorderStyle = BorderStyle.FixedSingle;
            panelCartLeftCol.Controls.Add(lblCartLeftTitle);
            panelCartLeftCol.Controls.Add(flpCartLines);
            panelCartLeftCol.Controls.Add(lblCartTotalAmount);
            panelCartLeftCol.Location = new Point(0, 50);
            panelCartLeftCol.Name = "panelCartLeftCol";
            panelCartLeftCol.Padding = new Padding(15);
            panelCartLeftCol.Size = new Size(580, 650);
            panelCartLeftCol.TabIndex = 1;
            // 
            // lblCartLeftTitle
            // 
            lblCartLeftTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCartLeftTitle.ForeColor = Color.Black;
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
            flpCartLines.Size = new Size(550, 510);
            flpCartLines.TabIndex = 1;
            // 
            // lblCartTotalAmount
            // 
            lblCartTotalAmount.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblCartTotalAmount.ForeColor = Color.Red;
            lblCartTotalAmount.Location = new Point(15, 570);
            lblCartTotalAmount.Name = "lblCartTotalAmount";
            lblCartTotalAmount.Size = new Size(550, 30);
            lblCartTotalAmount.TabIndex = 2;
            lblCartTotalAmount.Text = "Tổng phụ: 0 ₫";
            lblCartTotalAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelCartRightCol
            // 
            panelCartRightCol.BackColor = Color.White;
            panelCartRightCol.BorderStyle = BorderStyle.FixedSingle;
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
            panelCartRightCol.Size = new Size(400, 650);
            panelCartRightCol.TabIndex = 2;
            // 
            // lblCartRightTitle
            // 
            lblCartRightTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCartRightTitle.ForeColor = Color.Black;
            lblCartRightTitle.Location = new Point(20, 15);
            lblCartRightTitle.Name = "lblCartRightTitle";
            lblCartRightTitle.Size = new Size(200, 20);
            lblCartRightTitle.TabIndex = 0;
            lblCartRightTitle.Text = "THÔNG TIN GIAO HÀNG";
            // 
            // lblCartCheckoutName
            // 
            lblCartCheckoutName.ForeColor = Color.FromArgb(64, 64, 64);
            lblCartCheckoutName.Location = new Point(20, 55);
            lblCartCheckoutName.Name = "lblCartCheckoutName";
            lblCartCheckoutName.Size = new Size(360, 18);
            lblCartCheckoutName.TabIndex = 1;
            lblCartCheckoutName.Text = "Họ và Tên *";
            // 
            // txtCheckoutName
            // 
            txtCheckoutName.BackColor = Color.White;
            txtCheckoutName.BorderStyle = BorderStyle.FixedSingle;
            txtCheckoutName.ForeColor = Color.Black;
            txtCheckoutName.Location = new Point(20, 75);
            txtCheckoutName.Name = "txtCheckoutName";
            txtCheckoutName.Size = new Size(360, 24);
            txtCheckoutName.TabIndex = 2;
            // 
            // lblCartCheckoutPhone
            // 
            lblCartCheckoutPhone.ForeColor = Color.FromArgb(64, 64, 64);
            lblCartCheckoutPhone.Location = new Point(20, 120);
            lblCartCheckoutPhone.Name = "lblCartCheckoutPhone";
            lblCartCheckoutPhone.Size = new Size(360, 18);
            lblCartCheckoutPhone.TabIndex = 3;
            lblCartCheckoutPhone.Text = "Số Điện Thoại *";
            // 
            // txtCheckoutPhone
            // 
            txtCheckoutPhone.BackColor = Color.White;
            txtCheckoutPhone.BorderStyle = BorderStyle.FixedSingle;
            txtCheckoutPhone.ForeColor = Color.Black;
            txtCheckoutPhone.Location = new Point(20, 140);
            txtCheckoutPhone.Name = "txtCheckoutPhone";
            txtCheckoutPhone.Size = new Size(360, 24);
            txtCheckoutPhone.TabIndex = 4;
            // 
            // lblCartCheckoutAddress
            // 
            lblCartCheckoutAddress.ForeColor = Color.FromArgb(64, 64, 64);
            lblCartCheckoutAddress.Location = new Point(20, 185);
            lblCartCheckoutAddress.Name = "lblCartCheckoutAddress";
            lblCartCheckoutAddress.Size = new Size(360, 18);
            lblCartCheckoutAddress.TabIndex = 5;
            lblCartCheckoutAddress.Text = "Địa Chỉ Nhận Hàng *";
            // 
            // txtCheckoutAddress
            // 
            txtCheckoutAddress.BackColor = Color.White;
            txtCheckoutAddress.BorderStyle = BorderStyle.FixedSingle;
            txtCheckoutAddress.ForeColor = Color.Black;
            txtCheckoutAddress.Location = new Point(20, 205);
            txtCheckoutAddress.Name = "txtCheckoutAddress";
            txtCheckoutAddress.Size = new Size(360, 24);
            txtCheckoutAddress.TabIndex = 6;
            // 
            // lblCartCheckoutPayment
            // 
            lblCartCheckoutPayment.ForeColor = Color.FromArgb(64, 64, 64);
            lblCartCheckoutPayment.Location = new Point(20, 250);
            lblCartCheckoutPayment.Name = "lblCartCheckoutPayment";
            lblCartCheckoutPayment.Size = new Size(360, 18);
            lblCartCheckoutPayment.TabIndex = 7;
            lblCartCheckoutPayment.Text = "Phương Thức Thanh Toán";
            // 
            // cbCheckoutPayment
            // 
            cbCheckoutPayment.BackColor = Color.White;
            cbCheckoutPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCheckoutPayment.ForeColor = Color.Black;
            cbCheckoutPayment.Items.AddRange(new object[] { "Thanh toán khi nhận hàng (COD)", "Chuyển khoản ngân hàng (Mô phỏng)", "Ví MoMo / ZaloPay" });
            cbCheckoutPayment.Location = new Point(20, 270);
            cbCheckoutPayment.Name = "cbCheckoutPayment";
            cbCheckoutPayment.Size = new Size(360, 25);
            cbCheckoutPayment.TabIndex = 8;
            // 
            // btnPlaceOrderSubmit
            // 
            btnPlaceOrderSubmit.BackColor = Color.RoyalBlue;
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
            btnPlaceOrderSubmit.Click += BtnPlaceOrderSubmit_Click;
            // 
            // panelProfile
            // 
            panelProfile.BackColor = Color.FromArgb(240, 240, 240);
            panelProfile.Controls.Add(lblProfileTitle);
            panelProfile.Controls.Add(panelProfileLeftCol);
            panelProfile.Controls.Add(panelProfileRightCol);
            panelProfile.Dock = DockStyle.Fill;
            panelProfile.Location = new Point(20, 20);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(1000, 710);
            panelProfile.TabIndex = 3;
            panelProfile.Visible = false;
            // 
            // lblProfileTitle
            // 
            lblProfileTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblProfileTitle.ForeColor = Color.DarkBlue;
            lblProfileTitle.Location = new Point(0, 0);
            lblProfileTitle.Name = "lblProfileTitle";
            lblProfileTitle.Size = new Size(500, 35);
            lblProfileTitle.TabIndex = 0;
            lblProfileTitle.Text = "Hồ Sơ Cá Nhân & Lịch Sử Đơn Hàng";
            // 
            // panelProfileLeftCol
            // 
            panelProfileLeftCol.BackColor = Color.White;
            panelProfileLeftCol.BorderStyle = BorderStyle.FixedSingle;
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
            panelProfileLeftCol.Size = new Size(420, 650);
            panelProfileLeftCol.TabIndex = 1;
            // 
            // lblProfileLeftTitle
            // 
            lblProfileLeftTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProfileLeftTitle.ForeColor = Color.Black;
            lblProfileLeftTitle.Location = new Point(20, 15);
            lblProfileLeftTitle.Name = "lblProfileLeftTitle";
            lblProfileLeftTitle.Size = new Size(200, 20);
            lblProfileLeftTitle.TabIndex = 0;
            lblProfileLeftTitle.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // lblProfUsername
            // 
            lblProfUsername.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblProfUsername.ForeColor = Color.RoyalBlue;
            lblProfUsername.Location = new Point(20, 50);
            lblProfUsername.Name = "lblProfUsername";
            lblProfUsername.Size = new Size(380, 20);
            lblProfUsername.TabIndex = 1;
            lblProfUsername.Text = "Tên tài khoản: user";
            // 
            // lblProfileFullName
            // 
            lblProfileFullName.ForeColor = Color.FromArgb(64, 64, 64);
            lblProfileFullName.Location = new Point(20, 90);
            lblProfileFullName.Name = "lblProfileFullName";
            lblProfileFullName.Size = new Size(380, 18);
            lblProfileFullName.TabIndex = 2;
            lblProfileFullName.Text = "Họ và Tên";
            // 
            // txtProfFullName
            // 
            txtProfFullName.BackColor = Color.White;
            txtProfFullName.BorderStyle = BorderStyle.FixedSingle;
            txtProfFullName.ForeColor = Color.Black;
            txtProfFullName.Location = new Point(20, 110);
            txtProfFullName.Name = "txtProfFullName";
            txtProfFullName.Size = new Size(380, 24);
            txtProfFullName.TabIndex = 3;
            // 
            // lblProfilePhone
            // 
            lblProfilePhone.ForeColor = Color.FromArgb(64, 64, 64);
            lblProfilePhone.Location = new Point(20, 155);
            lblProfilePhone.Name = "lblProfilePhone";
            lblProfilePhone.Size = new Size(380, 18);
            lblProfilePhone.TabIndex = 4;
            lblProfilePhone.Text = "Số Điện Thoại";
            // 
            // txtProfPhone
            // 
            txtProfPhone.BackColor = Color.White;
            txtProfPhone.BorderStyle = BorderStyle.FixedSingle;
            txtProfPhone.ForeColor = Color.Black;
            txtProfPhone.Location = new Point(20, 175);
            txtProfPhone.Name = "txtProfPhone";
            txtProfPhone.Size = new Size(380, 24);
            txtProfPhone.TabIndex = 5;
            // 
            // lblProfileAddress
            // 
            lblProfileAddress.ForeColor = Color.FromArgb(64, 64, 64);
            lblProfileAddress.Location = new Point(20, 220);
            lblProfileAddress.Name = "lblProfileAddress";
            lblProfileAddress.Size = new Size(380, 18);
            lblProfileAddress.TabIndex = 6;
            lblProfileAddress.Text = "Địa Chi Giao Hàng";
            // 
            // txtProfAddress
            // 
            txtProfAddress.BackColor = Color.White;
            txtProfAddress.BorderStyle = BorderStyle.FixedSingle;
            txtProfAddress.ForeColor = Color.Black;
            txtProfAddress.Location = new Point(20, 240);
            txtProfAddress.Multiline = true;
            txtProfAddress.Name = "txtProfAddress";
            txtProfAddress.Size = new Size(380, 80);
            txtProfAddress.TabIndex = 7;
            // 
            // btnProfileSave
            // 
            btnProfileSave.BackColor = Color.RoyalBlue;
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
            btnProfileSave.Click += BtnSaveProfile_Click;
            // 
            // panelProfileRightCol
            // 
            panelProfileRightCol.BackColor = Color.White;
            panelProfileRightCol.BorderStyle = BorderStyle.FixedSingle;
            panelProfileRightCol.Controls.Add(lblProfileRightTitle);
            panelProfileRightCol.Controls.Add(lstOrderHistory);
            panelProfileRightCol.Location = new Point(440, 50);
            panelProfileRightCol.Name = "panelProfileRightCol";
            panelProfileRightCol.Padding = new Padding(20);
            panelProfileRightCol.Size = new Size(560, 650);
            panelProfileRightCol.TabIndex = 2;
            // 
            // lblProfileRightTitle
            // 
            lblProfileRightTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProfileRightTitle.ForeColor = Color.Black;
            lblProfileRightTitle.Location = new Point(20, 15);
            lblProfileRightTitle.Name = "lblProfileRightTitle";
            lblProfileRightTitle.Size = new Size(200, 20);
            lblProfileRightTitle.TabIndex = 0;
            lblProfileRightTitle.Text = "LỊCH SỬ MUA HÀNG";
            // 
            // lstOrderHistory
            // 
            lstOrderHistory.BackColor = Color.White;
            lstOrderHistory.BorderStyle = BorderStyle.FixedSingle;
            lstOrderHistory.Font = new Font("Segoe UI", 9F);
            lstOrderHistory.ForeColor = Color.Black;
            lstOrderHistory.Location = new Point(20, 45);
            lstOrderHistory.Name = "lstOrderHistory";
            lstOrderHistory.Size = new Size(520, 580);
            lstOrderHistory.TabIndex = 1;
            // 
            // panelNews
            // 
            panelNews.BackColor = Color.FromArgb(240, 240, 240);
            panelNews.Controls.Add(lblNewsTitle);
            panelNews.Controls.Add(flpNews);
            panelNews.Dock = DockStyle.Fill;
            panelNews.Location = new Point(20, 20);
            panelNews.Name = "panelNews";
            panelNews.Size = new Size(1000, 710);
            panelNews.TabIndex = 4;
            panelNews.Visible = false;
            // 
            // lblNewsTitle
            // 
            lblNewsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNewsTitle.ForeColor = Color.DarkBlue;
            lblNewsTitle.Location = new Point(0, 0);
            lblNewsTitle.Name = "lblNewsTitle";
            lblNewsTitle.Size = new Size(500, 35);
            lblNewsTitle.TabIndex = 0;
            lblNewsTitle.Text = "Tin Tức Công Nghệ Nổi Bật";
            // 
            // flpNews
            // 
            flpNews.AutoScroll = true;
            flpNews.Location = new Point(0, 50);
            flpNews.Name = "flpNews";
            flpNews.Padding = new Padding(0, 10, 0, 10);
            flpNews.Size = new Size(1000, 650);
            flpNews.TabIndex = 1;
            // 
            // panelAbout
            // 
            panelAbout.BackColor = Color.FromArgb(240, 240, 240);
            panelAbout.Controls.Add(lblAboutTitle);
            panelAbout.Controls.Add(panelAboutLeft);
            panelAbout.Controls.Add(panelAboutRight);
            panelAbout.Dock = DockStyle.Fill;
            panelAbout.Location = new Point(20, 20);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(1000, 710);
            panelAbout.TabIndex = 5;
            panelAbout.Visible = false;
            // 
            // lblAboutTitle
            // 
            lblAboutTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAboutTitle.ForeColor = Color.DarkBlue;
            lblAboutTitle.Location = new Point(0, 0);
            lblAboutTitle.Name = "lblAboutTitle";
            lblAboutTitle.Size = new Size(500, 35);
            lblAboutTitle.TabIndex = 0;
            lblAboutTitle.Text = "Giới Thiệu & Thông Tin Liên Hệ";
            // 
            // panelAboutLeft
            // 
            panelAboutLeft.BackColor = Color.White;
            panelAboutLeft.BorderStyle = BorderStyle.FixedSingle;
            panelAboutLeft.Controls.Add(lblAboutText);
            panelAboutLeft.Location = new Point(0, 50);
            panelAboutLeft.Name = "panelAboutLeft";
            panelAboutLeft.Padding = new Padding(20);
            panelAboutLeft.Size = new Size(480, 650);
            panelAboutLeft.TabIndex = 1;
            // 
            // lblAboutText
            // 
            lblAboutText.Dock = DockStyle.Fill;
            lblAboutText.Font = new Font("Segoe UI", 10.5F);
            lblAboutText.ForeColor = Color.Black;
            lblAboutText.Location = new Point(20, 20);
            lblAboutText.Name = "lblAboutText";
            lblAboutText.Size = new Size(438, 608);
            lblAboutText.TabIndex = 0;
            lblAboutText.Text = "⚡ SIÊU THỊ CÔNG NGHỆ TECHSTORE\r\n\r\nChào mừng quý khách đến với TechStore - Hệ thống bán lẻ điện thoại di động, đồng hồ thông minh và phụ kiện chính hãng hàng đầu tại Việt Nam.\r\n\r\n📍 Địa chỉ cửa hàng:\r\nSố 123 Đường Lê Lợi, Phường Bến Nghé, Quận 1, Thành phố Hồ Chí Minh.\r\n\r\n📞 Hotline hỗ trợ khách hàng:\r\n- Tư vấn mua hàng: 1800.2088 (miễn phí)\r\n- Hỗ trợ kỹ thuật: 1900.2099 (1.000đ/phút)\r\n\r\n✉️ Email liên hệ:\r\ncontact@techstore.com.vn\r\n\r\n⏰ Giờ mở cửa làm việc:\r\nTất cả các ngày trong tuần (kể cả Chủ nhật và ngày Lễ):\r\nTừ 08:00 đến 22:00 hàng ngày.\r\n\r\n🏆 CAM KẾT CỦA CỬA HÀNG:\r\n1. Sản phẩm chính hãng 100%, bảo hành 12 tháng.\r\n2. Hỗ trợ 1 đổi 1 trong 30 ngày nếu có lỗi phần cứng từ nhà sản xuất.\r\n3. Giao hàng siêu tốc tận nhà toàn quốc.";
            // 
            // panelAboutRight
            // 
            panelAboutRight.BackColor = Color.White;
            panelAboutRight.BorderStyle = BorderStyle.FixedSingle;
            panelAboutRight.Controls.Add(lblAboutFormTitle);
            panelAboutRight.Controls.Add(lblAboutName);
            txtAboutName.BackColor = Color.White;
            txtAboutName.BorderStyle = BorderStyle.FixedSingle;
            txtAboutName.ForeColor = Color.Black;
            txtAboutName.Location = new Point(20, 95);
            txtAboutName.Name = "txtAboutName";
            txtAboutName.Size = new Size(440, 24);
            txtAboutName.TabIndex = 2;
            panelAboutRight.Controls.Add(txtAboutName);
            panelAboutRight.Controls.Add(lblAboutEmail);
            txtAboutEmail.BackColor = Color.White;
            txtAboutEmail.BorderStyle = BorderStyle.FixedSingle;
            txtAboutEmail.ForeColor = Color.Black;
            txtAboutEmail.Location = new Point(20, 160);
            txtAboutEmail.Name = "txtAboutEmail";
            txtAboutEmail.Size = new Size(440, 24);
            txtAboutEmail.TabIndex = 4;
            panelAboutRight.Controls.Add(txtAboutEmail);
            panelAboutRight.Controls.Add(lblAboutMsg);
            txtAboutMsg.BackColor = Color.White;
            txtAboutMsg.BorderStyle = BorderStyle.FixedSingle;
            txtAboutMsg.ForeColor = Color.Black;
            txtAboutMsg.Location = new Point(20, 225);
            txtAboutMsg.Multiline = true;
            txtAboutMsg.Name = "txtAboutMsg";
            txtAboutMsg.Size = new Size(440, 180);
            txtAboutMsg.TabIndex = 6;
            panelAboutRight.Controls.Add(txtAboutMsg);
            panelAboutRight.Controls.Add(btnSendAboutMsg);
            panelAboutRight.Location = new Point(500, 50);
            panelAboutRight.Name = "panelAboutRight";
            panelAboutRight.Padding = new Padding(20);
            panelAboutRight.Size = new Size(480, 650);
            panelAboutRight.TabIndex = 2;
            // 
            // lblAboutFormTitle
            // 
            lblAboutFormTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAboutFormTitle.ForeColor = Color.Black;
            lblAboutFormTitle.Location = new Point(20, 15);
            lblAboutFormTitle.Name = "lblAboutFormTitle";
            lblAboutFormTitle.Size = new Size(300, 20);
            lblAboutFormTitle.TabIndex = 0;
            lblAboutFormTitle.Text = "GỬI Ý KIẾN PHẢN HỒI CHO CỬA HÀNG";
            // 
            // lblAboutName
            // 
            lblAboutName.ForeColor = Color.FromArgb(64, 64, 64);
            lblAboutName.Location = new Point(20, 75);
            lblAboutName.Name = "lblAboutName";
            lblAboutName.Size = new Size(440, 18);
            lblAboutName.TabIndex = 1;
            lblAboutName.Text = "Họ và tên người liên hệ *";
            // 
            // lblAboutEmail
            // 
            lblAboutEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblAboutEmail.Location = new Point(20, 140);
            lblAboutEmail.Name = "lblAboutEmail";
            lblAboutEmail.Size = new Size(440, 18);
            lblAboutEmail.TabIndex = 3;
            lblAboutEmail.Text = "Địa chỉ Email liên hệ *";
            // 
            // lblAboutMsg
            // 
            lblAboutMsg.ForeColor = Color.FromArgb(64, 64, 64);
            lblAboutMsg.Location = new Point(20, 205);
            lblAboutMsg.Name = "lblAboutMsg";
            lblAboutMsg.Size = new Size(440, 18);
            lblAboutMsg.TabIndex = 5;
            lblAboutMsg.Text = "Nội dung phản hồi / góp ý *";
            // 
            // btnSendAboutMsg
            // 
            btnSendAboutMsg.BackColor = Color.RoyalBlue;
            btnSendAboutMsg.FlatAppearance.BorderSize = 0;
            btnSendAboutMsg.FlatStyle = FlatStyle.Flat;
            btnSendAboutMsg.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSendAboutMsg.ForeColor = Color.White;
            btnSendAboutMsg.Location = new Point(20, 430);
            btnSendAboutMsg.Name = "btnSendAboutMsg";
            btnSendAboutMsg.Size = new Size(440, 40);
            btnSendAboutMsg.TabIndex = 7;
            btnSendAboutMsg.Text = "GỬI LIÊN HỆ GÓP Ý";
            btnSendAboutMsg.UseVisualStyleBackColor = false;
            btnSendAboutMsg.Click += BtnSendAboutMsg_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1280, 750);
            Controls.Add(panelContent);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 9.5F);
            ForeColor = Color.Black;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechStore - Siêu Thị Điện Thoại & Phụ Kiện";
            panelSidebar.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
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
            panelNews.ResumeLayout(false);
            panelAbout.ResumeLayout(false);
            panelAboutLeft.ResumeLayout(false);
            panelAboutRight.ResumeLayout(false);
            panelAboutRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label lblLogo;
        private Label lblUserInfo;
        private Label lblUserRole;
        private Panel line1;
        private Button btnMenuHome;
        private Button btnMenuApple;
        private Button btnMenuSamsung;
        private Button btnMenuXiaomi;
        private Button btnMenuWatches;
        private Button btnMenuAccessories;
        private Button btnMenuCart;
        private Button btnMenuProfile;
        private Panel line2;
        private Button btnMenuNews;
        private Button btnMenuAbout;
        private Button btnMenuLogout;
        private Panel panelContent;
        
        // 1. Home Panel
        private Panel panelHome;
        private Panel panelHomeHero;
        private Label lblHomeHeroTitle;
        private Label lblHomeHeroSub;
        private Label lblHomeFeaturedHeader;
        private FlowLayoutPanel flpHomeFeatured;
        
        // 2. Shop Panel
        private Panel panelShop;
        private Label lblCategoryTitle;
        private TextBox txtCustomerSearch;
        private FlowLayoutPanel flpProducts;
        
        // 3. Cart Panel
        private Panel panelCartView;
        private Label lblCartTitle;
        private Panel panelCartLeftCol;
        private Label lblCartLeftTitle;
        private FlowLayoutPanel flpCartLines;
        private Label lblCartTotalAmount;
        private Panel panelCartRightCol;
        private Label lblCartRightTitle;
        private Label lblCartCheckoutName;
        private TextBox txtCheckoutName;
        private Label lblCartCheckoutPhone;
        private TextBox txtCheckoutPhone;
        private Label lblCartCheckoutAddress;
        private TextBox txtCheckoutAddress;
        private Label lblCartCheckoutPayment;
        private ComboBox cbCheckoutPayment;
        private Button btnPlaceOrderSubmit;
        
        // 4. Profile Panel
        private Panel panelProfile;
        private Label lblProfileTitle;
        private Panel panelProfileLeftCol;
        private Label lblProfileLeftTitle;
        private Label lblProfUsername;
        private Label lblProfileFullName;
        private TextBox txtProfFullName;
        private Label lblProfilePhone;
        private TextBox txtProfPhone;
        private Label lblProfileAddress;
        private TextBox txtProfAddress;
        private Button btnProfileSave;
        private Panel panelProfileRightCol;
        private Label lblProfileRightTitle;
        private ListBox lstOrderHistory;
        
        // 5. News Panel
        private Panel panelNews;
        private Label lblNewsTitle;
        private FlowLayoutPanel flpNews;
        
        // 6. About Panel
        private Panel panelAbout;
        private Label lblAboutTitle;
        private Panel panelAboutLeft;
        private Label lblAboutText;
        private Panel panelAboutRight;
        private Label lblAboutFormTitle;
        private Label lblAboutName;
        private TextBox txtAboutName;
        private Label lblAboutEmail;
        private TextBox txtAboutEmail;
        private Label lblAboutMsg;
        private TextBox txtAboutMsg;
        private Button btnSendAboutMsg;
    }
}
