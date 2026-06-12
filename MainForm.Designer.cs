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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            panelHome = new Panel();
            panelHomeHero = new Panel();
            lblHomeHeroTitle = new Label();
            lblHomeHeroSub = new Label();
            lblHomeFeaturedHeader = new Label();
            flpHomeFeatured = new FlowLayoutPanel();
            panelShop = new Panel();
            lblCategoryTitle = new Label();
            cbPriceFilter = new ComboBox();
            cbSortFilter = new ComboBox();
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
            lblVoucherTitle = new Label();
            cbVoucher = new ComboBox();
            btnApplyVoucher = new Button();
            lblVoucherDiscount = new Label();
            lblVoucherFinalTotal = new Label();
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
            panelNews = new Panel();
            lblNewsTitle = new Label();
            flpNews = new FlowLayoutPanel();
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
            btnMenuCart.Text = "\U0001f6d2 Giỏ Hàng (0)";
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
            panelContent.Controls.Add(panelCartView);
            panelContent.Controls.Add(panelAbout);
            panelContent.Controls.Add(panelNews);
            panelContent.Controls.Add(panelHome);
            panelContent.Controls.Add(panelShop);
            panelContent.Controls.Add(panelProfile);
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
            panelShop.Controls.Add(cbPriceFilter);
            panelShop.Controls.Add(cbSortFilter);
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
            // cbPriceFilter
            // 
            cbPriceFilter.BackColor = Color.White;
            cbPriceFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPriceFilter.ForeColor = Color.Black;
            cbPriceFilter.Items.AddRange(new object[] { "Tất cả mức giá", "Dưới 10 triệu", "Từ 10 - 20 triệu", "Trên 20 triệu" });
            cbPriceFilter.Location = new Point(410, 5);
            cbPriceFilter.Name = "cbPriceFilter";
            cbPriceFilter.Size = new Size(160, 25);
            cbPriceFilter.TabIndex = 3;
            // 
            // cbSortFilter
            // 
            cbSortFilter.BackColor = Color.White;
            cbSortFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSortFilter.ForeColor = Color.Black;
            cbSortFilter.Items.AddRange(new object[] { "Sắp xếp: Mặc định", "Giá tăng dần 📈", "Giá giảm dần 📉" });
            cbSortFilter.Location = new Point(580, 5);
            cbSortFilter.Name = "cbSortFilter";
            cbSortFilter.Size = new Size(160, 25);
            cbSortFilter.TabIndex = 4;
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
            lblCartTotalAmount.Text = "Tong phu: 60,470,000 d";
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
            panelCartRightCol.Controls.Add(lblVoucherTitle);
            panelCartRightCol.Controls.Add(cbVoucher);
            panelCartRightCol.Controls.Add(btnApplyVoucher);
            panelCartRightCol.Controls.Add(lblVoucherDiscount);
            panelCartRightCol.Controls.Add(lblVoucherFinalTotal);
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
            txtCheckoutName.Text = "Nguyen Van Khach";
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
            txtCheckoutPhone.Text = "0987654321";
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
            txtCheckoutAddress.Text = "456 Duong CMT8, Quan 3, TP.HCM";
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
            // lblVoucherTitle
            // 
            lblVoucherTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblVoucherTitle.Location = new Point(20, 310);
            lblVoucherTitle.Name = "lblVoucherTitle";
            lblVoucherTitle.Size = new Size(360, 18);
            lblVoucherTitle.TabIndex = 9;
            lblVoucherTitle.Text = "Áp dụng mã giảm giá (Voucher)";
            // 
            // cbVoucher
            // 
            cbVoucher.BackColor = Color.White;
            cbVoucher.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVoucher.ForeColor = Color.Black;
            cbVoucher.Items.AddRange(new object[] { "TECH10 - Giam 10%", "APPLE500 - Giam 8%", "FREESHIP - Giam 5%" });
            cbVoucher.Location = new Point(20, 330);
            cbVoucher.Name = "cbVoucher";
            cbVoucher.Size = new Size(230, 25);
            cbVoucher.TabIndex = 10;
            // 
            // btnApplyVoucher
            // 
            btnApplyVoucher.BackColor = Color.FromArgb(240, 240, 240);
            btnApplyVoucher.FlatAppearance.BorderSize = 0;
            btnApplyVoucher.FlatStyle = FlatStyle.Flat;
            btnApplyVoucher.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnApplyVoucher.ForeColor = Color.RoyalBlue;
            btnApplyVoucher.Location = new Point(260, 328);
            btnApplyVoucher.Name = "btnApplyVoucher";
            btnApplyVoucher.Size = new Size(120, 27);
            btnApplyVoucher.TabIndex = 11;
            btnApplyVoucher.Text = "Áp Dụng";
            btnApplyVoucher.UseVisualStyleBackColor = false;
            // 
            // lblVoucherDiscount
            // 
            lblVoucherDiscount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblVoucherDiscount.ForeColor = Color.ForestGreen;
            lblVoucherDiscount.Location = new Point(20, 370);
            lblVoucherDiscount.Name = "lblVoucherDiscount";
            lblVoucherDiscount.Size = new Size(360, 20);
            lblVoucherDiscount.TabIndex = 12;
            lblVoucherDiscount.Text = "Da giam: 500,000 d";
            // 
            // lblVoucherFinalTotal
            // 
            lblVoucherFinalTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblVoucherFinalTotal.ForeColor = Color.Red;
            lblVoucherFinalTotal.Location = new Point(20, 395);
            lblVoucherFinalTotal.Name = "lblVoucherFinalTotal";
            lblVoucherFinalTotal.Size = new Size(360, 22);
            lblVoucherFinalTotal.TabIndex = 13;
            lblVoucherFinalTotal.Text = "Tong thanh toan: 59,970,000 d";
            // 
            // btnPlaceOrderSubmit
            // 
            btnPlaceOrderSubmit.BackColor = Color.RoyalBlue;
            btnPlaceOrderSubmit.FlatAppearance.BorderSize = 0;
            btnPlaceOrderSubmit.FlatStyle = FlatStyle.Flat;
            btnPlaceOrderSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPlaceOrderSubmit.ForeColor = Color.White;
            btnPlaceOrderSubmit.Location = new Point(20, 440);
            btnPlaceOrderSubmit.Name = "btnPlaceOrderSubmit";
            btnPlaceOrderSubmit.Size = new Size(360, 45);
            btnPlaceOrderSubmit.TabIndex = 14;
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
            txtProfFullName.Text = "Nguyen Van Khach";
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
            txtProfPhone.Text = "0987654321";
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
            txtProfAddress.Text = "456 Duong CMT8, Quan 3, TP. Ho Chi Minh";
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
            lstOrderHistory.Items.AddRange(new object[] { "DH182418 | 11/06/2026 | Tai Nghe Sony WH-1000XM5 x1 | 8,490,000 d | Cho xu ly", "DH165802 | 11/06/2026 | Samsung Galaxy Watch6 Classic x1 | 8,490,000 d | Cho xu ly", "DH1024 | 08/06/2026 | Ban Phim Co Keychron K2 Pro x1 | 2,450,000 d | Dang giao" });
            lstOrderHistory.Location = new Point(20, 45);
            lstOrderHistory.Name = "lstOrderHistory";
            lstOrderHistory.Size = new Size(520, 572);
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
            lblAboutText.Text = resources.GetString("lblAboutText.Text");
            // 
            // panelAboutRight
            // 
            panelAboutRight.BackColor = Color.White;
            panelAboutRight.BorderStyle = BorderStyle.FixedSingle;
            panelAboutRight.Controls.Add(lblAboutFormTitle);
            panelAboutRight.Controls.Add(lblAboutName);
            panelAboutRight.Controls.Add(txtAboutName);
            panelAboutRight.Controls.Add(lblAboutEmail);
            panelAboutRight.Controls.Add(txtAboutEmail);
            panelAboutRight.Controls.Add(lblAboutMsg);
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
            // txtAboutName
            // 
            txtAboutName.BackColor = Color.White;
            txtAboutName.BorderStyle = BorderStyle.FixedSingle;
            txtAboutName.ForeColor = Color.Black;
            txtAboutName.Location = new Point(20, 95);
            txtAboutName.Name = "txtAboutName";
            txtAboutName.Size = new Size(440, 24);
            txtAboutName.TabIndex = 2;
            txtAboutName.Text = "Nguyen Van Khach";
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
            // txtAboutEmail
            // 
            txtAboutEmail.BackColor = Color.White;
            txtAboutEmail.BorderStyle = BorderStyle.FixedSingle;
            txtAboutEmail.ForeColor = Color.Black;
            txtAboutEmail.Location = new Point(20, 160);
            txtAboutEmail.Name = "txtAboutEmail";
            txtAboutEmail.Size = new Size(440, 24);
            txtAboutEmail.TabIndex = 4;
            txtAboutEmail.Text = "khachhang@example.com";
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
            // txtAboutMsg
            // 
            txtAboutMsg.BackColor = Color.White;
            txtAboutMsg.BorderStyle = BorderStyle.FixedSingle;
            txtAboutMsg.ForeColor = Color.Black;
            txtAboutMsg.Location = new Point(20, 225);
            txtAboutMsg.Multiline = true;
            txtAboutMsg.Name = "txtAboutMsg";
            txtAboutMsg.Size = new Size(440, 180);
            txtAboutMsg.TabIndex = 6;
            txtAboutMsg.Text = "Toi muon duoc tu van them ve iPhone 15 Pro Max va chuong trinh bao hanh cua TechStore.";
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
            // --- Preview Cards Instantiations ---
            cardFeatured1 = new Panel();
            pbFeatured1 = new PictureBox();
            lblNameFeatured1 = new Label();
            lblPriceFeatured1 = new Label();
            lblStockFeatured1 = new Label();
            btnBuyFeatured1 = new Button();

            cardFeatured2 = new Panel();
            pbFeatured2 = new PictureBox();
            lblNameFeatured2 = new Label();
            lblPriceFeatured2 = new Label();
            lblStockFeatured2 = new Label();
            btnBuyFeatured2 = new Button();

            cardFeatured3 = new Panel();
            pbFeatured3 = new PictureBox();
            lblNameFeatured3 = new Label();
            lblPriceFeatured3 = new Label();
            lblStockFeatured3 = new Label();
            btnBuyFeatured3 = new Button();

            cardShop1 = new Panel();
            pbShop1 = new PictureBox();
            lblNameShop1 = new Label();
            lblPriceShop1 = new Label();
            lblStockShop1 = new Label();
            btnBuyShop1 = new Button();

            cardShop2 = new Panel();
            pbShop2 = new PictureBox();
            lblNameShop2 = new Label();
            lblPriceShop2 = new Label();
            lblStockShop2 = new Label();
            btnBuyShop2 = new Button();

            cardShop3 = new Panel();
            pbShop3 = new PictureBox();
            lblNameShop3 = new Label();
            lblPriceShop3 = new Label();
            lblStockShop3 = new Label();
            btnBuyShop3 = new Button();

            cardShop4 = new Panel();
            pbShop4 = new PictureBox();
            lblNameShop4 = new Label();
            lblPriceShop4 = new Label();
            lblStockShop4 = new Label();
            btnBuyShop4 = new Button();

            rowCart1 = new Panel();
            pbCart1 = new PictureBox();
            lblNameCart1 = new Label();
            lblPriceCart1 = new Label();
            btnMinusCart1 = new Button();
            lblQtyCart1 = new Label();
            btnPlusCart1 = new Button();
            lblRowTotalCart1 = new Label();
            btnRemoveCart1 = new Button();

            rowCart2 = new Panel();
            pbCart2 = new PictureBox();
            lblNameCart2 = new Label();
            lblPriceCart2 = new Label();
            btnMinusCart2 = new Button();
            lblQtyCart2 = new Label();
            btnPlusCart2 = new Button();
            lblRowTotalCart2 = new Label();
            btnRemoveCart2 = new Button();

            rowCart3 = new Panel();
            pbCart3 = new PictureBox();
            lblNameCart3 = new Label();
            lblPriceCart3 = new Label();
            btnMinusCart3 = new Button();
            lblQtyCart3 = new Label();
            btnPlusCart3 = new Button();
            lblRowTotalCart3 = new Label();
            btnRemoveCart3 = new Button();

            cardNews1 = new Panel();
            lblTitleNews1 = new Label();
            lblSummaryNews1 = new Label();
            btnReadMoreNews1 = new Button();

            cardNews2 = new Panel();
            lblTitleNews2 = new Label();
            lblSummaryNews2 = new Label();
            btnReadMoreNews2 = new Button();

            cardNews3 = new Panel();
            lblTitleNews3 = new Label();
            lblSummaryNews3 = new Label();
            btnReadMoreNews3 = new Button();

            // --- Home Featured Preview ---
            cardFeatured1.Size = new Size(270, 310);
            cardFeatured1.BackColor = Color.White;
            cardFeatured1.BorderStyle = BorderStyle.FixedSingle;
            cardFeatured1.Margin = new Padding(0, 0, 25, 25);
            cardFeatured1.Padding = new Padding(12);
            cardFeatured1.Controls.Add(pbFeatured1);
            cardFeatured1.Controls.Add(lblNameFeatured1);
            cardFeatured1.Controls.Add(lblPriceFeatured1);
            cardFeatured1.Controls.Add(lblStockFeatured1);
            cardFeatured1.Controls.Add(btnBuyFeatured1);

            pbFeatured1.Size = new Size(246, 130);
            pbFeatured1.Location = new Point(12, 12);
            pbFeatured1.SizeMode = PictureBoxSizeMode.Zoom;
            pbFeatured1.BackColor = Color.FromArgb(240, 240, 240);
            pbFeatured1.ImageLocation = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?auto=format&fit=crop&w=500&q=80";

            lblNameFeatured1.Text = "iPhone 15 Pro Max 256GB";
            lblNameFeatured1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameFeatured1.ForeColor = Color.Black;
            lblNameFeatured1.Location = new Point(12, 152);
            lblNameFeatured1.Size = new Size(246, 40);
            lblNameFeatured1.AutoEllipsis = true;

            lblPriceFeatured1.Text = "29,990,000 d";
            lblPriceFeatured1.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblPriceFeatured1.ForeColor = Color.Red;
            lblPriceFeatured1.Location = new Point(12, 195);
            lblPriceFeatured1.Size = new Size(130, 25);

            lblStockFeatured1.Text = "Con hang (12)";
            lblStockFeatured1.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblStockFeatured1.ForeColor = Color.FromArgb(16, 185, 129);
            lblStockFeatured1.Location = new Point(12, 225);
            lblStockFeatured1.Size = new Size(246, 20);

            btnBuyFeatured1.Text = "Them vao gio";
            btnBuyFeatured1.Location = new Point(12, 255);
            btnBuyFeatured1.Size = new Size(246, 35);
            btnBuyFeatured1.BackColor = Color.RoyalBlue;
            btnBuyFeatured1.ForeColor = Color.White;
            btnBuyFeatured1.FlatStyle = FlatStyle.Flat;
            btnBuyFeatured1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuyFeatured1.FlatAppearance.BorderSize = 0;

            cardFeatured2.Size = new Size(270, 310);
            cardFeatured2.BackColor = Color.White;
            cardFeatured2.BorderStyle = BorderStyle.FixedSingle;
            cardFeatured2.Margin = new Padding(0, 0, 25, 25);
            cardFeatured2.Padding = new Padding(12);
            cardFeatured2.Controls.Add(pbFeatured2);
            cardFeatured2.Controls.Add(lblNameFeatured2);
            cardFeatured2.Controls.Add(lblPriceFeatured2);
            cardFeatured2.Controls.Add(lblStockFeatured2);
            cardFeatured2.Controls.Add(btnBuyFeatured2);

            pbFeatured2.Size = new Size(246, 130);
            pbFeatured2.Location = new Point(12, 12);
            pbFeatured2.SizeMode = PictureBoxSizeMode.Zoom;
            pbFeatured2.BackColor = Color.FromArgb(240, 240, 240);
            pbFeatured2.ImageLocation = "https://images.unsplash.com/photo-1616348436168-de43ad0db179?auto=format&fit=crop&w=500&q=80";

            lblNameFeatured2.Text = "iPhone 14 128GB Black";
            lblNameFeatured2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameFeatured2.ForeColor = Color.Black;
            lblNameFeatured2.Location = new Point(12, 152);
            lblNameFeatured2.Size = new Size(246, 40);
            lblNameFeatured2.AutoEllipsis = true;

            lblPriceFeatured2.Text = "18,490,000 d";
            lblPriceFeatured2.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblPriceFeatured2.ForeColor = Color.Red;
            lblPriceFeatured2.Location = new Point(12, 195);
            lblPriceFeatured2.Size = new Size(130, 25);

            lblStockFeatured2.Text = "Con hang (6)";
            lblStockFeatured2.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblStockFeatured2.ForeColor = Color.FromArgb(16, 185, 129);
            lblStockFeatured2.Location = new Point(12, 225);
            lblStockFeatured2.Size = new Size(246, 20);

            btnBuyFeatured2.Text = "Them vao gio";
            btnBuyFeatured2.Location = new Point(12, 255);
            btnBuyFeatured2.Size = new Size(246, 35);
            btnBuyFeatured2.BackColor = Color.RoyalBlue;
            btnBuyFeatured2.ForeColor = Color.White;
            btnBuyFeatured2.FlatStyle = FlatStyle.Flat;
            btnBuyFeatured2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuyFeatured2.FlatAppearance.BorderSize = 0;

            cardFeatured3.Size = new Size(270, 310);
            cardFeatured3.BackColor = Color.White;
            cardFeatured3.BorderStyle = BorderStyle.FixedSingle;
            cardFeatured3.Margin = new Padding(0, 0, 25, 25);
            cardFeatured3.Padding = new Padding(12);
            cardFeatured3.Controls.Add(pbFeatured3);
            cardFeatured3.Controls.Add(lblNameFeatured3);
            cardFeatured3.Controls.Add(lblPriceFeatured3);
            cardFeatured3.Controls.Add(lblStockFeatured3);
            cardFeatured3.Controls.Add(btnBuyFeatured3);

            pbFeatured3.Size = new Size(246, 130);
            pbFeatured3.Location = new Point(12, 12);
            pbFeatured3.SizeMode = PictureBoxSizeMode.Zoom;
            pbFeatured3.BackColor = Color.FromArgb(240, 240, 240);
            pbFeatured3.ImageLocation = "https://images.unsplash.com/photo-1510557880182-3d4d3cba35a5?auto=format&fit=crop&w=500&q=80";

            lblNameFeatured3.Text = "iPhone 15 128GB Yellow";
            lblNameFeatured3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameFeatured3.ForeColor = Color.Black;
            lblNameFeatured3.Location = new Point(12, 152);
            lblNameFeatured3.Size = new Size(246, 40);
            lblNameFeatured3.AutoEllipsis = true;

            lblPriceFeatured3.Text = "19,990,000 d";
            lblPriceFeatured3.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblPriceFeatured3.ForeColor = Color.Red;
            lblPriceFeatured3.Location = new Point(12, 195);
            lblPriceFeatured3.Size = new Size(130, 25);

            lblStockFeatured3.Text = "Con hang (8)";
            lblStockFeatured3.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblStockFeatured3.ForeColor = Color.FromArgb(16, 185, 129);
            lblStockFeatured3.Location = new Point(12, 225);
            lblStockFeatured3.Size = new Size(246, 20);

            btnBuyFeatured3.Text = "Them vao gio";
            btnBuyFeatured3.Location = new Point(12, 255);
            btnBuyFeatured3.Size = new Size(246, 35);
            btnBuyFeatured3.BackColor = Color.RoyalBlue;
            btnBuyFeatured3.ForeColor = Color.White;
            btnBuyFeatured3.FlatStyle = FlatStyle.Flat;
            btnBuyFeatured3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuyFeatured3.FlatAppearance.BorderSize = 0;

            flpHomeFeatured.Controls.Add(cardFeatured1);
            flpHomeFeatured.Controls.Add(cardFeatured2);
            flpHomeFeatured.Controls.Add(cardFeatured3);

            // --- Storefront Preview ---
            cardShop1.Size = new Size(270, 310);
            cardShop1.BackColor = Color.White;
            cardShop1.BorderStyle = BorderStyle.FixedSingle;
            cardShop1.Margin = new Padding(0, 0, 25, 25);
            cardShop1.Padding = new Padding(12);
            cardShop1.Controls.Add(pbShop1);
            cardShop1.Controls.Add(lblNameShop1);
            cardShop1.Controls.Add(lblPriceShop1);
            cardShop1.Controls.Add(lblStockShop1);
            cardShop1.Controls.Add(btnBuyShop1);

            pbShop1.Size = new Size(246, 130);
            pbShop1.Location = new Point(12, 12);
            pbShop1.SizeMode = PictureBoxSizeMode.Zoom;
            pbShop1.BackColor = Color.FromArgb(240, 240, 240);
            pbShop1.ImageLocation = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?auto=format&fit=crop&w=500&q=80";

            lblNameShop1.Text = "iPhone 15 Pro Max 256GB";
            lblNameShop1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameShop1.ForeColor = Color.Black;
            lblNameShop1.Location = new Point(12, 152);
            lblNameShop1.Size = new Size(246, 40);
            lblNameShop1.AutoEllipsis = true;

            lblPriceShop1.Text = "29,990,000 d";
            lblPriceShop1.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblPriceShop1.ForeColor = Color.Red;
            lblPriceShop1.Location = new Point(12, 195);
            lblPriceShop1.Size = new Size(130, 25);

            lblStockShop1.Text = "Con hang (12)";
            lblStockShop1.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblStockShop1.ForeColor = Color.FromArgb(16, 185, 129);
            lblStockShop1.Location = new Point(12, 225);
            lblStockShop1.Size = new Size(246, 20);

            btnBuyShop1.Text = "Them vao gio";
            btnBuyShop1.Location = new Point(12, 255);
            btnBuyShop1.Size = new Size(246, 35);
            btnBuyShop1.BackColor = Color.RoyalBlue;
            btnBuyShop1.ForeColor = Color.White;
            btnBuyShop1.FlatStyle = FlatStyle.Flat;
            btnBuyShop1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuyShop1.FlatAppearance.BorderSize = 0;

            cardShop2.Size = new Size(270, 310);
            cardShop2.BackColor = Color.White;
            cardShop2.BorderStyle = BorderStyle.FixedSingle;
            cardShop2.Margin = new Padding(0, 0, 25, 25);
            cardShop2.Padding = new Padding(12);
            cardShop2.Controls.Add(pbShop2);
            cardShop2.Controls.Add(lblNameShop2);
            cardShop2.Controls.Add(lblPriceShop2);
            cardShop2.Controls.Add(lblStockShop2);
            cardShop2.Controls.Add(btnBuyShop2);

            pbShop2.Size = new Size(246, 130);
            pbShop2.Location = new Point(12, 12);
            pbShop2.SizeMode = PictureBoxSizeMode.Zoom;
            pbShop2.BackColor = Color.FromArgb(240, 240, 240);
            pbShop2.ImageLocation = "https://images.unsplash.com/photo-1616348436168-de43ad0db179?auto=format&fit=crop&w=500&q=80";

            lblNameShop2.Text = "iPhone 14 128GB Black";
            lblNameShop2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameShop2.ForeColor = Color.Black;
            lblNameShop2.Location = new Point(12, 152);
            lblNameShop2.Size = new Size(246, 40);
            lblNameShop2.AutoEllipsis = true;

            lblPriceShop2.Text = "18,490,000 d";
            lblPriceShop2.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblPriceShop2.ForeColor = Color.Red;
            lblPriceShop2.Location = new Point(12, 195);
            lblPriceShop2.Size = new Size(130, 25);

            lblStockShop2.Text = "Con hang (6)";
            lblStockShop2.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblStockShop2.ForeColor = Color.FromArgb(16, 185, 129);
            lblStockShop2.Location = new Point(12, 225);
            lblStockShop2.Size = new Size(246, 20);

            btnBuyShop2.Text = "Them vao gio";
            btnBuyShop2.Location = new Point(12, 255);
            btnBuyShop2.Size = new Size(246, 35);
            btnBuyShop2.BackColor = Color.RoyalBlue;
            btnBuyShop2.ForeColor = Color.White;
            btnBuyShop2.FlatStyle = FlatStyle.Flat;
            btnBuyShop2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuyShop2.FlatAppearance.BorderSize = 0;

            cardShop3.Size = new Size(270, 310);
            cardShop3.BackColor = Color.White;
            cardShop3.BorderStyle = BorderStyle.FixedSingle;
            cardShop3.Margin = new Padding(0, 0, 25, 25);
            cardShop3.Padding = new Padding(12);
            cardShop3.Controls.Add(pbShop3);
            cardShop3.Controls.Add(lblNameShop3);
            cardShop3.Controls.Add(lblPriceShop3);
            cardShop3.Controls.Add(lblStockShop3);
            cardShop3.Controls.Add(btnBuyShop3);

            pbShop3.Size = new Size(246, 130);
            pbShop3.Location = new Point(12, 12);
            pbShop3.SizeMode = PictureBoxSizeMode.Zoom;
            pbShop3.BackColor = Color.FromArgb(240, 240, 240);
            pbShop3.ImageLocation = "https://images.unsplash.com/photo-1510557880182-3d4d3cba35a5?auto=format&fit=crop&w=500&q=80";

            lblNameShop3.Text = "iPhone 15 128GB Yellow";
            lblNameShop3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameShop3.ForeColor = Color.Black;
            lblNameShop3.Location = new Point(12, 152);
            lblNameShop3.Size = new Size(246, 40);
            lblNameShop3.AutoEllipsis = true;

            lblPriceShop3.Text = "19,990,000 d";
            lblPriceShop3.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblPriceShop3.ForeColor = Color.Red;
            lblPriceShop3.Location = new Point(12, 195);
            lblPriceShop3.Size = new Size(130, 25);

            lblStockShop3.Text = "Con hang (8)";
            lblStockShop3.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblStockShop3.ForeColor = Color.FromArgb(16, 185, 129);
            lblStockShop3.Location = new Point(12, 225);
            lblStockShop3.Size = new Size(246, 20);

            btnBuyShop3.Text = "Them vao gio";
            btnBuyShop3.Location = new Point(12, 255);
            btnBuyShop3.Size = new Size(246, 35);
            btnBuyShop3.BackColor = Color.RoyalBlue;
            btnBuyShop3.ForeColor = Color.White;
            btnBuyShop3.FlatStyle = FlatStyle.Flat;
            btnBuyShop3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuyShop3.FlatAppearance.BorderSize = 0;

            cardShop4.Size = new Size(270, 310);
            cardShop4.BackColor = Color.White;
            cardShop4.BorderStyle = BorderStyle.FixedSingle;
            cardShop4.Margin = new Padding(0, 0, 25, 25);
            cardShop4.Padding = new Padding(12);
            cardShop4.Controls.Add(pbShop4);
            cardShop4.Controls.Add(lblNameShop4);
            cardShop4.Controls.Add(lblPriceShop4);
            cardShop4.Controls.Add(lblStockShop4);
            cardShop4.Controls.Add(btnBuyShop4);

            pbShop4.Size = new Size(246, 130);
            pbShop4.Location = new Point(12, 12);
            pbShop4.SizeMode = PictureBoxSizeMode.Zoom;
            pbShop4.BackColor = Color.FromArgb(240, 240, 240);
            pbShop4.ImageLocation = "https://images.unsplash.com/photo-1512499617640-c74ae3a79d37?auto=format&fit=crop&w=500&q=80";

            lblNameShop4.Text = "iPhone 13 128GB Blue";
            lblNameShop4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNameShop4.ForeColor = Color.Black;
            lblNameShop4.Location = new Point(12, 152);
            lblNameShop4.Size = new Size(246, 40);
            lblNameShop4.AutoEllipsis = true;

            lblPriceShop4.Text = "13,990,000 d";
            lblPriceShop4.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblPriceShop4.ForeColor = Color.Red;
            lblPriceShop4.Location = new Point(12, 195);
            lblPriceShop4.Size = new Size(130, 25);

            lblStockShop4.Text = "Con hang (10)";
            lblStockShop4.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblStockShop4.ForeColor = Color.FromArgb(16, 185, 129);
            lblStockShop4.Location = new Point(12, 225);
            lblStockShop4.Size = new Size(246, 20);

            btnBuyShop4.Text = "Them vao gio";
            btnBuyShop4.Location = new Point(12, 255);
            btnBuyShop4.Size = new Size(246, 35);
            btnBuyShop4.BackColor = Color.RoyalBlue;
            btnBuyShop4.ForeColor = Color.White;
            btnBuyShop4.FlatStyle = FlatStyle.Flat;
            btnBuyShop4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuyShop4.FlatAppearance.BorderSize = 0;

            flpProducts.Controls.Add(cardShop1);
            flpProducts.Controls.Add(cardShop2);
            flpProducts.Controls.Add(cardShop3);
            flpProducts.Controls.Add(cardShop4);

            // --- Cart Lines Preview ---
            rowCart1.Size = new Size(520, 75);
            rowCart1.Margin = new Padding(0, 0, 0, 10);
            rowCart1.BackColor = Color.FromArgb(240, 240, 240);
            rowCart1.Controls.Add(pbCart1);
            rowCart1.Controls.Add(lblNameCart1);
            rowCart1.Controls.Add(lblPriceCart1);
            rowCart1.Controls.Add(btnMinusCart1);
            rowCart1.Controls.Add(lblQtyCart1);
            rowCart1.Controls.Add(btnPlusCart1);
            rowCart1.Controls.Add(lblRowTotalCart1);
            rowCart1.Controls.Add(btnRemoveCart1);

            pbCart1.Size = new Size(60, 60);
            pbCart1.Location = new Point(10, 8);
            pbCart1.SizeMode = PictureBoxSizeMode.Zoom;
            pbCart1.BackColor = Color.White;
            pbCart1.ImageLocation = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?auto=format&fit=crop&w=500&q=80";

            lblNameCart1.Text = "iPhone 15 Pro Max 256GB";
            lblNameCart1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNameCart1.Location = new Point(80, 10);
            lblNameCart1.Size = new Size(230, 20);
            lblNameCart1.AutoEllipsis = true;

            lblPriceCart1.Text = "29,990,000 d";
            lblPriceCart1.Font = new Font("Segoe UI", 8.5F);
            lblPriceCart1.ForeColor = Color.ForestGreen;
            lblPriceCart1.Location = new Point(80, 32);
            lblPriceCart1.Size = new Size(180, 18);

            btnMinusCart1.Text = "-";
            btnMinusCart1.Size = new Size(24, 24);
            btnMinusCart1.Location = new Point(320, 25);
            btnMinusCart1.FlatStyle = FlatStyle.Flat;
            btnMinusCart1.BackColor = Color.White;
            btnMinusCart1.FlatAppearance.BorderSize = 0;

            lblQtyCart1.Text = "1";
            lblQtyCart1.Location = new Point(345, 27);
            lblQtyCart1.Size = new Size(30, 20);
            lblQtyCart1.TextAlign = ContentAlignment.MiddleCenter;
            lblQtyCart1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            btnPlusCart1.Text = "+";
            btnPlusCart1.Size = new Size(24, 24);
            btnPlusCart1.Location = new Point(375, 25);
            btnPlusCart1.FlatStyle = FlatStyle.Flat;
            btnPlusCart1.BackColor = Color.White;
            btnPlusCart1.FlatAppearance.BorderSize = 0;

            lblRowTotalCart1.Text = "29,990,000 d";
            lblRowTotalCart1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRowTotalCart1.ForeColor = Color.RoyalBlue;
            lblRowTotalCart1.Location = new Point(410, 27);
            lblRowTotalCart1.Size = new Size(80, 20);
            lblRowTotalCart1.TextAlign = ContentAlignment.MiddleRight;

            btnRemoveCart1.Text = "x";
            btnRemoveCart1.Size = new Size(24, 24);
            btnRemoveCart1.Location = new Point(495, 25);
            btnRemoveCart1.FlatStyle = FlatStyle.Flat;
            btnRemoveCart1.ForeColor = Color.Red;
            btnRemoveCart1.FlatAppearance.BorderSize = 0;

            rowCart2.Size = new Size(520, 75);
            rowCart2.Margin = new Padding(0, 0, 0, 10);
            rowCart2.BackColor = Color.FromArgb(240, 240, 240);
            rowCart2.Controls.Add(pbCart2);
            rowCart2.Controls.Add(lblNameCart2);
            rowCart2.Controls.Add(lblPriceCart2);
            rowCart2.Controls.Add(btnMinusCart2);
            rowCart2.Controls.Add(lblQtyCart2);
            rowCart2.Controls.Add(btnPlusCart2);
            rowCart2.Controls.Add(lblRowTotalCart2);
            rowCart2.Controls.Add(btnRemoveCart2);

            pbCart2.Size = new Size(60, 60);
            pbCart2.Location = new Point(10, 8);
            pbCart2.SizeMode = PictureBoxSizeMode.Zoom;
            pbCart2.BackColor = Color.White;
            pbCart2.ImageLocation = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?auto=format&fit=crop&w=500&q=80";

            lblNameCart2.Text = "Tai Nghe Sony WH-1000XM5";
            lblNameCart2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNameCart2.Location = new Point(80, 10);
            lblNameCart2.Size = new Size(230, 20);
            lblNameCart2.AutoEllipsis = true;

            lblPriceCart2.Text = "8,490,000 d";
            lblPriceCart2.Font = new Font("Segoe UI", 8.5F);
            lblPriceCart2.ForeColor = Color.ForestGreen;
            lblPriceCart2.Location = new Point(80, 32);
            lblPriceCart2.Size = new Size(180, 18);

            btnMinusCart2.Text = "-";
            btnMinusCart2.Size = new Size(24, 24);
            btnMinusCart2.Location = new Point(320, 25);
            btnMinusCart2.FlatStyle = FlatStyle.Flat;
            btnMinusCart2.BackColor = Color.White;
            btnMinusCart2.FlatAppearance.BorderSize = 0;

            lblQtyCart2.Text = "1";
            lblQtyCart2.Location = new Point(345, 27);
            lblQtyCart2.Size = new Size(30, 20);
            lblQtyCart2.TextAlign = ContentAlignment.MiddleCenter;
            lblQtyCart2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            btnPlusCart2.Text = "+";
            btnPlusCart2.Size = new Size(24, 24);
            btnPlusCart2.Location = new Point(375, 25);
            btnPlusCart2.FlatStyle = FlatStyle.Flat;
            btnPlusCart2.BackColor = Color.White;
            btnPlusCart2.FlatAppearance.BorderSize = 0;

            lblRowTotalCart2.Text = "8,490,000 d";
            lblRowTotalCart2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRowTotalCart2.ForeColor = Color.RoyalBlue;
            lblRowTotalCart2.Location = new Point(410, 27);
            lblRowTotalCart2.Size = new Size(80, 20);
            lblRowTotalCart2.TextAlign = ContentAlignment.MiddleRight;

            btnRemoveCart2.Text = "x";
            btnRemoveCart2.Size = new Size(24, 24);
            btnRemoveCart2.Location = new Point(495, 25);
            btnRemoveCart2.FlatStyle = FlatStyle.Flat;
            btnRemoveCart2.ForeColor = Color.Red;
            btnRemoveCart2.FlatAppearance.BorderSize = 0;

            rowCart3.Size = new Size(520, 75);
            rowCart3.Margin = new Padding(0, 0, 0, 10);
            rowCart3.BackColor = Color.FromArgb(240, 240, 240);
            rowCart3.Controls.Add(pbCart3);
            rowCart3.Controls.Add(lblNameCart3);
            rowCart3.Controls.Add(lblPriceCart3);
            rowCart3.Controls.Add(btnMinusCart3);
            rowCart3.Controls.Add(lblQtyCart3);
            rowCart3.Controls.Add(btnPlusCart3);
            rowCart3.Controls.Add(lblRowTotalCart3);
            rowCart3.Controls.Add(btnRemoveCart3);

            pbCart3.Size = new Size(60, 60);
            pbCart3.Location = new Point(10, 8);
            pbCart3.SizeMode = PictureBoxSizeMode.Zoom;
            pbCart3.BackColor = Color.White;
            pbCart3.ImageLocation = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?auto=format&fit=crop&w=500&q=80";

            lblNameCart3.Text = "Apple Watch Ultra 2 Titan";
            lblNameCart3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNameCart3.Location = new Point(80, 10);
            lblNameCart3.Size = new Size(230, 20);
            lblNameCart3.AutoEllipsis = true;

            lblPriceCart3.Text = "21,990,000 d";
            lblPriceCart3.Font = new Font("Segoe UI", 8.5F);
            lblPriceCart3.ForeColor = Color.ForestGreen;
            lblPriceCart3.Location = new Point(80, 32);
            lblPriceCart3.Size = new Size(180, 18);

            btnMinusCart3.Text = "-";
            btnMinusCart3.Size = new Size(24, 24);
            btnMinusCart3.Location = new Point(320, 25);
            btnMinusCart3.FlatStyle = FlatStyle.Flat;
            btnMinusCart3.BackColor = Color.White;
            btnMinusCart3.FlatAppearance.BorderSize = 0;

            lblQtyCart3.Text = "1";
            lblQtyCart3.Location = new Point(345, 27);
            lblQtyCart3.Size = new Size(30, 20);
            lblQtyCart3.TextAlign = ContentAlignment.MiddleCenter;
            lblQtyCart3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            btnPlusCart3.Text = "+";
            btnPlusCart3.Size = new Size(24, 24);
            btnPlusCart3.Location = new Point(375, 25);
            btnPlusCart3.FlatStyle = FlatStyle.Flat;
            btnPlusCart3.BackColor = Color.White;
            btnPlusCart3.FlatAppearance.BorderSize = 0;

            lblRowTotalCart3.Text = "21,990,000 d";
            lblRowTotalCart3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRowTotalCart3.ForeColor = Color.RoyalBlue;
            lblRowTotalCart3.Location = new Point(410, 27);
            lblRowTotalCart3.Size = new Size(80, 20);
            lblRowTotalCart3.TextAlign = ContentAlignment.MiddleRight;

            btnRemoveCart3.Text = "x";
            btnRemoveCart3.Size = new Size(24, 24);
            btnRemoveCart3.Location = new Point(495, 25);
            btnRemoveCart3.FlatStyle = FlatStyle.Flat;
            btnRemoveCart3.ForeColor = Color.Red;
            btnRemoveCart3.FlatAppearance.BorderSize = 0;

            flpCartLines.Controls.Add(rowCart1);
            flpCartLines.Controls.Add(rowCart2);
            flpCartLines.Controls.Add(rowCart3);

            // --- News Cards Preview ---
            cardNews1.Size = new Size(310, 220);
            cardNews1.BackColor = Color.White;
            cardNews1.BorderStyle = BorderStyle.FixedSingle;
            cardNews1.Margin = new Padding(0, 0, 20, 20);
            cardNews1.Padding = new Padding(12);
            cardNews1.Controls.Add(lblTitleNews1);
            cardNews1.Controls.Add(lblSummaryNews1);
            cardNews1.Controls.Add(btnReadMoreNews1);

            lblTitleNews1.Text = "Danh gia chi tiet iPhone 15 Pro Max sau 6 thang su dung";
            lblTitleNews1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleNews1.ForeColor = Color.RoyalBlue;
            lblTitleNews1.Location = new Point(12, 12);
            lblTitleNews1.Size = new Size(286, 45);
            lblTitleNews1.AutoEllipsis = true;

            lblSummaryNews1.Text = "Lieu bo khung vien Titan cao cap cung camera zoom quang hoc 5x co thuc su xung dang voi so tien dau tu gan 30 trieu dong? Hay cung chung toi danh gia lai nhung uu nhuoc diem thuc te.";
            lblSummaryNews1.Font = new Font("Segoe UI", 8.5F);
            lblSummaryNews1.ForeColor = Color.FromArgb(64, 64, 64);
            lblSummaryNews1.Location = new Point(12, 65);
            lblSummaryNews1.Size = new Size(286, 95);
            lblSummaryNews1.AutoEllipsis = true;

            btnReadMoreNews1.Text = "Doc Chi Tiet ->";
            btnReadMoreNews1.Location = new Point(12, 170);
            btnReadMoreNews1.Size = new Size(286, 32);
            btnReadMoreNews1.BackColor = Color.FromArgb(240, 240, 240);
            btnReadMoreNews1.ForeColor = Color.RoyalBlue;
            btnReadMoreNews1.FlatStyle = FlatStyle.Flat;
            btnReadMoreNews1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnReadMoreNews1.FlatAppearance.BorderSize = 0;

            cardNews2.Size = new Size(310, 220);
            cardNews2.BackColor = Color.White;
            cardNews2.BorderStyle = BorderStyle.FixedSingle;
            cardNews2.Margin = new Padding(0, 0, 20, 20);
            cardNews2.Padding = new Padding(12);
            cardNews2.Controls.Add(lblTitleNews2);
            cardNews2.Controls.Add(lblSummaryNews2);
            cardNews2.Controls.Add(btnReadMoreNews2);

            lblTitleNews2.Text = "Samsung cap nhat loat tinh nang Galaxy AI tieng Viet sieu xin";
            lblTitleNews2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleNews2.ForeColor = Color.RoyalBlue;
            lblTitleNews2.Location = new Point(12, 12);
            lblTitleNews2.Size = new Size(286, 45);
            lblTitleNews2.AutoEllipsis = true;

            lblSummaryNews2.Text = "Ban cap nhat One UI moi nhat mang den tinh nang Live Translate (phien dich cuoc goi thoi gian thuc) va tro ly chat thong minh ho tro tron ven ngon ngu Tieng Viet cho cac dong S23 va Z Fold5.";
            lblSummaryNews2.Font = new Font("Segoe UI", 8.5F);
            lblSummaryNews2.ForeColor = Color.FromArgb(64, 64, 64);
            lblSummaryNews2.Location = new Point(12, 65);
            lblSummaryNews2.Size = new Size(286, 95);
            lblSummaryNews2.AutoEllipsis = true;

            btnReadMoreNews2.Text = "Doc Chi Tiet ->";
            btnReadMoreNews2.Location = new Point(12, 170);
            btnReadMoreNews2.Size = new Size(286, 32);
            btnReadMoreNews2.BackColor = Color.FromArgb(240, 240, 240);
            btnReadMoreNews2.ForeColor = Color.RoyalBlue;
            btnReadMoreNews2.FlatStyle = FlatStyle.Flat;
            btnReadMoreNews2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnReadMoreNews2.FlatAppearance.BorderSize = 0;

            cardNews3.Size = new Size(310, 220);
            cardNews3.BackColor = Color.White;
            cardNews3.BorderStyle = BorderStyle.FixedSingle;
            cardNews3.Margin = new Padding(0, 0, 20, 20);
            cardNews3.Padding = new Padding(12);
            cardNews3.Controls.Add(lblTitleNews3);
            cardNews3.Controls.Add(lblSummaryNews3);
            cardNews3.Controls.Add(btnReadMoreNews3);

            lblTitleNews3.Text = "Ro ri thiet ke tai nghe Sony WH-1000XM6 cuc sang xin min";
            lblTitleNews3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitleNews3.ForeColor = Color.RoyalBlue;
            lblTitleNews3.Location = new Point(12, 12);
            lblTitleNews3.Size = new Size(286, 45);
            lblTitleNews3.AutoEllipsis = true;

            lblSummaryNews3.Text = "Nhieu nguon tin ro ri uy tin cho thay mau tai nghe over-ear chong on chu dong dau bang tiep theo cua Sony se co thay doi lon ve ngoai hinh gap gon va chip chong on ANC the he moi.";
            lblSummaryNews3.Font = new Font("Segoe UI", 8.5F);
            lblSummaryNews3.ForeColor = Color.FromArgb(64, 64, 64);
            lblSummaryNews3.Location = new Point(12, 65);
            lblSummaryNews3.Size = new Size(286, 95);
            lblSummaryNews3.AutoEllipsis = true;

            btnReadMoreNews3.Text = "Doc Chi Tiet ->";
            btnReadMoreNews3.Location = new Point(12, 170);
            btnReadMoreNews3.Size = new Size(286, 32);
            btnReadMoreNews3.BackColor = Color.FromArgb(240, 240, 240);
            btnReadMoreNews3.ForeColor = Color.RoyalBlue;
            btnReadMoreNews3.FlatStyle = FlatStyle.Flat;
            btnReadMoreNews3.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnReadMoreNews3.FlatAppearance.BorderSize = 0;

            flpNews.Controls.Add(cardNews1);
            flpNews.Controls.Add(cardNews2);
            flpNews.Controls.Add(cardNews3);

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
        private ComboBox cbPriceFilter;
        private ComboBox cbSortFilter;
        
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
        private Label lblVoucherTitle;
        private ComboBox cbVoucher;
        private Button btnApplyVoucher;
        private Label lblVoucherDiscount;
        private Label lblVoucherFinalTotal;
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

        // Home Panel Preview Cards
        private Panel cardFeatured1;
        private PictureBox pbFeatured1;
        private Label lblNameFeatured1;
        private Label lblPriceFeatured1;
        private Label lblStockFeatured1;
        private Button btnBuyFeatured1;
        private Panel cardFeatured2;
        private PictureBox pbFeatured2;
        private Label lblNameFeatured2;
        private Label lblPriceFeatured2;
        private Label lblStockFeatured2;
        private Button btnBuyFeatured2;
        private Panel cardFeatured3;
        private PictureBox pbFeatured3;
        private Label lblNameFeatured3;
        private Label lblPriceFeatured3;
        private Label lblStockFeatured3;
        private Button btnBuyFeatured3;

        // Shop Panel Preview Cards
        private Panel cardShop1;
        private PictureBox pbShop1;
        private Label lblNameShop1;
        private Label lblPriceShop1;
        private Label lblStockShop1;
        private Button btnBuyShop1;
        private Panel cardShop2;
        private PictureBox pbShop2;
        private Label lblNameShop2;
        private Label lblPriceShop2;
        private Label lblStockShop2;
        private Button btnBuyShop2;
        private Panel cardShop3;
        private PictureBox pbShop3;
        private Label lblNameShop3;
        private Label lblPriceShop3;
        private Label lblStockShop3;
        private Button btnBuyShop3;
        private Panel cardShop4;
        private PictureBox pbShop4;
        private Label lblNameShop4;
        private Label lblPriceShop4;
        private Label lblStockShop4;
        private Button btnBuyShop4;

        // Cart Panel Preview Rows
        private Panel rowCart1;
        private PictureBox pbCart1;
        private Label lblNameCart1;
        private Label lblPriceCart1;
        private Button btnMinusCart1;
        private Label lblQtyCart1;
        private Button btnPlusCart1;
        private Label lblRowTotalCart1;
        private Button btnRemoveCart1;
        private Panel rowCart2;
        private PictureBox pbCart2;
        private Label lblNameCart2;
        private Label lblPriceCart2;
        private Button btnMinusCart2;
        private Label lblQtyCart2;
        private Button btnPlusCart2;
        private Label lblRowTotalCart2;
        private Button btnRemoveCart2;
        private Panel rowCart3;
        private PictureBox pbCart3;
        private Label lblNameCart3;
        private Label lblPriceCart3;
        private Button btnMinusCart3;
        private Label lblQtyCart3;
        private Button btnPlusCart3;
        private Label lblRowTotalCart3;
        private Button btnRemoveCart3;

        // News Panel Preview Cards
        private Panel cardNews1;
        private Label lblTitleNews1;
        private Label lblSummaryNews1;
        private Button btnReadMoreNews1;
        private Panel cardNews2;
        private Label lblTitleNews2;
        private Label lblSummaryNews2;
        private Button btnReadMoreNews2;
        private Panel cardNews3;
        private Label lblTitleNews3;
        private Label lblSummaryNews3;
        private Button btnReadMoreNews3;
    }
}
