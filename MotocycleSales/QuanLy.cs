//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class QuanLy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuanLy()
        {
            this.ChuongTrinhKMs = new HashSet<ChuongTrinhKM>();
        }
    
        public string MaQuanLy { get; set; }
        public string TenQuanLy { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> SoNgayLV { get; set; }
        public Nullable<int> NamVL { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuongTrinhKM> ChuongTrinhKMs { get; set; }
    }
}