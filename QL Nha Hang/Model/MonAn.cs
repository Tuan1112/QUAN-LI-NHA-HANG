namespace QL_Nha_Hang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonAn")]
    public partial class MonAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonAn()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        public int MaMonAn { get; set; }

        [Required]
        [StringLength(100)]
        public string TenMonAn { get; set; }

        public decimal Gia { get; set; }

        [StringLength(50)]
        public string DanhMuc { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiMon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
