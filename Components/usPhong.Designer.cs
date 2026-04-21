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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usPhong));
            grpThongTin = new GroupBox();
            lblSoPhong = new Label();
            txtMoTa = new TextBox();
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
            btnThemPhong = new Button();
            btnXoaPhong = new Button();
            btnChinhSua = new Button();
            cboLocTrangThai = new ComboBox();
            cboLocLoaiPhong = new ComboBox();
            btnLamMoi = new Button();
            dataGridDanhSach = new DataGridView();
            colSoPhong = new DataGridViewTextBoxColumn();
            colLoaiPhong = new DataGridViewTextBoxColumn();
            colTang = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colMota = new DataGridViewTextBoxColumn();
            colThaoTac = new DataGridViewTextBoxColumn();
            grpDanhSach = new GroupBox();
            grpTimkiem = new GroupBox();
            pnlContent = new Panel();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTang).BeginInit();
            grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDanhSach).BeginInit();
            grpDanhSach.SuspendLayout();
            grpTimkiem.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpThongTin.Controls.Add(lblSoPhong);
            grpThongTin.Controls.Add(txtMoTa);
            grpThongTin.Controls.Add(lblLoaiPhong);
            grpThongTin.Controls.Add(cboTrangThai);
            grpThongTin.Controls.Add(numTang);
            grpThongTin.Controls.Add(lblTang);
            grpThongTin.Controls.Add(lblTrangThai);
            grpThongTin.Controls.Add(lblMoTa);
            grpThongTin.Controls.Add(cboLoaiPhong);
            grpThongTin.Controls.Add(txtSoPhong);
            grpThongTin.Dock = DockStyle.Fill;
            grpThongTin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grpThongTin.Location = new Point(0, 0);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(1095, 637);
            grpThongTin.TabIndex = 24;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin phòng";
            // 
            // lblSoPhong
            // 
            lblSoPhong.AutoSize = true;
            lblSoPhong.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblSoPhong.Location = new Point(80, 56);
            lblSoPhong.Name = "lblSoPhong";
            lblSoPhong.Size = new Size(176, 46);
            lblSoPhong.TabIndex = 1;
            lblSoPhong.Text = "Số Phòng:";
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtMoTa.Location = new Point(335, 337);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(704, 172);
            txtMoTa.TabIndex = 11;
            // 
            // lblLoaiPhong
            // 
            lblLoaiPhong.AutoSize = true;
            lblLoaiPhong.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblLoaiPhong.Location = new Point(80, 120);
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
            cboTrangThai.Location = new Point(335, 248);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(239, 45);
            cboTrangThai.TabIndex = 7;
            // 
            // numTang
            // 
            numTang.Font = new Font("Segoe UI", 16.2F);
            numTang.Location = new Point(335, 183);
            numTang.Name = "numTang";
            numTang.Size = new Size(239, 43);
            numTang.TabIndex = 13;
            // 
            // lblTang
            // 
            lblTang.AutoSize = true;
            lblTang.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblTang.Location = new Point(80, 179);
            lblTang.Name = "lblTang";
            lblTang.Size = new Size(105, 46);
            lblTang.TabIndex = 12;
            lblTang.Text = "Tầng:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblTrangThai.Location = new Point(80, 245);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(199, 46);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "Trạng Thái: ";
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblMoTa.Location = new Point(80, 337);
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
            cboLoaiPhong.Location = new Point(335, 120);
            cboLoaiPhong.Name = "cboLoaiPhong";
            cboLoaiPhong.Size = new Size(239, 45);
            cboLoaiPhong.TabIndex = 9;
            // 
            // txtSoPhong
            // 
            txtSoPhong.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 163);
            txtSoPhong.Location = new Point(335, 56);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.PlaceholderText = "Nhập số phòng....";
            txtSoPhong.Size = new Size(704, 43);
            txtSoPhong.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Font = new Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, 163);
            txtTimKiem.Location = new Point(72, 63);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm theo số phòng hoặc mô tả ";
            txtTimKiem.Size = new Size(717, 40);
            txtTimKiem.TabIndex = 17;
            // 
            // grpChucNang
            // 
            grpChucNang.Controls.Add(btnThemPhong);
            grpChucNang.Controls.Add(btnXoaPhong);
            grpChucNang.Controls.Add(btnChinhSua);
            grpChucNang.Dock = DockStyle.Right;
            grpChucNang.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grpChucNang.Location = new Point(1095, 0);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new Size(306, 637);
            grpChucNang.TabIndex = 26;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "Chức năng";
            // 
            // btnThemPhong
            // 
            btnThemPhong.BackColor = SystemColors.Control;
            btnThemPhong.Cursor = Cursors.Hand;
            btnThemPhong.FlatAppearance.BorderSize = 0;
            btnThemPhong.FlatStyle = FlatStyle.Flat;
            btnThemPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThemPhong.ForeColor = SystemColors.ControlText;
            btnThemPhong.Image = (Image)resources.GetObject("btnThemPhong.Image");
            btnThemPhong.Location = new Point(127, 76);
            btnThemPhong.Name = "btnThemPhong";
            btnThemPhong.Size = new Size(51, 51);
            btnThemPhong.TabIndex = 1;
            btnThemPhong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemPhong.UseVisualStyleBackColor = false;
            // 
            // btnXoaPhong
            // 
            btnXoaPhong.Cursor = Cursors.Hand;
            btnXoaPhong.FlatAppearance.BorderSize = 0;
            btnXoaPhong.FlatStyle = FlatStyle.Flat;
            btnXoaPhong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXoaPhong.Image = (Image)resources.GetObject("btnXoaPhong.Image");
            btnXoaPhong.Location = new Point(100, 232);
            btnXoaPhong.Name = "btnXoaPhong";
            btnXoaPhong.Size = new Size(115, 74);
            btnXoaPhong.TabIndex = 3;
            btnXoaPhong.UseVisualStyleBackColor = false;
            // 
            // btnChinhSua
            // 
            btnChinhSua.Cursor = Cursors.Hand;
            btnChinhSua.FlatAppearance.BorderSize = 0;
            btnChinhSua.FlatStyle = FlatStyle.Flat;
            btnChinhSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnChinhSua.Image = (Image)resources.GetObject("btnChinhSua.Image");
            btnChinhSua.Location = new Point(100, 147);
            btnChinhSua.Name = "btnChinhSua";
            btnChinhSua.Size = new Size(115, 74);
            btnChinhSua.TabIndex = 2;
            btnChinhSua.UseVisualStyleBackColor = false;
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTrangThai.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            cboLocTrangThai.FormattingEnabled = true;
            cboLocTrangThai.Items.AddRange(new object[] { "Sẵn sàng", "Đang ở ", "Bảo trì" });
            cboLocTrangThai.Location = new Point(1073, 57);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(162, 45);
            cboLocTrangThai.TabIndex = 7;
            // 
            // cboLocLoaiPhong
            // 
            cboLocLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLoaiPhong.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            cboLocLoaiPhong.FormattingEnabled = true;
            cboLocLoaiPhong.Items.AddRange(new object[] { "Tiêu chuẩn", "Hạng sang", "VIP" });
            cboLocLoaiPhong.Location = new Point(854, 57);
            cboLocLoaiPhong.Name = "cboLocLoaiPhong";
            cboLocLoaiPhong.Size = new Size(162, 45);
            cboLocLoaiPhong.TabIndex = 6;
            // 
            // btnLamMoi
            // 
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.Location = new Point(1274, 44);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(87, 76);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dataGridDanhSach
            // 
            dataGridDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDanhSach.Columns.AddRange(new DataGridViewColumn[] { colSoPhong, colLoaiPhong, colTang, colTrangThai, colMota, colThaoTac });
            dataGridDanhSach.Dock = DockStyle.Fill;
            dataGridDanhSach.Location = new Point(3, 34);
            dataGridDanhSach.Name = "dataGridDanhSach";
            dataGridDanhSach.RowHeadersWidth = 51;
            dataGridDanhSach.Size = new Size(1395, 376);
            dataGridDanhSach.TabIndex = 28;
            // 
            // colSoPhong
            // 
            colSoPhong.HeaderText = "Số phòng";
            colSoPhong.MinimumWidth = 6;
            colSoPhong.Name = "colSoPhong";
            // 
            // colLoaiPhong
            // 
            colLoaiPhong.HeaderText = "Loại Phòng";
            colLoaiPhong.MinimumWidth = 6;
            colLoaiPhong.Name = "colLoaiPhong";
            // 
            // colTang
            // 
            colTang.HeaderText = "Tầng";
            colTang.MinimumWidth = 6;
            colTang.Name = "colTang";
            // 
            // colTrangThai
            // 
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            // 
            // colMota
            // 
            colMota.HeaderText = "Mô tả";
            colMota.MinimumWidth = 6;
            colMota.Name = "colMota";
            // 
            // colThaoTac
            // 
            colThaoTac.HeaderText = "Thao tác";
            colThaoTac.MinimumWidth = 6;
            colThaoTac.Name = "colThaoTac";
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(dataGridDanhSach);
            grpDanhSach.Dock = DockStyle.Bottom;
            grpDanhSach.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grpDanhSach.Location = new Point(0, 787);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(1401, 413);
            grpDanhSach.TabIndex = 28;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "Danh sách phòng";
            // 
            // grpTimkiem
            // 
            grpTimkiem.Controls.Add(cboLocTrangThai);
            grpTimkiem.Controls.Add(txtTimKiem);
            grpTimkiem.Controls.Add(cboLocLoaiPhong);
            grpTimkiem.Controls.Add(btnLamMoi);
            grpTimkiem.Dock = DockStyle.Top;
            grpTimkiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            grpTimkiem.Location = new Point(0, 0);
            grpTimkiem.Name = "grpTimkiem";
            grpTimkiem.Size = new Size(1401, 150);
            grpTimkiem.TabIndex = 29;
            grpTimkiem.TabStop = false;
            grpTimkiem.Text = "Thanh tìm kiếm";
            grpTimkiem.Enter += grpTimkiem_Enter_1;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(grpThongTin);
            pnlContent.Controls.Add(grpChucNang);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 150);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1401, 637);
            pnlContent.TabIndex = 30;
            // 
            // usPhong
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(pnlContent);
            Controls.Add(grpTimkiem);
            Controls.Add(grpDanhSach);
            Name = "usPhong";
            Size = new Size(1401, 1200);
            Load += usPhong_Load_1;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTang).EndInit();
            grpChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridDanhSach).EndInit();
            grpDanhSach.ResumeLayout(false);
            grpTimkiem.ResumeLayout(false);
            grpTimkiem.PerformLayout();
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlThongTinPhong;
        private GroupBox grpThongTin;
        private Label lblSoPhong;
        private TextBox txtMoTa;
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
        private Button btnThemPhong;
        private Button btnLamMoi;
        private Button btnChinhSua;
        private Button btnXoaPhong;
        private TextBox txtTimKiem;
        private DataGridView dataGridDanhSach;
        private GroupBox grpDanhSach;
        private DataGridViewTextBoxColumn colSoPhong;
        private DataGridViewTextBoxColumn colLoaiPhong;
        private DataGridViewTextBoxColumn colTang;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colMota;
        private GroupBox grpTimkiem;
        private Panel pnlContent;
        private DataGridViewTextBoxColumn colThaoTac;
    }
}
