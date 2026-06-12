# TechStore Desktop App

TechStore Desktop App là ứng dụng quản lý và mua sắm thiết bị công nghệ (Điện thoại, Laptop, Đồng hồ thông minh, Phụ kiện) được xây dựng bằng công nghệ C# Windows Forms (.NET 10). Ứng dụng cung cấp đầy đủ các chức năng cho cả hai đối tượng người dùng: **Khách hàng** (Mua sắm, quản lý giỏ hàng, đặt hàng) và **Quản trị viên** (Xem thống kê, quản lý sản phẩm, đơn hàng, người dùng, khuyến mãi, phản hồi).

---

## Các Tính Năng Hệ Thống

### 1. Phân Hệ Khách Hàng (Customer)
*   **Tài khoản & Bảo mật:**
    *   Đăng ký tài khoản mới.
    *   Đăng nhập hệ thống (bảo mật phiên làm việc).
    *   Khôi phục mật khẩu thông qua Câu hỏi bảo mật đã thiết lập khi đăng ký.
    *   Xem và cập nhật thông tin cá nhân (Họ tên, Số điện thoại, Địa chỉ giao hàng).
*   **Mua sắm & Tìm kiếm:**
    *   Trang chủ hiển thị danh sách sản phẩm nổi bật, banner quảng cáo.
    *   Duyệt sản phẩm phân loại theo các danh mục: Apple, Samsung, Xiaomi, Đồng hồ thông minh, Tai nghe & Phụ kiện.
    *   Tìm kiếm sản phẩm nhanh theo tên.
    *   Bộ lọc nâng cao: Lọc sản phẩm theo khoảng giá, sắp xếp theo giá tăng/giảm dần.
*   **Chi tiết sản phẩm:**
    *   Xem thông tin chi tiết: Tên, giá, mô tả sản phẩm.
    *   Xem thông số kỹ thuật (Specs) chi tiết của từng thiết bị.
    *   Kiểm tra tình trạng tồn kho của sản phẩm.
    *   Xem danh sách các đánh giá từ khách hàng khác.
*   **Giỏ hàng & Đặt hàng:**
    *   Thêm sản phẩm vào giỏ hàng.
    *   Quản lý giỏ hàng: Tăng/giảm số lượng sản phẩm, xóa sản phẩm khỏi giỏ.
    *   Áp dụng Voucher giảm giá trực tiếp vào đơn hàng.
    *   Đặt hàng và thanh toán:
        *   Tự động cập nhật giảm trừ số lượng tồn kho (Stock) của sản phẩm.
        *   Tính toán tổng tiền sau khi áp dụng mã giảm giá.
        *   Lưu thông tin đơn hàng vào lịch sử mua sắm.
*   **Liên hệ & Tin tức:**
    *   Gửi phản hồi, khiếu nại hoặc yêu cầu hỗ trợ trực tiếp đến Ban quản trị.
    *   Đọc các tin tức công nghệ mới cập nhật trên hệ thống.

### 2. Phân Hệ Quản Trị Viên (Admin)
*   **Thống kê & Báo cáo (Dashboard):**
    *   Theo dõi tổng doanh thu, tổng số đơn hàng đã bán.
    *   Xem danh sách các sản phẩm sắp hết hàng (cảnh báo tồn kho dưới ngưỡng an toàn).
    *   Biểu đồ cột biểu diễn lịch sử doanh thu theo thời gian.
    *   Biểu đồ tròn phân tích cơ cấu danh mục sản phẩm đang kinh doanh.
*   **Quản lý kho hàng (Products):**
    *   Xem danh sách toàn bộ sản phẩm trong kho.
    *   Tìm kiếm nhanh sản phẩm theo tên hoặc mã.
    *   Thêm sản phẩm mới (tên, danh mục, giá, tồn kho, mô tả, ảnh, thông số kỹ thuật).
    *   Chỉnh sửa thông tin sản phẩm hiện có.
    *   Xóa sản phẩm khỏi hệ thống.
