﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MotocycleSales
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLXMEntities2 : DbContext
    {
        public QLXMEntities2()
            : base("name=QLXMEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<ChuongTrinhKM> ChuongTrinhKMs { get; set; }
        public virtual DbSet<CuaHang> CuaHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KiemKe> KiemKes { get; set; }
        public virtual DbSet<LoaiKhachHang> LoaiKhachHangs { get; set; }
        public virtual DbSet<LoaiSP> LoaiSPs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhapHang> NhapHangs { get; set; }
        public virtual DbSet<QuanLy> QuanLies { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
    
        public virtual int insert_importProduct(string mach, Nullable<System.DateTime> ngaynhap)
        {
            var machParameter = mach != null ?
                new ObjectParameter("mach", mach) :
                new ObjectParameter("mach", typeof(string));
    
            var ngaynhapParameter = ngaynhap.HasValue ?
                new ObjectParameter("ngaynhap", ngaynhap) :
                new ObjectParameter("ngaynhap", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insert_importProduct", machParameter, ngaynhapParameter);
        }
    }
}
