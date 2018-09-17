using System;
using System.Collections.Generic;
using System.Text;

namespace NWT.Application.Reports.Queries
{
    public class EmployeeManagerModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeTitle { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public int ManagerId { get; set; }
        public string ManagerTitle { get; set; }
        public string ManagerName { get; set; }
        public string ManagerSurname { get; set; }
    }
}
