using System;
using System.Data;
using MySqlConnector;

namespace QuanLyKhachSan.Config
{
    public class DbHelpers
    {
        private string conString = "Server=localhost;Database=quan_ly_khach_san;User ID=root;Password=123456;SslMode=None;";
        public DataTable GetTable(string sql, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public int Execute(string sql, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
