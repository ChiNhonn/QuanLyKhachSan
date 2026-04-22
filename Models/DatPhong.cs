using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models;

public partial class DatPhong
{
    public int MaDatPhong { get; set; }

    public int MaKhachHang { get; set; }

    public DateOnly NgayNhanPhong { get; set; }

    public DateOnly NgayTraPhong { get; set; }

    public byte SoNguoiLon { get; set; }

    public byte SoTreEm { get; set; }

    public string TrangThai { get; set; } = null!;

    public DateTime NgayTao { get; set; }

    public virtual ICollection<ChiTietDatPhong> ChiTietDatPhongs { get; set; } = new List<ChiTietDatPhong>();

    public virtual HoaDon? HoaDon { get; set; }

    public virtual KhachHang MaKhachHangNavigation { get; set; } = null!;

    public virtual ICollection<SuDungDichVu> SuDungDichVus { get; set; } = new List<SuDungDichVu>();
}
