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
    
    public partial class SESSIONS
    {
        public int SESSIONS_ID { get; set; }
        public string SESSIONS_Token { get; set; }
        public string SESSIONS_TTL { get; set; }
    
        public virtual USERs USER { get; set; }
    }
}
