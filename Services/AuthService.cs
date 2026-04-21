using QuanLyKhachSan.Config;
using MySqlConnector;
using System.Data;

namespace QuanLyKhachSan.Services
{
    public class  AuthService
    {
        DbHelpers db = new DbHelpers();
        public bool Login(String username , String password)
        {
            string sql = "SELECT * FROM tai_khoan WHERE ten_dang_nhap = @username AND mat_khau_hash = @password";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@username", username),
                new MySqlParameter("@password", Helpers.PasswordHelpes.PasswordHash(password))
            };
            DataTable dt = db.GetTable(sql, parameters);

            if(dt.Rows.Count > 0)
            { 
                return true;
            }
            return false;
        }
    }
}
