//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechnoBackend.DatabaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CATs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CATs()
        {
            this.CAT_PROD = new HashSet<CAT_PROD>();
        }
    
        public int CAT_Id { get; set; }
        public string CAT_Name { get; set; }
        public string CAT_IMG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAT_PROD> CAT_PROD { get; set; }
    }
}
