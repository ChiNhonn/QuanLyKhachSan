using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models;

public partial class HoaDon
{
    public int MaHoaDon { get; set; }

    public int MaDatPhong { get; set; }

    public decimal TongTienPhong { get; set; }

    public decimal TongTienDichVu { get; set; }

    public decimal TienThue { get; set; }

    public decimal GiamGia { get; set; }

    public decimal ThanhTien { get; set; }

    public string TrangThai { get; set; } = null!;

    public DateTime NgayLap { get; set; }

    public virtual DatPhong MaDatPhongNavigation { get; set; } = null!;

    public virtual ICollection<ThanhToan> ThanhToans { get; set; } = new List<ThanhToan>();
}
