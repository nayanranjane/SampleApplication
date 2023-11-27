using System;
using System.Collections.Generic;

namespace SampleApplication.AutoDCR_V_1
{
    public partial class Company
    {
        public Company()
        {
            Departments = new HashSet<Department>();
            Employees = new HashSet<Employee>();
        }

        public int CompNo { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyLocation { get; set; }
        public string? CompanyWebsite { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
