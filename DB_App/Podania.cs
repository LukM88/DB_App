//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_App
{
    using System;
    using System.Collections.Generic;
    
    public partial class Podania
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Podania()
        {
            this.Rozmowy1 = new HashSet<Rozmowy>();
        }
    
        public int idPo { get; set; }
        public Nullable<int> idR { get; set; }
        public int idO { get; set; }
        public string imiePo { get; set; }
        public string nazwiskoPo { get; set; }
        public string miasto { get; set; }
        public string adres { get; set; }
        public Nullable<System.DateTime> dataUrPo { get; set; }
        public string wyksztalceniePo { get; set; }
        public Nullable<System.DateTime> dataZlozPo { get; set; }
    
        public virtual Oferty Oferty { get; set; }
        public virtual Rozmowy Rozmowy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rozmowy> Rozmowy1 { get; set; }
    }
}
