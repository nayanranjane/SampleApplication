using System;
using System.Collections.Generic;

namespace SampleApplication.AutoDCR_V_1
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DeptNo { get; set; }
        public string? DeptName { get; set; }
        public string? DeptLocation { get; set; }
        public int? CompanyNo { get; set; }

        public virtual Company? CompanyNoNavigation { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
