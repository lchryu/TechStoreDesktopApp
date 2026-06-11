using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TechStoreWinApp
{
    public class UserAccount
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Role { get; set; } = "customer"; // "customer" or "admin"
        public string SecurityQuestion { get; set; } = string.Empty;
        public string SecurityAnswer { get; set; } = string.Empty;
        public List<UserOrder> OrderHistory { get; set; } = new List<UserOrder>();
    }

    public class UserOrder
    {
        public string OrderId { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public string ItemsSummary { get; set; } = string.Empty;
        public string Status { get; set; } = "Thành công";
    }

    public class Product
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; // "laptop", "phone_apple", "phone_samsung", "phone_xiaomi", "watch", "accessory"
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Specs { get; set; } = new List<string>();
    }

    public class CartItem
    {
        public string ProductId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }

    public class Voucher
    {
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal DiscountPercent { get; set; }
        public decimal MaxDiscount { get; set; }
    }

    public class Feedback
    {
        public string Id { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Status { get; set; } = "Chờ xử lý"; // "Chờ xử lý" or "Đã giải quyết"
    }

    public class SystemSettings
    {
        public string StoreName { get; set; } = "TechStore";
        public string Hotline { get; set; } = "1900-1234";
        public string Email { get; set; } = "support@techstore.com";
        public string Address { get; set; } = "123 Đường Lê Lợi, Quận 1, TP. Hồ Chí Minh";
        public bool IsMaintenanceMode { get; set; } = false;
    }

    public class SalesRecord
    {
        public string Date { get; set; } = string.Empty;
        public decimal Amount { get; set; }
    }

    public class SalesData
    {
        public decimal Revenue { get; set; }
        public int Orders { get; set; }
        public List<SalesRecord> History { get; set; } = new List<SalesRecord>();
    }

    public class AppDatabase
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<UserAccount> Users { get; set; } = new List<UserAccount>();
        public SalesData Sales { get; set; } = new SalesData();
        public List<Voucher> Vouchers { get; set; } = new List<Voucher>();
        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public SystemSettings Settings { get; set; } = new SystemSettings();

        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.json");
        private static AppDatabase? _instance;

        public static AppDatabase Load()
        {
            if (_instance == null)
            {
                if (File.Exists(FilePath))
                {
                    try
                    {
                        string json = File.ReadAllText(FilePath);
                        _instance = JsonSerializer.Deserialize<AppDatabase>(json);
                    }
                    catch
                    {
                        // Fallback on JSON parse error
                    }
                }

                if (_instance == null)
                {
                    _instance = new AppDatabase
                    {
                        Products = GetDefaultProducts(),
                        Users = GetDefaultUsers(),
                        Sales = GetDefaultSales(),
                        Vouchers = GetDefaultVouchers(),
                        Feedbacks = GetDefaultFeedbacks(),
                        Settings = new SystemSettings()
                    };
                    _instance.Save();
                }
            }
            return _instance;
        }

        public void Save()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(this, options);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error saving database: " + ex.Message);
            }
        }

        private static List<UserAccount> GetDefaultUsers()
        {
            return new List<UserAccount>
            {
                new UserAccount
                {
                    Username = "user",
                    Password = "123",
                    FullName = "Nguyễn Văn Khách",
                    Phone = "0987654321",
                    Address = "456 Đường CMT8, Quận 3, TP. Hồ Chí Minh",
                    Role = "customer",
                    SecurityQuestion = "Tên mẹ của bạn là gì?",
                    SecurityAnswer = "Hoa",
                    OrderHistory = new List<UserOrder>
                    {
                        new UserOrder { OrderId = "DH1024", Date = "08/06/2026", TotalAmount = 2450000, ItemsSummary = "Bàn Phím Cơ Keychron K2 Pro x1" }
                    }
                },
                new UserAccount
                {
                    Username = "admin",
                    Password = "123",
                    FullName = "Trần Quản Trị",
                    Phone = "0909090909",
                    Address = "123 Đường Lê Lợi, Quận 1, TP. Hồ Chí Minh",
                    Role = "admin",
                    SecurityQuestion = "Nơi bạn sinh ra ở đâu?",
                    SecurityAnswer = "Sài Gòn"
                }
            };
        }

        private static List<Product> GetDefaultProducts()
        {
            return new List<Product>
            {
                // PHONES - APPLE
                new Product
                {
                    Id = "p1",
                    Name = "iPhone 15 Pro Max 256GB",
                    Category = "phone_apple",
                    Price = 29990000,
                    Stock = 12,
                    ImageUrl = "https://images.unsplash.com/photo-1567581935884-3349727552db?auto=format&fit=crop&w=500&q=80",
                    Description = "Khung viền Titan siêu bền nhẹ, nút Tác Vụ mới, camera zoom quang 5x cùng chip A17 Pro tối tân.",
                    Specs = new List<string> { "Khung vỏ Titan cấp vũ trụ", "Chip A17 Pro mạnh mẽ", "Camera chính 48MP zoom 5x", "Màn hình Super Retina XDR 6.7 inch" }
                },
                new Product
                {
                    Id = "p2",
                    Name = "iPhone 14 128GB Black",
                    Category = "phone_apple",
                    Price = 18490000,
                    Stock = 6,
                    ImageUrl = "https://images.unsplash.com/photo-1616348436168-de43ad0db179?auto=format&fit=crop&w=500&q=80",
                    Description = "Màn hình Super Retina XDR sắc nét, chip A15 Bionic tối ưu thời lượng pin cực khủng.",
                    Specs = new List<string> { "Chip A15 Bionic 5 nhân GPU", "Bộ nhớ trong 128GB", "Camera kép chụp đêm cực tốt", "Thời lượng pin phát video lên đến 20 giờ" }
                },
                new Product
                {
                    Id = "p12",
                    Name = "iPhone 15 128GB Yellow",
                    Category = "phone_apple",
                    Price = 19990000,
                    Stock = 8,
                    ImageUrl = "https://images.unsplash.com/photo-1510557880182-3d4d3cba35a5?auto=format&fit=crop&w=500&q=80",
                    Description = "Màn hình Dynamic Island đột phá, camera chính 48MP và cổng kết nối USB-C tiện dụng.",
                    Specs = new List<string> { "Dynamic Island hiện đại", "Chip A16 Bionic mạnh mẽ", "Camera chính 48MP thế hệ mới", "Cổng kết nối USB-C chuẩn tiện dụng" }
                },
                new Product
                {
                    Id = "p13",
                    Name = "iPhone 13 128GB Blue",
                    Category = "phone_apple",
                    Price = 13990000,
                    Stock = 10,
                    ImageUrl = "https://images.unsplash.com/photo-1512499617640-c74ae3a79d37?auto=format&fit=crop&w=500&q=80",
                    Description = "Thiết kế vuông vắn cổ điển, cụm camera chéo độc đáo cùng thời lượng pin xuất sắc.",
                    Specs = new List<string> { "Chip A15 Bionic", "Màn hình Super Retina XDR 6.1 inch", "Hệ thống camera kép 12MP", "Kết nối 5G siêu tốc" }
                },

                // PHONES - SAMSUNG
                new Product
                {
                    Id = "p3",
                    Name = "Samsung Galaxy S24 Ultra",
                    Category = "phone_samsung",
                    Price = 31990000,
                    Stock = 9,
                    ImageUrl = "https://images.unsplash.com/photo-1610945265064-0e34e5519bbf?auto=format&fit=crop&w=500&q=80",
                    Description = "Kỷ nguyên Galaxy AI mới. Khung viền Titan bền bỉ, camera siêu phân giải 200MP cùng bút S Pen tích hợp.",
                    Specs = new List<string> { "Chip Snapdragon 8 Gen 3 for Galaxy", "Bút S Pen đi kèm tiện lợi", "Camera 200MP Zoom AI 100x", "Màn hình Dynamic AMOLED 2X 6.8 inch" }
                },
                new Product
                {
                    Id = "p4",
                    Name = "Samsung Galaxy Z Fold5 5G",
                    Category = "phone_samsung",
                    Price = 40990000,
                    Stock = 3,
                    ImageUrl = "https://images.unsplash.com/photo-1574757134101-f25f3bc8a121?auto=format&fit=crop&w=500&q=80",
                    Description = "Thiết kế gập không kẽ hở cao cấp, mở ra không gian làm việc rộng rãi như máy tính bảng.",
                    Specs = new List<string> { "Màn hình gập Dynamic AMOLED 7.6 inch", "Màn hình phụ 6.2 inch", "Hỗ trợ đa nhiệm 3 ứng dụng cùng lúc", "Kháng nước chuẩn IPX8" }
                },
                new Product
                {
                    Id = "p14",
                    Name = "Samsung Galaxy A55 5G 128GB",
                    Category = "phone_samsung",
                    Price = 9990000,
                    Stock = 15,
                    ImageUrl = "https://images.unsplash.com/photo-1610945415295-d9b2100837fc?auto=format&fit=crop&w=500&q=80",
                    Description = "Thiết kế khung kim loại cao cấp, camera 50MP chống rung quang học OIS và màn hình 120Hz mượt mà.",
                    Specs = new List<string> { "Khung kim loại sang trọng", "Camera OIS 50MP chụp đêm tốt", "Màn hình Super AMOLED 120Hz", "Kháng nước chống bụi IP67" }
                },

                // PHONES - XIAOMI
                new Product
                {
                    Id = "p5",
                    Name = "Xiaomi 14 Ultra 5G",
                    Category = "phone_xiaomi",
                    Price = 27990000,
                    Stock = 4,
                    ImageUrl = "https://images.unsplash.com/photo-1598327105666-5b89351aff97?auto=format&fit=crop&w=500&q=80",
                    Description = "Hợp tác đồng chế tác cùng Leica. Cảm biến camera 1 inch hàng đầu mang lại chất lượng ảnh chụp chân thực, có chiều sâu.",
                    Specs = new List<string> { "Ống kính quang học Leica Summilux", "Cảm biến lớn LYT-900 1 inch", "Chip Snapdragon 8 Gen 3", "Sạc nhanh siêu tốc 90W" }
                },
                new Product
                {
                    Id = "p16",
                    Name = "Xiaomi Redmi Note 13 Pro",
                    Category = "phone_xiaomi",
                    Price = 7290000,
                    Stock = 18,
                    ImageUrl = "https://images.unsplash.com/photo-1511707171634-5f897ff02aa9?auto=format&fit=crop&w=500&q=80",
                    Description = "Camera siêu nét 200MP chống rung OIS, sạc tăng tốc 67W cùng màn hình AMOLED 1.5K sắc nét.",
                    Specs = new List<string> { "Camera siêu phân giải 200MP OIS", "Màn hình AMOLED 1.5K 120Hz", "Chip Helio G99-Ultra tối ưu", "Sạc nhanh siêu tốc 67W" }
                },
                new Product
                {
                    Id = "p17",
                    Name = "Xiaomi 13T 5G 256GB",
                    Category = "phone_xiaomi",
                    Price = 11990000,
                    Stock = 7,
                    ImageUrl = "https://images.unsplash.com/photo-1565630916779-e303be97b6f5?auto=format&fit=crop&w=500&q=80",
                    Description = "Hệ thống ống kính Leica chuyên nghiệp, màn hình CrystalRes AMOLED 144Hz siêu mượt và kháng nước IP68.",
                    Specs = new List<string> { "Hệ thống camera Leica 50MP", "Màn hình AMOLED 144Hz mượt mà", "Vi xử lý MediaTek Dimensity 8200-Ultra", "Kháng nước chống bụi IP68" }
                },

                // LAPTOPS
                new Product
                {
                    Id = "p6",
                    Name = "MacBook Pro 14 inch M3",
                    Category = "laptop",
                    Price = 39990000,
                    Stock = 8,
                    ImageUrl = "https://images.unsplash.com/photo-1517336714731-489689fd1ca8?auto=format&fit=crop&w=500&q=80",
                    Description = "MacBook Pro 14 inch trang bị chip M3 mang lại hiệu năng phi thường cho các tác vụ hàng ngày và chuyên nghiệp. Thời lượng pin lên đến 22 giờ cùng màn hình Liquid Retina XDR tuyệt đẹp.",
                    Specs = new List<string> { "Chip Apple M3 với 8-core CPU và 10-core GPU", "8GB Unified Memory", "512GB SSD Storage", "Màn hình Liquid Retina XDR 14-inch", "Thời lượng pin lên đến 22 giờ" }
                },
                new Product
                {
                    Id = "p7",
                    Name = "Asus ROG Zephyrus G14",
                    Category = "laptop",
                    Price = 45990000,
                    Stock = 2,
                    ImageUrl = "https://images.unsplash.com/photo-1603302576837-37561b2e2302?auto=format&fit=crop&w=500&q=80",
                    Description = "Laptop gaming 14 inch mạnh mẽ nhất thế giới với bộ vi xử lý AMD Ryzen 9 và card đồ họa RTX 4060. Màn hình Nebula OLED sắc nét tần số quét 120Hz mượt mà.",
                    Specs = new List<string> { "CPU AMD Ryzen 9 8945HS", "NVIDIA GeForce RTX 4060 8GB", "16GB LPDDR5X RAM", "1TB M.2 NVMe PCIe SSD", "Màn hình 14-inch 2.8K OLED 120Hz" }
                },
                new Product
                {
                    Id = "p22",
                    Name = "Dell XPS 13 Plus 9320",
                    Category = "laptop",
                    Price = 38990000,
                    Stock = 4,
                    ImageUrl = "https://images.unsplash.com/photo-1593642632823-8f785ba67e45?auto=format&fit=crop&w=500&q=80",
                    Description = "Thiết kế tương lai mang tính đột phá với bàn phím tràn viền, thanh chạm cảm ứng điện dung và màn hình OLED sắc nét vô cực.",
                    Specs = new List<string> { "CPU Intel Core i7 1360P", "16GB LPDDR5 RAM", "512GB NVMe SSD", "Màn hình 13.4 inch 3.5K OLED Touch", "Trọng lượng siêu nhẹ 1.26 kg" }
                },

                // WATCHES
                new Product
                {
                    Id = "p8",
                    Name = "Apple Watch Ultra 2 Titan",
                    Category = "watch",
                    Price = 21990000,
                    Stock = 3,
                    ImageUrl = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?auto=format&fit=crop&w=500&q=80",
                    Description = "Chiếc Apple Watch bền bỉ và đa năng nhất. Được thiết kế cho các cuộc phiêu lưu ngoài trời và tập luyện cường độ cao với vỏ titan siêu nhẹ, pin cực trâu và màn hình siêu sáng.",
                    Specs = new List<string> { "Vỏ Titan 49mm chống ăn mòn", "Chip S9 SiP mạnh mẽ", "Độ sáng màn hình tối đa 3000 nits", "GPS tần số kép chuẩn xác", "Thời lượng pin lên tới 36 giờ (chế độ thường)" }
                },
                new Product
                {
                    Id = "p9",
                    Name = "Samsung Galaxy Watch6 Classic",
                    Category = "watch",
                    Price = 8490000,
                    Stock = 7,
                    ImageUrl = "https://images.unsplash.com/photo-1508685096489-7aacd43bd3b1?auto=format&fit=crop&w=500&q=80",
                    Description = "Vòng xoay bezel vật lý đặc trưng. Theo dõi giấc ngủ chuyên sâu và phân tích cấu trúc cơ thể BIA thời gian thực.",
                    Specs = new List<string> { "Vòng xoay Bezel xoay mượt mà", "Phân tích chỉ số cơ thể BIA", "Cảm biến nhiệt độ hồng ngoại", "Màn hình kính Sapphire chống trầy" }
                },
                new Product
                {
                    Id = "p18",
                    Name = "Apple Watch Series 9 GPS 45mm",
                    Category = "watch",
                    Price = 10490000,
                    Stock = 11,
                    ImageUrl = "https://images.unsplash.com/photo-1434494878577-86c23bcb06b9?auto=format&fit=crop&w=500&q=80",
                    Description = "Chip S9 SiP mạnh vượt trội, tính năng chạm hai lần (Double Tap) kỳ diệu cùng cảm biến sức khỏe chuyên sâu.",
                    Specs = new List<string> { "Tính năng Chạm Hai Lần đột phá", "Cảm biến nhiệt độ & SPO2", "Độ sáng màn hình 2000 nits", "Kháng bụi chuẩn IPX8" }
                },
                new Product
                {
                    Id = "p19",
                    Name = "Xiaomi Redmi Watch 4",
                    Category = "watch",
                    Price = 2390000,
                    Stock = 20,
                    ImageUrl = "https://images.unsplash.com/photo-1579586337278-3befd40fd17a?auto=format&fit=crop&w=500&q=80",
                    Description = "Khung viền hợp kim nhôm sang trọng, màn hình AMOLED 1.97 inch lớn rõ nét cùng thời lượng pin lên đến 20 ngày.",
                    Specs = new List<string> { "Màn hình AMOLED lớn 1.97 inch", "Pin cực trâu lên đến 20 ngày", "Hỗ trợ cuộc gọi qua Bluetooth", "Theo dõi nhịp tim & giấc ngủ 24/7" }
                },

                // ACCESSORIES & AUDIO
                new Product
                {
                    Id = "p10",
                    Name = "Tai Nghe Sony WH-1000XM5",
                    Category = "accessory",
                    Price = 8490000,
                    Stock = 4,
                    ImageUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?auto=format&fit=crop&w=500&q=80",
                    Description = "Tai nghe chống ồn WH-1000XM5 định nghĩa lại tiêu chuẩn nghe nhạc không bị gián đoạn với 2 bộ xử lý kiểm soát 8 micrô, tối ưu hóa chống ồn tự động theo môi trường.",
                    Specs = new List<string> { "Chống ồn chủ động ANC đỉnh cao", "Bộ màng loa 30 mm được thiết kế đặc biệt", "Thời lượng pin lên đến 30 giờ", "Hỗ trợ LDAC cho âm thanh độ phân giải cao", "Tự động tạm dừng khi nói chuyện (Speak-to-Chat)" }
                },
                new Product
                {
                    Id = "p11",
                    Name = "Bàn Phím Keychron K2 Pro",
                    Category = "accessory",
                    Price = 2450000,
                    Stock = 15,
                    ImageUrl = "https://images.unsplash.com/photo-1587829741301-dc798b83add3?auto=format&fit=crop&w=500&q=80",
                    Description = "Bàn phím cơ không dây layout 75% hỗ trợ QMK/VIA để tùy chỉnh mọi phím bấm. Trải nghiệm gõ êm ái nhờ foam tiêu âm tích hợp và switch Keychron Pro được lube sẵn.",
                    Specs = new List<string> { "Layout 75% nhỏ gọn", "Hỗ trợ QMK/VIA tùy chỉnh phím", "Hỗ trợ Hot-swappable dễ thay switch", "Kết nối Bluetooth 5.1 & Type-C", "Tương thích tốt macOS & Windows" }
                },
                new Product
                {
                    Id = "p20",
                    Name = "Tai Nghe Apple AirPods Pro 2 USB-C",
                    Category = "accessory",
                    Price = 5990000,
                    Stock = 14,
                    ImageUrl = "https://images.unsplash.com/photo-1588449668365-d15e397f6787?auto=format&fit=crop&w=500&q=80",
                    Description = "Khả năng chống ồn chủ động ANC tốt hơn gấp 2 lần, thích ứng âm thanh thông minh và cổng sạc USB-C mới.",
                    Specs = new List<string> { "Chip Apple H2 âm thanh vượt trội", "Chống ồn thích ứng & xuyên âm", "Hộp sạc MagSafe tích hợp USB-C", "Thời gian nghe lên đến 6 giờ" }
                },
                new Product
                {
                    Id = "p21",
                    Name = "Chuột Logitech MX Master 3S",
                    Category = "accessory",
                    Price = 2490000,
                    Stock = 22,
                    ImageUrl = "https://images.unsplash.com/photo-1615663245857-ac93bb7c39e7?auto=format&fit=crop&w=500&q=80",
                    Description = "Dòng chuột công thái học cao cấp chuyên nghiệp cho lập trình viên và designer. Cảm biến 8K DPI siêu nhạy trên mọi mặt kính và nút cuộn MagSpeed siêu tốc cực êm.",
                    Specs = new List<string> { "Nút cuộn MagSpeed điện từ cực nhanh", "Cảm biến Darkfield 8000 DPI", "Nút bấm nhấp chuột yên tĩnh 90%", "Kết nối Flow chuyển đổi 3 thiết bị" }
                }
            };
        }

        private static SalesData GetDefaultSales()
        {
            return new SalesData
            {
                Revenue = 145800000,
                Orders = 6,
                History = new List<SalesRecord>
                {
                    new SalesRecord { Date = "04/06", Amount = 15400000 },
                    new SalesRecord { Date = "05/06", Amount = 29990000 },
                    new SalesRecord { Date = "06/06", Amount = 8490000 },
                    new SalesRecord { Date = "07/06", Amount = 45990000 },
                    new SalesRecord { Date = "08/06", Amount = 2450000 },
                    new SalesRecord { Date = "09/06", Amount = 39990000 },
                    new SalesRecord { Date = "10/06", Amount = 3490000 }
                }
            };
        }

        private static List<Voucher> GetDefaultVouchers()
        {
            return new List<Voucher>
            {
                new Voucher { Code = "LAPTOP15", Description = "Giảm 15% cho đơn laptop (Tối đa 1 triệu)", DiscountPercent = 15, MaxDiscount = 1000000 },
                new Voucher { Code = "APPLE500", Description = "Giảm 8% khi mua sản phẩm Apple (Tối đa 500k)", DiscountPercent = 8, MaxDiscount = 500000 },
                new Voucher { Code = "WELCOME25", Description = "Giảm 25% cho đơn hàng đầu tiên (Tối đa 300k)", DiscountPercent = 25, MaxDiscount = 300000 },
                new Voucher { Code = "FLASH50", Description = "Giảm 50% trong khung giờ flash sale (Tối đa 150k)", DiscountPercent = 50, MaxDiscount = 150000 },
                new Voucher { Code = "TECH10", Description = "Giảm 10% tổng đơn hàng (Tối đa 500k)", DiscountPercent = 10, MaxDiscount = 500000 },
                new Voucher { Code = "SALEOFF", Description = "Giảm 20% cho khách hàng mới (Tối đa 200k)", DiscountPercent = 20, MaxDiscount = 200000 },
                new Voucher { Code = "FREESHIP", Description = "Giảm 5% hỗ trợ phí ship (Tối đa 50k)", DiscountPercent = 5, MaxDiscount = 50000 }
            };
        }

        private static List<Feedback> GetDefaultFeedbacks()
        {
            return new List<Feedback>
            {
                new Feedback { Id = "FB03", CustomerName = "Phạm Minh Quân", Email = "quanpm@gmail.com", Message = "Shop giao Galaxy S24 Ultra nhanh, máy nguyên seal và được hỗ trợ chuyển dữ liệu rất chủ động.", Date = "11/06/2026", Status = "Đã giải quyết" },
                new Feedback { Id = "FB04", CustomerName = "Hoàng Thu Trang", Email = "trang.ht@example.com", Message = "Mình cần xuất hóa đơn công ty cho đơn mua laptop, shop hỗ trợ giúp mình nhé.", Date = "11/06/2026", Status = "Chờ xử lý" },
                new Feedback { Id = "FB05", CustomerName = "Đặng Hữu Phúc", Email = "phuc.dang@gmail.com", Message = "Tai nghe âm thanh tốt nhưng hộp hơi móp một góc, mong shop kiểm tra khâu đóng gói.", Date = "09/06/2026", Status = "Chờ xử lý" },
                new Feedback { Id = "FB06", CustomerName = "Bùi Khánh Linh", Email = "linhbk@example.com", Message = "Nhân viên tư vấn đúng nhu cầu, mình chọn được Apple Watch rất ưng ý.", Date = "07/06/2026", Status = "Đã giải quyết" },
                new Feedback { Id = "FB01", CustomerName = "Nguyễn Văn Khách", Email = "user@example.com", Message = "Sản phẩm iPhone 15 Pro Max dùng rất tốt, nhân viên tư vấn nhiệt tình!", Date = "08/06/2026", Status = "Đã giải quyết" },
                new Feedback { Id = "FB02", CustomerName = "Lê Thị Lan", Email = "lanle@gmail.com", Message = "Tôi muốn hỏi chế độ bảo hành của Macbook Pro M3 thế nào ạ?", Date = "10/06/2026", Status = "Chờ xử lý" }
            };
        }
    }
}
