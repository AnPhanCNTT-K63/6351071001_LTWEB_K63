//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarBackend
{
    using System;
    using System.Collections.Generic;
    
    public partial class HANGSANXUAT
    {
        public HANGSANXUAT()
        {
            this.SANXUATXEs = new HashSet<SANXUATXE>();
        }
    
        public int MaHSX { get; set; }
        public string TenHSX { get; set; }
        public string Diachi { get; set; }
        public string Tieusu { get; set; }
        public string Dienthoai { get; set; }
    
        public virtual ICollection<SANXUATXE> SANXUATXEs { get; set; }
    }
}