*   **Quản lý đơn hàng (Orders):**
    *   Xem danh sách tất cả đơn hàng phát sinh trên hệ thống.
    *   Xem chi tiết từng đơn hàng (khách mua, các sản phẩm, tổng tiền, ngày đặt).
    *   Cập nhật trạng thái đơn hàng (Chờ xử lý, Đang giao, Thành công, Đã hủy).
*   **Quản lý người dùng (Users):**
    *   Xem danh sách các tài khoản đăng ký trên hệ thống.
    *   Phân quyền người dùng (Chuyển đổi vai trò giữa Admin và Customer).
    *   Xóa tài khoản người dùng vi phạm.
*   **Quản lý chương trình khuyến mãi (Vouchers):**
    *   Danh sách các mã giảm giá hiện hành.
    *   Thêm mới mã voucher (Mã code, mô tả, % giảm giá, mức giảm tối đa).
    *   Xóa mã voucher không còn sử dụng.
*   **Quản lý phản hồi (Feedbacks):**
    *   Tiếp nhận các phản hồi/liên hệ từ khách hàng.
    *   Xem chi tiết nội dung phản hồi, thông tin liên lạc của khách hàng.
    *   Đánh dấu trạng thái xử lý (Chờ xử lý -> Đã giải quyết) hoặc xóa phản hồi.
*   **Cấu hình hệ thống (Settings):**
    *   Cập nhật thông tin cửa hàng hiển thị trên ứng dụng (Tên cửa hàng, Hotline, Email, Địa chỉ).
    *   Bật/Tắt chế độ bảo trì hệ thống (Maintenance Mode) để giới hạn quyền truy cập của khách hàng khi nâng cấp.

---

## Đề Xuất Thiết Kế Thực Thể Cơ Sở Dữ Liệu (ERD)

Để chuyển đổi từ lưu trữ tệp JSON hiện tại sang Cơ sở dữ liệu quan hệ (RDBMS) phục vụ vẽ ERD, dưới đây là đề xuất chuẩn hóa các bảng dữ liệu (Entities) cùng các thuộc tính (Attributes):

### 1. Bảng `Users` (Người dùng)
*   Quản lý thông tin tài khoản đăng nhập và phân quyền của cả Khách hàng và Admin.

| Thuộc tính | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `Username` | `VARCHAR(50)` | **PK** | Tên đăng nhập (Duy nhất) |
| `Password` | `VARCHAR(255)`| Not Null | Mật khẩu (Nên được mã hóa băm) |
| `FullName` | `NVARCHAR(100)`| Not Null | Họ và tên khách hàng/nhân viên |
| `Phone` | `VARCHAR(15)` | Nullable | Số điện thoại |
| `Address` | `NVARCHAR(255)`| Nullable | Địa chỉ giao hàng mặc định |
| `Role` | `VARCHAR(20)` | Default 'customer' | Vai trò ('customer', 'admin') |
| `SecurityQuestion` | `NVARCHAR(255)`| Not Null | Câu hỏi bảo mật dùng để lấy lại mật khẩu |
| `SecurityAnswer` | `NVARCHAR(255)`| Not Null | Câu trả lời bảo mật (được băm bảo mật) |

### 2. Bảng `Categories` (Danh mục sản phẩm)
*   Phân loại sản phẩm để tối ưu bộ lọc tìm kiếm và báo cáo.

| Thuộc tính | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `CategoryId` | `VARCHAR(30)` | **PK** | Mã danh mục (Ví dụ: `phone_apple`, `laptop`) |
| `CategoryName`| `NVARCHAR(100)`| Not Null | Tên danh mục hiển thị (Ví dụ: iPhone, Laptop) |

### 3. Bảng `Products` (Sản phẩm)
*   Lưu trữ thông tin chi tiết của thiết bị bán trong cửa hàng.

