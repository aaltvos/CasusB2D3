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
    
    public partial class NEWS
    {
        public int News_Id { get; set; }
        public string News_Title { get; set; }
        public string News_Body { get; set; }
        public string News_IMG { get; set; }
        public string News_Link { get; set; }
    
        public virtual USERs USERs { get; set; }
    }
}
