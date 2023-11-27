using System;
using System.Collections.Generic;

namespace SampleApplication.AutoDCR_V_1
{
    public partial class Employee
    {
        public int EmployeeNo { get; set; }
        public string? EmpName { get; set; }
        public string? PhoneNo { get; set; }
        public int? DeptNo { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Department? DeptNoNavigation { get; set; }
    }
}
