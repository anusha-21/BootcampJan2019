//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee_details
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employee_details()
        {
            this.employee_login = new HashSet<employee_login>();
        }
    
        public string employee_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Nullable<System.DateTime> e_dob { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public Nullable<int> phone_no { get; set; }
        public string department { get; set; }
        public string last_organization { get; set; }
        public Nullable<int> last_salary { get; set; }
        public Nullable<System.DateTime> joining_date { get; set; }
        public Nullable<int> work_experience { get; set; }
    
        public virtual department department1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<employee_login> employee_login { get; set; }
    }
}
