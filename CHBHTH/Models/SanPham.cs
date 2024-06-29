namespace CHBHTH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Display(Name = "ID SP")]
        [Key]
        public int MaSP { get; set; }

        [Display(Name = "Name Product")]
        [StringLength(100)]
        public string TenSP { get; set; }

        [Display(Name = "Price")]
        public decimal? GiaBan { get; set; }

        [Display(Name = "Quantity")]
        public int? Soluong { get; set; }

        [Display(Name = "Description")]
        [Column(TypeName = "ntext")]
        public string MoTa { get; set; }

        [Display(Name = "Type")]
        public int? MaLoai { get; set; }

        [Display(Name = "Supplier")]
        public int? MaNCC { get; set; }

        [Display(Name = "Image")]
        [StringLength(100)]
        public string AnhSP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual LoaiHang LoaiHang { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
