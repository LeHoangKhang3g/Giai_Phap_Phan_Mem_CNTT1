//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        public Department()
        {
            this.DepartmentLocations = new HashSet<DepartmentLocation>();
        }
    
        public long ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<DepartmentLocation> DepartmentLocations { get; set; }
    }
}
