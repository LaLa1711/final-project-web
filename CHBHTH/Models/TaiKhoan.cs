namespace CHBHTH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            DonHangs = new HashSet<DonHang>();
        }

        [Key]
        [Display(Name = "ID")]
        public int MaNguoiDung { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Full name must be 5-50 characters")]
        [Required]
        public string HoTen { get; set; }

        [Display(Name = "Email")]
        [StringLength(50)]
        [Required]
        [EmailAddress(ErrorMessage = "You must enter a valid email")]
        public string Email { get; set; }

        [Display(Name = "Phone")]
        [StringLength(50)]
        [Required]
        [Phone]
        public string Dienthoai { get; set; }

        [Display(Name = "Password")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Password must be 5-50 characters")]
        [Required]
        public string Matkhau { get; set; }

        [Display(Name = "ID Role")]
        public int? IDQuyen { get; set; }

        [Display(Name = "Address")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Address must be 5-200 characters")]
        [Required]
        public string Diachi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }

        public virtual PhanQuyen PhanQuyen { get; set; }
    }
}
