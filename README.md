# k58ktp - Môn: Phát triển ứng dụng trên nền web #
# Nguyễn Hoàng Việt 
## BÀI TẬP VỀ NHÀ 01: ##

### TẠO SOLUTION GỒM CÁC PROJECT SAU: ###
1. DLL đa năng, keyword: c# window library -> **Class Library (.NET Framework)** bắt buộc sử dụng **.NET Framework 2.0**: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
2. Console app, bắt buộc sử dụng **.NET Framework 2.0**, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => **Console App (.NET Framework)**, biên dịch ra EXE
3. Windows Form Application, bắt buộc sử dụng **.NET Framework 2.0****, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => **Windows Form Application (.NET Framework)**, biên dịch ra EXE
4. Web đơn giản, bắt buộc sử dụng **.NET Framework 2.0**, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => **ASP.NET Web Application (.NET Framework)** + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

### Đề Bài: Game FlappyBird

### Tạo 4 project:

  <img width="523" height="433" alt="image" src="https://github.com/user-attachments/assets/344c9adb-b5e6-48ef-abba-9abd14f82bbe" />
  
  <img width="370" height="165" alt="image" src="https://github.com/user-attachments/assets/36fe47bb-36d2-4745-b1e1-9d7763a3c8e5" />

- FlappyConsole (Console App),ScoreLibrary(Class Library),FlappyWinForm(Winform),FlappyWebServer1(WebForm)

### Hiển thị 

- Console app:

<img width="1434" height="429" alt="image" src="https://github.com/user-attachments/assets/ec816527-b136-4bd1-9933-06204acf6fe8" />

- WinForm:

<img width="530" height="641" alt="image" src="https://github.com/user-attachments/assets/bf4a9fd7-1b9d-4ef7-b249-4af7810825da" />

- WebForm:

<img width="481" height="171" alt="image" src="https://github.com/user-attachments/assets/5afc69bd-dbfa-4888-903b-f12b8d42127f" />

- Bên trong web form sẽ bao gồm api.aspx(api.aspx.cs,api.aspx.designer.cs) và file index.html:

1.api.aspx

Đây là file giao diện (markup) của trang Web Forms.

Nó chứa HTML + Web Controls (ASP.NET Controls).

2. api.aspx.cs

Đây là file Code-behind (C#).

Nó chứa logic xử lý khi có request đến api.aspx.

3. api.aspx.designer.cs

File này được Visual Studio tự động sinh ra.

Nó chứa khai báo control ở trong api.aspx để C# code có thể dùng.

4. index.html → Giao diện tĩnh, thường dùng để test hoặc gọi đến API.

### IIS

- Kích hoạt IIS (GUI hoặc PowerShell)

- Kiểm tra dịch vụ IIS đang chạy

- Tạo site trong IIS và set binding cho host header hoangviet.com

<img width="1919" height="954" alt="image" src="https://github.com/user-attachments/assets/0866b53d-a652-4eba-a57e-21a4cf76edf1" />

- Sửa file hosts để ánh xạ hoangviet.com → localhost

<img width="408" height="843" alt="image" src="https://github.com/user-attachments/assets/e6b58980-b91f-4fbf-9d36-f9e4a79b5d53" />

- Đây là sau khi test thử thành công trên web 

<img width="1919" height="1031" alt="image" src="https://github.com/user-attachments/assets/4cb5be26-6ec7-4572-b381-79dfc687d079" />



