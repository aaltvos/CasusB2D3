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
    
    public partial class HAND_SUB_GEB_PROD
    {
        public int Hand_ID { get; set; }
        public int SUB_ID { get; set; }
        public int Prod_ID { get; set; }
    
        public virtual HAND_GEB HAND_GEB { get; set; }
        public virtual SUB_BEG SUB_BEG { get; set; }
        public virtual PROD PROD { get; set; }
    }
}
