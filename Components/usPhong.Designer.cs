namespace QuanLyKhachSan.Views
{
    partial class usPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpThongTin = new GroupBox();
            lblSoPhong = new Label();
            textBox1 = new TextBox();
            lblLoaiPhong = new Label();
            cboTrangThai = new ComboBox();
            numTang = new NumericUpDown();
            lblTang = new Label();
            lblTrangThai = new Label();
            lblMoTa = new Label();
            cboLoaiPhong = new ComboBox();
            txtSoPhong = new TextBox();
            txtTimKiem = new TextBox();
            grpChucNang = new GroupBox();
            cboLocTrangThai = new ComboBox();
            cboLocLoaiPhong = new ComboBox();
            label2 = new Label();
            btnThemPhong = new Button();
            button4 = new Button();
            btnChinhSua = new Button();
            btnXoaPhong = new Button();
            dataGridView1 = new DataGridView();
            colSoPhong = new DataGridViewTextBoxColumn();
            colLoaiPhong = new DataGridViewTextBoxColumn();
            colTang = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colMota = new DataGridViewTextBoxColumn();
            grpDanhSach = new GroupBox();
            grpTimkiem = new GroupBox();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTang).BeginInit();
            grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpDanhSach.SuspendLayout();
            grpTimkiem.SuspendLayout();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpThongTin.Controls.Add(lblSoPhong);
            grpThongTin.Controls.Add(textBox1);
            grpThongTin.Controls.Add(lblLoaiPhong);
            grpThongTin.Controls.Add(cboTrangThai);
            grpThongTin.Controls.Add(numTang);
            grpThongTin.Controls.Add(lblTang);
            grpThongTin.Controls.Add(lblTrangThai);
            grpThongTin.Controls.Add(lblMoTa);
            grpThongTin.Controls.Add(cboLoaiPhong);
            grpThongTin.Controls.Add(txtSoPhong);
            grpThongTin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grpThongTin.Location = new Point(3, 81);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(1080, 617);
            grpThongTin.TabIndex = 24;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin phòng";
            // 
            // lblSoPhong
            // 
            lblSoPhong.AutoSize = true;
            lblSoPhong.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblSoPhong.Location = new Point(151, 84);
            lblSoPhong.Name = "lblSoPhong";
            lblSoPhong.Size = new Size(176, 46);
            lblSoPhong.TabIndex = 1;
            lblSoPhong.Text = "Số Phòng:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            textBox1.Location = new Point(385, 444);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(587, 172);
            textBox1.TabIndex = 11;
            // 
            // lblLoaiPhong
            // 
            lblLoaiPhong.AutoSize = true;
            lblLoaiPhong.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblLoaiPhong.Location = new Point(151, 160);
            lblLoaiPhong.Name = "lblLoaiPhong";
            lblLoaiPhong.Size = new Size(210, 46);
            lblLoaiPhong.TabIndex = 8;
            lblLoaiPhong.Text = "Loại Phòng: ";
            lblLoaiPhong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 16.2F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Sẵn sàng", "Đang ở ", "Bảo trì" });
            cboTrangThai.Location = new Point(385, 351);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(239, 45);
            cboTrangThai.TabIndex = 7;
            // 
            // numTang
            // 
            numTang.Font = new Font("Segoe UI", 16.2F);
            numTang.Location = new Point(385, 260);
            numTang.Name = "numTang";
            numTang.Size = new Size(239, 43);
            numTang.TabIndex = 13;
            // 
            // lblTang
            // 
            lblTang.AutoSize = true;
            lblTang.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblTang.Location = new Point(151, 260);
            lblTang.Name = "lblTang";
            lblTang.Size = new Size(105, 46);
            lblTang.TabIndex = 12;
            lblTang.Text = "Tầng:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblTrangThai.Location = new Point(151, 344);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(199, 46);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "Trạng Thái: ";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblMoTa.Location = new Point(151, 444);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(118, 46);
            lblMoTa.TabIndex = 10;
            lblMoTa.Text = "Mô tả:";
            // 
            // cboLoaiPhong
            // 
            cboLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiPhong.Font = new Font("Segoe UI", 16.2F);
            cboLoaiPhong.FormattingEnabled = true;
            cboLoaiPhong.Items.AddRange(new object[] { "Tiêu chuẩn", "Cao Cấp", "VIP" });
            cboLoaiPhong.Location = new Point(385, 160);
            cboLoaiPhong.Name = "cboLoaiPhong";
            cboLoaiPhong.Size = new Size(239, 45);
            cboLoaiPhong.TabIndex = 9;
            // 
            // txtSoPhong
            // 
            txtSoPhong.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 163);
            txtSoPhong.Location = new Point(385, 84);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.PlaceholderText = "Nhập số phòng....";
            txtSoPhong.Size = new Size(587, 43);
            txtSoPhong.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 163);
            txtTimKiem.Location = new Point(210, 24);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm theo số phòng hoặc mô tả ";
            txtTimKiem.Size = new Size(717, 38);
            txtTimKiem.TabIndex = 17;
            // 
            // grpChucNang
            // 
            grpChucNang.Controls.Add(cboLocTrangThai);
            grpChucNang.Controls.Add(cboLocLoaiPhong);
            grpChucNang.Controls.Add(label2);
            grpChucNang.Controls.Add(btnThemPhong);
            grpChucNang.Controls.Add(button4);
            grpChucNang.Controls.Add(btnChinhSua);
            grpChucNang.Controls.Add(btnXoaPhong);
            grpChucNang.Dock = DockStyle.Right;
            grpChucNang.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grpChucNang.Location = new Point(1089, 0);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new Size(312, 900);
            grpChucNang.TabIndex = 26;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Chức năng";
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTrangThai.FormattingEnabled = true;
            cboLocTrangThai.Items.AddRange(new object[] { "Sẵn sàng", "Đang ở ", "Bảo trì" });
            cboLocTrangThai.Location = new Point(80, 533);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(162, 39);
            cboLocTrangThai.TabIndex = 7;
            // 
            // cboLocLoaiPhong
            // 
            cboLocLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLoaiPhong.FormattingEnabled = true;
            cboLocLoaiPhong.Items.AddRange(new object[] { "Tiêu chuẩn", "Hạng sang", "VIP" });
            cboLocLoaiPhong.Location = new Point(80, 463);
            cboLocLoaiPhong.Name = "cboLocLoaiPhong";
            cboLocLoaiPhong.Size = new Size(162, 39);
            cboLocLoaiPhong.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(7, 396);
            label2.Name = "label2";
            label2.Size = new Size(292, 28);
            label2.TabIndex = 5;
            label2.Text = "Chức năng tìm kiếm theo loại";
            // 
            // btnThemPhong
            // 
            btnThemPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThemPhong.Location = new Point(80, 49);
            btnThemPhong.Name = "btnThemPhong";
            btnThemPhong.Size = new Size(162, 74);
            btnThemPhong.TabIndex = 1;
            btnThemPhong.Text = "Thêm Phòng";
            btnThemPhong.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(80, 311);
            button4.Name = "button4";
            button4.Size = new Size(163, 70);
            button4.TabIndex = 4;
            button4.Text = "Làm mới thông tin";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua
            // 
            btnChinhSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnChinhSua.Location = new Point(79, 135);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(163, 70);
            btnChinhSua.TabIndex = 2;
            btnChinhSua.Text = "Cập Nhập Thông Tin";
            btnChinhSua.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhong
            // 
            btnXoaPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXoaPhong.Location = new Point(79, 226);
            btnXoaPhong.Name = "btnXoaPhong";
            btnXoaPhong.Size = new Size(163, 70);
            btnXoaPhong.TabIndex = 3;
            btnXoaPhong.Text = "Xóa Phòng";
            btnXoaPhong.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colSoPhong, colLoaiPhong, colTang, colTrangThai, colMota });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1083, 144);
            dataGridView1.TabIndex = 28;
            // 
            // colSoPhong
            // 
            colSoPhong.HeaderText = "Số phòng";
            colSoPhong.MinimumWidth = 6;
            colSoPhong.Name = "colSoPhong";
            colSoPhong.Width = 125;
            // 
            // colLoaiPhong
            // 
            colLoaiPhong.HeaderText = "Loại Phòng";
            colLoaiPhong.MinimumWidth = 6;
            colLoaiPhong.Name = "colLoaiPhong";
            colLoaiPhong.Width = 125;
            // 
            // colTang
            // 
            colTang.HeaderText = "Tầng";
            colTang.MinimumWidth = 6;
            colTang.Name = "colTang";
            colTang.Width = 125;
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.Width = 125;
            // 
            // colMota
            // 
            colMota.HeaderText = "Mô tả";
            colMota.MinimumWidth = 6;
            colMota.Name = "colMota";
            colMota.Width = 125;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(dataGridView1);
            grpDanhSach.Dock = DockStyle.Bottom;
            grpDanhSach.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grpDanhSach.Location = new Point(0, 719);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(1089, 181);
            grpDanhSach.TabIndex = 28;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách phòng";
            // 
            // grpTimkiem
            // 
            grpTimkiem.Controls.Add(txtTimKiem);
            grpTimkiem.Dock = DockStyle.Top;
            grpTimkiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grpTimkiem.Location = new Point(0, 0);
            grpTimkiem.Name = "grpTimkiem";
            grpTimkiem.Size = new Size(1089, 83);
            grpTimkiem.TabIndex = 29;
            grpTimkiem.TabStop = false;
            grpTimkiem.Text = "Thanh tìm kiếm";
            grpTimkiem.Enter += grpTimkiem_Enter_1;
            // 
            // usPhong
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(grpTimkiem);
            Controls.Add(grpDanhSach);
            Controls.Add(grpThongTin);
            Controls.Add(grpChucNang);
            Name = "usPhong";
            Size = new Size(1401, 900);
            Load += usPhong_Load_1;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTang).EndInit();
            grpChucNang.ResumeLayout(false);
            grpChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpDanhSach.ResumeLayout(false);
            grpTimkiem.ResumeLayout(false);
            grpTimkiem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlThongTinPhong;
        private GroupBox grpThongTin;
        private Label lblSoPhong;
        private TextBox textBox1;
        private Label lblLoaiPhong;
        private ComboBox cboTrangThai;
        private NumericUpDown numTang;
        private Label lblTang;
        private Label lblTrangThai;
        private Label lblMoTa;
        private ComboBox cboLoaiPhong;
        private TextBox txtSoPhong;
        private GroupBox grpChucNang;
        private ComboBox cboLocTrangThai;
        private ComboBox cboLocLoaiPhong;
        private Label label2;
        private Button btnThemPhong;
        private Button button4;
        private Button btnChinhSua;
        private Button btnXoaPhong;
        private TextBox txtTimKiem;
        private DataGridView dataGridView1;
        private GroupBox grpDanhSach;
        private DataGridViewTextBoxColumn colSoPhong;
        private DataGridViewTextBoxColumn colLoaiPhong;
        private DataGridViewTextBoxColumn colTang;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colMota;
        private GroupBox grpTimkiem;
    }
}
