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
    
    public partial class USERs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USERs()
        {
            this.REVs = new HashSet<REVs>();
        }
    
        public int USER_Id { get; set; }
        public string USER_Name { get; set; }
        public string USER_PW { get; set; }
        public int USER_Sec { get; set; }
        public System.DateTime USER_Val_dat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REVs> REVs { get; set; }
        public virtual SESSIONS SESSIONS { get; set; }
    }
}
