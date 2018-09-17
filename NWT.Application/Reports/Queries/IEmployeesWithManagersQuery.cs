using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NWT.Application.Reports.Queries
{
    public interface IEmployeesWithManagersQuery
    {
        Task<IEnumerable<EmployeeManagerModel>> Execute();
    }
}
