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
    
    public partial class Oferty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oferty()
        {
            this.Podania = new HashSet<Podania>();
        }
    
        public int idO { get; set; }
        public int idS { get; set; }
        public int idD { get; set; }
        public Nullable<System.DateTime> dataWystaw { get; set; }
    
        public virtual stan_dzial stan_dzial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Podania> Podania { get; set; }
    }
}