| Thuộc tính | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `ProductId` | `VARCHAR(50)` | **PK** | Mã sản phẩm |
| `Name` | `NVARCHAR(255)`| Not Null | Tên sản phẩm |
| `CategoryId` | `VARCHAR(30)` | **FK** | Liên kết tới `Categories(CategoryId)` |
| `Price` | `DECIMAL(18,2)`| Not Null, >= 0 | Đơn giá sản phẩm |
| `Stock` | `INT` | Not Null, >= 0 | Số lượng sản phẩm còn lại trong kho |
| `ImageUrl` | `VARCHAR(500)` | Nullable | Đường dẫn ảnh sản phẩm |
| `Description` | `NVARCHAR(MAX)`| Nullable | Mô tả chi tiết về sản phẩm |

### 4. Bảng `ProductSpecifications` (Thông số kỹ thuật sản phẩm)
*   Để tránh lưu một mảng String trong trường `Specs`, ta tách ra thành mối quan hệ 1-nhiều với Product.

| Thuộc tính | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `SpecId` | `INT IDENTITY` | **PK** | Mã tự tăng |
| `ProductId` | `VARCHAR(50)` | **FK** | Liên kết tới `Products(ProductId)` |
| `SpecDetail` | `NVARCHAR(255)`| Not Null | Nội dung thông số kỹ thuật (Ví dụ: "RAM 8GB") |

### 5. Bảng `Orders` (Đơn hàng)
*   Lưu thông tin tổng quan của đơn giao dịch mua sắm.

| Thuộc tính | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `OrderId` | `VARCHAR(50)` | **PK** | Mã hóa đơn hàng |
| `Username` | `VARCHAR(50)` | **FK** | Liên kết tới `Users(Username)` người mua |
| `OrderDate` | `DATETIME` | Default GETDATE() | Ngày giờ đặt hàng |
| `TotalAmount`| `DECIMAL(18,2)`| Not Null | Tổng giá trị đơn hàng sau giảm giá |
| `VoucherCode`| `VARCHAR(50)` | **FK**, Nullable | Mã giảm giá đã áp dụng (nếu có) |
| `Status` | `NVARCHAR(50)` | Default 'Chờ xử lý'| Trạng thái đơn hàng ('Chờ xử lý', 'Thành công', v.v.) |

### 6. Bảng `OrderDetails` (Chi tiết đơn hàng)
*   Mối quan hệ nhiều-nhiều giữa `Orders` và `Products` thông qua bảng trung gian nhằm lưu trữ chi tiết từng sản phẩm trong đơn hàng cùng đơn giá tại thời điểm mua.

| Thuộc tính | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `OrderDetailId`| `INT IDENTITY` | **PK** | Mã tự tăng |
| `OrderId` | `VARCHAR(50)` | **FK** | Liên kết tới `Orders(OrderId)` |
| `ProductId` | `VARCHAR(50)` | **FK** | Liên kết tới `Products(ProductId)` |
| `Quantity` | `INT` | Not Null, > 0 | Số lượng sản phẩm mua trong đơn |
| `UnitPrice` | `DECIMAL(18,2)`| Not Null | Đơn giá sản phẩm tại thời điểm mua |

### 7. Bảng `Vouchers` (Mã giảm giá)
*   Quản lý mã khuyến mãi cho khách hàng áp dụng khi thanh toán.

| Thuộc tính | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `Code` | `VARCHAR(50)` | **PK** | Mã giảm giá (Ví dụ: `WELCOME25`) |
| `Description` | `NVARCHAR(255)`| Nullable | Mô tả chương trình khuyến mãi |
| `DiscountPercent`| `DECIMAL(5,2)`| Not Null, 0-100 | Tỷ lệ giảm giá (%) |
| `MaxDiscount`| `DECIMAL(18,2)`| Not Null, >= 0 | Số tiền giảm giá tối đa cho phép |

### 8. Bảng `Feedbacks` (Phản hồi khách hàng)
*   Lưu thông tin ý kiến đóng góp hoặc phản ánh lỗi của người dùng.

