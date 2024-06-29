namespace CHBHTH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDonHang")]
    public partial class ChiTietDonHang
    {
        [Display(Name = "Order code details")]
        [Key]
        public int CTMaDon { get; set; }

        [Display(Name = "ID Order")]
        public int MaDon { get; set; }

        [Display(Name = "Name Product")]
        public int MaSP { get; set; }

        [Display(Name = "Quantity")]
        public int? SoLuong { get; set; }

        [Display(Name = "Price")]
        public decimal? DonGia { get; set; }

        [Display(Name = "Total")]
        public decimal? ThanhTien { get; set; }

        [Display(Name = "Payment Methods")]
        public int? PhuongThucThanhToan { get; set; }

        public virtual DonHang DonHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
