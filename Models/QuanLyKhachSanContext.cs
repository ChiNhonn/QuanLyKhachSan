using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace QuanLyKhachSan.Models;

public partial class QuanLyKhachSanContext : DbContext
{
    public QuanLyKhachSanContext()
    {
    }

    public QuanLyKhachSanContext(DbContextOptions<QuanLyKhachSanContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietDatPhong> ChiTietDatPhongs { get; set; }

    public virtual DbSet<DatPhong> DatPhongs { get; set; }

    public virtual DbSet<DichVu> DichVus { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }

    public virtual DbSet<Phong> Phongs { get; set; }

    public virtual DbSet<SuDungDichVu> SuDungDichVus { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<ThanhToan> ThanhToans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=quan_ly_khach_san;user=root;password=123456", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.43-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<ChiTietDatPhong>(entity =>
        {
            entity.HasKey(e => e.MaChiTiet).HasName("PRIMARY");

            entity
                .ToTable("chi_tiet_dat_phong")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.MaPhong, "fk_ctdp_phong");

            entity.HasIndex(e => new { e.MaDatPhong, e.MaPhong }, "ma_dat_phong").IsUnique();

            entity.Property(e => e.MaChiTiet).HasColumnName("ma_chi_tiet");
            entity.Property(e => e.GiaMoiDem)
                .HasPrecision(12, 2)
                .HasColumnName("gia_moi_dem");
            entity.Property(e => e.GiamGia)
                .HasPrecision(12, 2)
                .HasColumnName("giam_gia");
            entity.Property(e => e.MaDatPhong).HasColumnName("ma_dat_phong");
            entity.Property(e => e.MaPhong).HasColumnName("ma_phong");
            entity.Property(e => e.SoDem).HasColumnName("so_dem");

            entity.HasOne(d => d.MaDatPhongNavigation).WithMany(p => p.ChiTietDatPhongs)
                .HasForeignKey(d => d.MaDatPhong)
                .HasConstraintName("fk_ctdp_dat_phong");

            entity.HasOne(d => d.MaPhongNavigation).WithMany(p => p.ChiTietDatPhongs)
                .HasForeignKey(d => d.MaPhong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ctdp_phong");
        });

        modelBuilder.Entity<DatPhong>(entity =>
        {
            entity.HasKey(e => e.MaDatPhong).HasName("PRIMARY");

            entity
                .ToTable("dat_phong")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.MaKhachHang, "idx_dat_phong_khach_hang");

            entity.HasIndex(e => new { e.NgayNhanPhong, e.NgayTraPhong }, "idx_dat_phong_ngay");

            entity.Property(e => e.MaDatPhong).HasColumnName("ma_dat_phong");
            entity.Property(e => e.MaKhachHang).HasColumnName("ma_khach_hang");
            entity.Property(e => e.NgayNhanPhong).HasColumnName("ngay_nhan_phong");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.NgayTraPhong).HasColumnName("ngay_tra_phong");
            entity.Property(e => e.SoNguoiLon)
                .HasDefaultValueSql("'1'")
                .HasColumnName("so_nguoi_lon");
            entity.Property(e => e.SoTreEm).HasColumnName("so_tre_em");
            entity.Property(e => e.TrangThai)
                .HasDefaultValueSql("'cho_xac_nhan'")
                .HasColumnType("enum('cho_xac_nhan','da_xac_nhan','da_nhan_phong','da_tra_phong','da_huy')")
                .HasColumnName("trang_thai");

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.DatPhongs)
                .HasForeignKey(d => d.MaKhachHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dat_phong_khach_hang");
        });

        modelBuilder.Entity<DichVu>(entity =>
        {
            entity.HasKey(e => e.MaDichVu).HasName("PRIMARY");

            entity
                .ToTable("dich_vu")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.TenDichVu, "ten_dich_vu").IsUnique();

            entity.Property(e => e.MaDichVu).HasColumnName("ma_dich_vu");
            entity.Property(e => e.DangHoatDong)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("dang_hoat_dong");
            entity.Property(e => e.DonGia)
                .HasPrecision(12, 2)
                .HasColumnName("don_gia");
            entity.Property(e => e.TenDichVu)
                .HasMaxLength(120)
                .HasColumnName("ten_dich_vu");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHoaDon).HasName("PRIMARY");

            entity
                .ToTable("hoa_don")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.MaDatPhong, "ma_dat_phong").IsUnique();

            entity.Property(e => e.MaHoaDon).HasColumnName("ma_hoa_don");
            entity.Property(e => e.GiamGia)
                .HasPrecision(12, 2)
                .HasColumnName("giam_gia");
            entity.Property(e => e.MaDatPhong).HasColumnName("ma_dat_phong");
            entity.Property(e => e.NgayLap)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("ngay_lap");
            entity.Property(e => e.ThanhTien)
                .HasPrecision(12, 2)
                .HasColumnName("thanh_tien");
            entity.Property(e => e.TienThue)
                .HasPrecision(12, 2)
                .HasColumnName("tien_thue");
            entity.Property(e => e.TongTienDichVu)
                .HasPrecision(12, 2)
                .HasColumnName("tong_tien_dich_vu");
            entity.Property(e => e.TongTienPhong)
                .HasPrecision(12, 2)
                .HasColumnName("tong_tien_phong");
            entity.Property(e => e.TrangThai)
                .HasDefaultValueSql("'chua_thanh_toan'")
                .HasColumnType("enum('chua_thanh_toan','thanh_toan_mot_phan','da_thanh_toan')")
                .HasColumnName("trang_thai");

            entity.HasOne(d => d.MaDatPhongNavigation).WithOne(p => p.HoaDon)
                .HasForeignKey<HoaDon>(d => d.MaDatPhong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hoa_don_dat_phong");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKhachHang).HasName("PRIMARY");

            entity
                .ToTable("khach_hang")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Email, "email").IsUnique();

            entity.HasIndex(e => e.SoDienThoai, "so_dien_thoai").IsUnique();

            entity.HasIndex(e => e.SoGiayTo, "so_giay_to").IsUnique();

            entity.Property(e => e.MaKhachHang).HasColumnName("ma_khach_hang");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .HasColumnName("email");
            entity.Property(e => e.HoTen)
                .HasMaxLength(120)
                .HasColumnName("ho_ten");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.QuocTich)
                .HasMaxLength(60)
                .HasColumnName("quoc_tich");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .HasColumnName("so_dien_thoai");
            entity.Property(e => e.SoGiayTo)
                .HasMaxLength(30)
                .HasColumnName("so_giay_to");
        });

        modelBuilder.Entity<LoaiPhong>(entity =>
        {
            entity.HasKey(e => e.MaLoaiPhong).HasName("PRIMARY");

            entity
                .ToTable("loai_phong")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.TenLoaiPhong, "ten_loai_phong").IsUnique();

            entity.Property(e => e.MaLoaiPhong).HasColumnName("ma_loai_phong");
            entity.Property(e => e.GiaCoBan)
                .HasPrecision(12, 2)
                .HasColumnName("gia_co_ban");
            entity.Property(e => e.MoTa)
                .HasColumnType("text")
                .HasColumnName("mo_ta");
            entity.Property(e => e.SucChuaToiDa).HasColumnName("suc_chua_toi_da");
            entity.Property(e => e.TenLoaiPhong)
                .HasMaxLength(100)
                .HasColumnName("ten_loai_phong");
        });

        modelBuilder.Entity<Phong>(entity =>
        {
            entity.HasKey(e => e.MaPhong).HasName("PRIMARY");

            entity
                .ToTable("phong")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.MaLoaiPhong, "fk_phong_loai_phong");

            entity.HasIndex(e => e.TrangThai, "idx_phong_trang_thai");

            entity.HasIndex(e => e.SoPhong, "so_phong").IsUnique();

            entity.Property(e => e.MaPhong).HasColumnName("ma_phong");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(255)
                .HasColumnName("ghi_chu");
            entity.Property(e => e.MaLoaiPhong).HasColumnName("ma_loai_phong");
            entity.Property(e => e.SoPhong)
                .HasMaxLength(10)
                .HasColumnName("so_phong");
            entity.Property(e => e.Tang).HasColumnName("tang");
            entity.Property(e => e.TrangThai)
                .HasDefaultValueSql("'san_sang'")
                .HasColumnType("enum('san_sang','dang_o','bao_tri')")
                .HasColumnName("trang_thai");

            entity.HasOne(d => d.MaLoaiPhongNavigation).WithMany(p => p.Phongs)
                .HasForeignKey(d => d.MaLoaiPhong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_phong_loai_phong");
        });

        modelBuilder.Entity<SuDungDichVu>(entity =>
        {
            entity.HasKey(e => e.MaSuDung).HasName("PRIMARY");

            entity
                .ToTable("su_dung_dich_vu")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.MaDichVu, "fk_sddv_dich_vu");

            entity.HasIndex(e => e.MaDatPhong, "idx_sddv_dat_phong");

            entity.Property(e => e.MaSuDung).HasColumnName("ma_su_dung");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(255)
                .HasColumnName("ghi_chu");
            entity.Property(e => e.MaDatPhong).HasColumnName("ma_dat_phong");
            entity.Property(e => e.MaDichVu).HasColumnName("ma_dich_vu");
            entity.Property(e => e.SoLuong)
                .HasDefaultValueSql("'1'")
                .HasColumnName("so_luong");
            entity.Property(e => e.ThoiDiemSuDung)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("thoi_diem_su_dung");

            entity.HasOne(d => d.MaDatPhongNavigation).WithMany(p => p.SuDungDichVus)
                .HasForeignKey(d => d.MaDatPhong)
                .HasConstraintName("fk_sddv_dat_phong");

            entity.HasOne(d => d.MaDichVuNavigation).WithMany(p => p.SuDungDichVus)
                .HasForeignKey(d => d.MaDichVu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_sddv_dich_vu");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaTaiKhoan).HasName("PRIMARY");

            entity
                .ToTable("tai_khoan")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Email, "email").IsUnique();

            entity.HasIndex(e => e.TenDangNhap, "ten_dang_nhap").IsUnique();

            entity.Property(e => e.MaTaiKhoan).HasColumnName("ma_tai_khoan");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .HasColumnName("email");
            entity.Property(e => e.HoTenHienThi)
                .HasMaxLength(120)
                .HasColumnName("ho_ten_hien_thi");
            entity.Property(e => e.LanDangNhapCuoi)
                .HasColumnType("datetime")
                .HasColumnName("lan_dang_nhap_cuoi");
            entity.Property(e => e.MatKhauHash)
                .HasMaxLength(255)
                .HasColumnName("mat_khau_hash");
            entity.Property(e => e.NgayCapNhat)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("ngay_cap_nhat");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(20)
                .HasColumnName("so_dien_thoai");
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(50)
                .HasColumnName("ten_dang_nhap");
            entity.Property(e => e.TrangThai)
                .HasDefaultValueSql("'hoat_dong'")
                .HasColumnType("enum('hoat_dong','bi_khoa')")
                .HasColumnName("trang_thai");
            entity.Property(e => e.VaiTro)
                .HasDefaultValueSql("'le_tan'")
                .HasColumnType("enum('quan_tri','quan_ly','le_tan','ke_toan')")
                .HasColumnName("vai_tro");
        });

        modelBuilder.Entity<ThanhToan>(entity =>
        {
            entity.HasKey(e => e.MaThanhToan).HasName("PRIMARY");

            entity
                .ToTable("thanh_toan")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.MaHoaDon, "idx_thanh_toan_hoa_don");

            entity.Property(e => e.MaThanhToan).HasColumnName("ma_thanh_toan");
            entity.Property(e => e.MaHoaDon).HasColumnName("ma_hoa_don");
            entity.Property(e => e.MaThamChieu)
                .HasMaxLength(60)
                .HasColumnName("ma_tham_chieu");
            entity.Property(e => e.PhuongThuc)
                .HasColumnType("enum('tien_mat','the','chuyen_khoan','vi_dien_tu')")
                .HasColumnName("phuong_thuc");
            entity.Property(e => e.SoTien)
                .HasPrecision(12, 2)
                .HasColumnName("so_tien");
            entity.Property(e => e.ThoiDiemThanhToan)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("thoi_diem_thanh_toan");

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.ThanhToans)
                .HasForeignKey(d => d.MaHoaDon)
                .HasConstraintName("fk_thanh_toan_hoa_don");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