| Thuộc tính | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `FeedbackId` | `VARCHAR(50)` | **PK** | Mã phản hồi |
| `CustomerName`| `NVARCHAR(100)`| Not Null | Họ tên người gửi phản hồi |
| `Email` | `VARCHAR(100)` | Not Null | Địa chỉ Email liên hệ |
| `Message` | `NVARCHAR(MAX)`| Not Null | Nội dung phản hồi |
| `Date` | `VARCHAR(50)` | Not Null | Ngày gửi phản hồi |
| `Status` | `NVARCHAR(50)` | Default 'Chờ xử lý'| Trạng thái giải quyết ('Chờ xử lý', 'Đã giải quyết') |

### 9. Bảng `SystemSettings` (Cấu hình hệ thống)
*   Bảng cấu hình chung chứa duy nhất 1 bản ghi cấu hình cửa hàng.

| Thuộc tính | Kiểu dữ liệu | Ràng buộc | Mô tả |
| :--- | :--- | :--- | :--- |
| `SettingId` | `INT` | **PK**, Default 1 | Khóa chính cố định bằng 1 |
| `StoreName` | `NVARCHAR(100)`| Not Null | Tên cửa hàng hiển thị |
| `Hotline` | `VARCHAR(20)` | Not Null | Đường dây nóng |
| `Email` | `VARCHAR(100)` | Not Null | Email liên hệ hỗ trợ |
| `Address` | `NVARCHAR(255)`| Not Null | Địa chỉ cửa hàng |
| `IsMaintenanceMode`| `BIT` | Default 0 (False) | 1: Bật bảo trì, 0: Hoạt động bình thường |

---

## Các Mối Quan Hệ Giữa Các Thực Thể (Relationships)

1.  **Categories ➔ Products (1 - n):** Một danh mục có thể chứa nhiều sản phẩm; một sản phẩm thuộc về một danh mục duy nhất.
2.  **Products ➔ ProductSpecifications (1 - n):** Một sản phẩm có nhiều thuộc tính/thông số kỹ thuật chi tiết.
3.  **Users ➔ Orders (1 - n):** Một khách hàng có thể đặt nhiều đơn hàng; một đơn hàng bắt buộc thuộc về một khách hàng duy nhất.
4.  **Orders ➔ OrderDetails (1 - n) & Products ➔ OrderDetails (1 - n):** Mối quan hệ nhiều-nhiều giữa Đơn hàng và Sản phẩm được giải quyết qua bảng trung gian `OrderDetails`.
5.  **Vouchers ➔ Orders (1 - n):** Một Voucher giảm giá có thể áp dụng cho nhiều đơn hàng khác nhau; một đơn hàng chỉ áp dụng tối đa một mã Voucher (hoặc không áp dụng).

---

## Công Nghệ Sử Dụng
*   **Ngôn ngữ:** C#
*   **Framework:** .NET 10 (Windows Forms)
*   **Cơ sở dữ liệu đề xuất:** SQL Server, MySQL hoặc PostgreSQL.
*   **Bộ lưu trữ dữ liệu hiện tại (Mock):** File JSON cục bộ (`database.json`) dùng thư viện `System.Text.Json` phục vụ chạy thử nhanh không cần cài đặt database.

---

## Cách Chạy Dự Án (Chế độ Local File Mock)

1.  Mở terminal tại thư mục gốc của dự án.
2.  Chạy các lệnh dotnet sau:
    ```powershell
    dotnet restore
    dotnet build
    dotnet run
    ```
3.  Hoặc mở file solution `TechStoreWinApp.sln` bằng Visual Studio (phiên bản hỗ trợ .NET 10) và chọn **Start / Run**.

---

## Tài Khoản Thử Nghiệm Mặc Định
*   **Tài khoản Khách hàng:** `user` / `123`
*   **Tài khoản Quản trị viên (Admin):** `admin` / `123`
