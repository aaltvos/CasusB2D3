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
    
    public partial class SUB_GEB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUB_GEB()
        {
            this.HAND_SUB_GEB_PROD = new HashSet<HAND_SUB_GEB_PROD>();
        }
    
        public int Sub_ID { get; set; }
        public string Sub_Name { get; set; }
        public string Sub_IMG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HAND_SUB_GEB_PROD> HAND_SUB_GEB_PROD { get; set; }
    }
}