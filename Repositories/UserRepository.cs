using QuanLyKhachSan.Models;
using QuanLyKhachSan.Helpers;


namespace QuanLyKhachSan.Repositories
{
    public class TaiKhoanRepository
    {
        public TaiKhoan GetTaiKhoan(string username, string password)
        {
            using (var db = new QuanLyKhachSanContext())
            {
                string hash = PasswordHelpes.PasswordHash(password);
                return db.TaiKhoans.FirstOrDefault(u => u.TenDangNhap == username&& u.MatKhauHash == hash);
            }
        }
    }
}
