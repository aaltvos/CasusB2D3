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
    
    public partial class PRODs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODs()
        {
            this.HAND_SUB_GEB_PROD = new HashSet<HAND_SUB_GEB_PROD>();
            this.REVs = new HashSet<REVs>();
            this.CAT_PROD = new HashSet<HAND_SUB_GEB_PROD>();
            this.PRODTAGS = new HashSet<PRODTAGS>();
        }
    
        public int Prod_ID { get; set; }
        public string Prod_Name { get; set; }
        public System.DateTime Prod_Dat { get; set; }
        public string Prod_Size { get; set; }
        public string Prod_Weight { get; set; }
        public string Prod_Cost { get; set; }
        public Nullable<bool> Prod_Covered { get; set; }
        public string Prod_Avail { get; set; }
        public string Prod_Desc { get; set; }
        public string Prod_Spec { get; set; }
        public string Prod_Req { get; set; }
        public string Prod_Mov { get; set; }
        public Nullable<long> Prod_Views { get; set; }
        public string Prod_Validator { get; set; }
        public System.DateTime Prod_Val_Dat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HAND_SUB_GEB_PROD> HAND_SUB_GEB_PROD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REVs> REVs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HAND_SUB_GEB_PROD> CAT_PROD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODTAGS> PRODTAGS { get; set; }
    }
}
