using System;
using System.Collections.Generic;

namespace QuanLyKhachSan.Models;

public partial class SuDungDichVu
{
    public int MaSuDung { get; set; }

    public int MaDatPhong { get; set; }

    public int MaDichVu { get; set; }

    public uint SoLuong { get; set; }

    public DateTime ThoiDiemSuDung { get; set; }

    public string? GhiChu { get; set; }

    public virtual DatPhong MaDatPhongNavigation { get; set; } = null!;

    public virtual DichVu MaDichVuNavigation { get; set; } = null!;
}
