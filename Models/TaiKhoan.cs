using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{
    public class TaiKhoan
    {
        private string _tenDangNhap;
        private string _matKhau;
        public string TenDangNhap
        {
            get { return _tenDangNhap; }
            set { 
                _tenDangNhap = value;
            }
        }
        public string MatKhau
        {
            get { return _matKhau; }
            set { 
                _matKhau = value;
            }
        }
        public TaiKhoan(string tenDangNhap, string matKhau)
        {
            _tenDangNhap = tenDangNhap;
            _matKhau = matKhau;
        }
    }
}
