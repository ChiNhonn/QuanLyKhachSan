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
    public partial class QuenMKForm : Form
    {
        public QuenMKForm()
        {
            InitializeComponent();
        }

        private void QuenMKForm_Load(object sender, EventArgs e)
        {
            txtNhapEmail.Focus();
        }

        private void btnQuayVeLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
