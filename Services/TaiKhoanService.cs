using QuanLyKhachSan.Repositories;
namespace QuanLyKhachSan.Services
{
    public class TaiKhoanService
    {
        private TaiKhoanRepository repo = new TaiKhoanRepository();
        public bool Login(string username, string password)
        {
            var taiKhoan = repo.GetTaiKhoan(username, password);
            return taiKhoan != null;
        }
    }
}
