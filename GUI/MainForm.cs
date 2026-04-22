using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chuyentrang(new usTrangChu());
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        public void chuyentrang(UserControl tc)
        {
            panelContainer.Controls.Clear();
            tc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(tc);
            tc.BringToFront();
            panelContainer.BringToFront();
        }



        private void btnPhong_Click(object sender, EventArgs e)
        {
            chuyentrang(new usPhong());
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            chuyentrang(new usKhach());
        }
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            chuyentrang(new usDatPhong());
        }
        private void btnDichVu_Click(object sender, EventArgs e)
        {
            chuyentrang(new usDichVu());
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            chuyentrang(new usThongKe());
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            chuyentrang(new usTrangChu());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnDatPhong_Click_1(object sender, EventArgs e)
        {
            chuyentrang(new usDatPhong());
        }

        private void btnDichVu_Click_1(object sender, EventArgs e)
        {
            chuyentrang(new usDichVu());
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            chuyentrang(new usThongKe());
        }
    }
}
