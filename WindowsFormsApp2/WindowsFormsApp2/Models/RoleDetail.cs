//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoleDetail
    {
        public int Id { get; set; }
        public string NameAction { get; set; }
        public Nullable<int> IdEmployee { get; set; }
        public Nullable<int> IdRole { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Role Role { get; set; }
    }
}
