//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web_banvemaybay.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dattruoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dattruoc()
        {
            this.Ve = new HashSet<Ve>();
        }
    
        public int IDdattruoc { get; set; }
        public Nullable<System.DateTime> NgayDat { get; set; }
        public string Tinhtrang { get; set; }
        public Nullable<int> IDtaikhoan { get; set; }
    
        public virtual TaiKhoan TaiKhoan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ve> Ve { get; set; }
    }
}
