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
    
    public partial class EVENT
    {
        public int Event_Id { get; set; }
        public string Event_Name { get; set; }
        public string Event_Body { get; set; }
        public string Event_Address { get; set; }
        public string Event_Link { get; set; }
    
        public virtual USERs USERs { get; set; }
    }
}