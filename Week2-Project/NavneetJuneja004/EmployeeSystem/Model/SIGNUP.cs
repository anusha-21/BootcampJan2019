//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SIGNUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SIGNUP()
        {
            this.EMPLOYEEs = new HashSet<EMPLOYEE>();
        }
    
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string id { get; set; }
        public string pswd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPLOYEE> EMPLOYEEs { get; set; }
    }
}
