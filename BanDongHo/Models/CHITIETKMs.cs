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
    
    public partial class CHITIETKMs
    {
        public string MAKM { get; set; }
        public int MASP { get; set; }
        public Nullable<int> PHANTRAMKM { get; set; }
    
        public virtual KHUYENMAIs KHUYENMAIs { get; set; }
        public virtual SANPHAMs SANPHAMs { get; set; }
    }
}
