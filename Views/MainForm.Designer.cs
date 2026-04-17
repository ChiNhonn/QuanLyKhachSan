namespace QuanLyKhachSan.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlChoice = new Panel();
            btnTrangChu = new Button();
            btnDangXuat = new Button();
            btnThongKe = new Button();
            btnDichVu = new Button();
            btnDatPhong = new Button();
            btnKhach = new Button();
            btnPhong = new Button();
            panelContainer = new Panel();
            pnlChoice.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChoice
            // 
            pnlChoice.BackColor = Color.White;
            pnlChoice.Controls.Add(btnTrangChu);
            pnlChoice.Controls.Add(btnDangXuat);
            pnlChoice.Controls.Add(btnThongKe);
            pnlChoice.Controls.Add(btnDichVu);
            pnlChoice.Controls.Add(btnDatPhong);
            pnlChoice.Controls.Add(btnKhach);
            pnlChoice.Controls.Add(btnPhong);
            pnlChoice.Dock = DockStyle.Left;
            pnlChoice.Location = new Point(0, 0);
            pnlChoice.Name = "pnlChoice";
            pnlChoice.Size = new Size(288, 975);
            pnlChoice.TabIndex = 0;
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnTrangChu.Location = new Point(0, 246);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(288, 109);
            btnTrangChu.TabIndex = 6;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnDangXuat.Location = new Point(0, 880);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(288, 95);
            btnDangXuat.TabIndex = 5;
            btnDangXuat.Text = "Đăng Xuất ";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnThongKe.Location = new Point(0, 777);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(288, 104);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click_1;
            // 
            // btnDichVu
            // 
            btnDichVu.FlatStyle = FlatStyle.Flat;
            btnDichVu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnDichVu.Location = new Point(0, 669);
            btnDichVu.Name = "btnDichVu";
            btnDichVu.Size = new Size(288, 109);
            btnDichVu.TabIndex = 3;
            btnDichVu.Text = "Dịch vụ";
            btnDichVu.UseVisualStyleBackColor = true;
            btnDichVu.Click += btnDichVu_Click_1;
            // 
            // btnDatPhong
            // 
            btnDatPhong.FlatStyle = FlatStyle.Flat;
            btnDatPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnDatPhong.Location = new Point(0, 563);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(288, 108);
            btnDatPhong.TabIndex = 2;
            btnDatPhong.Text = "Đặt Phòng";
            btnDatPhong.UseVisualStyleBackColor = true;
            btnDatPhong.Click += btnDatPhong_Click_1;
            // 
            // btnKhach
            // 
            btnKhach.FlatStyle = FlatStyle.Flat;
            btnKhach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnKhach.Location = new Point(0, 462);
            btnKhach.Name = "btnKhach";
            btnKhach.Size = new Size(288, 103);
            btnKhach.TabIndex = 1;
            btnKhach.Text = "Khách";
            btnKhach.UseVisualStyleBackColor = true;
            btnKhach.Click += btnKhach_Click;
            // 
            // btnPhong
            // 
            btnPhong.FlatStyle = FlatStyle.Flat;
            btnPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnPhong.Location = new Point(0, 354);
            btnPhong.Name = "btnPhong";
            btnPhong.Size = new Size(288, 110);
            btnPhong.TabIndex = 0;
            btnPhong.Text = "Phòng ";
            btnPhong.UseVisualStyleBackColor = true;
            btnPhong.Click += btnPhong_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(288, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1134, 975);
            panelContainer.TabIndex = 0;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 975);
            Controls.Add(panelContainer);
            Controls.Add(pnlChoice);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            pnlChoice.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel pnlChoice;
        private Button btnDatPhong;
        private Button btnKhach;
        private Button btnPhong;
        private Button btnThongKe;
        private Button btnDichVu;
        private Button btnDangXuat;
        private Button btnTrangChu;
        private Panel panelContainer;
    }
}