//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CasusB2D3.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAT_PROD
    {
        public int CAT_Id { get; set; }
        public int PROD_ID { get; set; }
    
        public virtual CAT CAT { get; set; }
        public virtual PROD PROD { get; set; }
    }
}
