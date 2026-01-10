namespace PBL3_Project;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // Tự động kiểm tra và thêm dữ liệu mẫu khi mở app
        try 
        {
            using (var db = new PBL3Context())
            {
                db.SeedData(); 
            }
        }
        catch (Exception ex)
        {
            // Nếu lỗi kết nối DB ở đây thì báo để bro biết, 
            // nhưng vẫn cho app chạy tiếp để vào Form
            Console.WriteLine("Lỗi khởi tạo dữ liệu: " + ex.Message);
        }

        Application.Run(new Form1());
    }    
}