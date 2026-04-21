using QuanLyKhachSan.Helpers;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Services;
using QuanLyKhachSan.Views;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            AuthService au = new AuthService();
            string tendangnhap = txtTaiKhoan.Text.Trim();
            string matkhau = txtMatKhau.Text;
            if (string.IsNullOrWhiteSpace(tendangnhap) && string.IsNullOrWhiteSpace(matkhau))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(tendangnhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(matkhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            if (au.Login(tendangnhap, matkhau))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show(); 
            this.Hide();         
        }

        private void linkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMKForm quenMKForm = new QuenMKForm();
            quenMKForm.Show();
            this.Hide();
        }
    }
}
