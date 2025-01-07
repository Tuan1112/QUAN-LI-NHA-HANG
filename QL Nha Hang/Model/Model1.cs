using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QL_Nha_Hang.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<MonAn> MonAns { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<ThongKe> ThongKes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .HasMany(e => e.DonHangs)
                .WithRequired(e => e.Ban)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ban>()
                .HasMany(e => e.ThongKes)
                .WithRequired(e => e.Ban)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.ThanhTien)
                .HasPrecision(29, 2);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonAn>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.MonAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.DonHangs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);
        }
    }
}
