using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models;

public partial class ChiTietDatPhong
{
    public int MaChiTiet { get; set; }

    public int MaDatPhong { get; set; }

    public int MaPhong { get; set; }

    public decimal GiaMoiDem { get; set; }

    public uint SoDem { get; set; }

    public decimal GiamGia { get; set; }

    public virtual DatPhong MaDatPhongNavigation { get; set; } = null!;

    public virtual Phong MaPhongNavigation { get; set; } = null!;
}
