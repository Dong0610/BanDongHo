//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanDongHo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHUYENMAIs
    {
        public KHUYENMAIs()
        {
            this.CHITIETKMs = new HashSet<CHITIETKMs>();
        }
    
        public string MAKM { get; set; }
        public string TENKM { get; set; }
        public Nullable<System.DateTime> NGAYBD { get; set; }
        public Nullable<System.DateTime> NGAYKT { get; set; }
    
        public virtual ICollection<CHITIETKMs> CHITIETKMs { get; set; }
    }
}
