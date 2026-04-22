using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models;

public partial class Phong
{
    public int MaPhong { get; set; }

    public string SoPhong { get; set; } = null!;

    public int MaLoaiPhong { get; set; }

    public byte? Tang { get; set; }

    public string TrangThai { get; set; } = null!;

    public string? GhiChu { get; set; }

    public virtual ICollection<ChiTietDatPhong> ChiTietDatPhongs { get; set; } = new List<ChiTietDatPhong>();

    public virtual LoaiPhong MaLoaiPhongNavigation { get; set; } = null!;
}
