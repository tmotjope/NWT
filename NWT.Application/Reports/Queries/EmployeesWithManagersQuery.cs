using Dapper;
using Microsoft.EntityFrameworkCore;
using NWT.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NWT.Application.Reports.Queries
{
    public class EmployeesWithManagersQuery : IEmployeesWithManagersQuery
    {
        private readonly NorthwindContext _context;

        public EmployeesWithManagersQuery(NorthwindContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<EmployeeManagerModel>> Execute()
        {
            var sql = @"
                        SELECT e.EmployeeId as EmployeeId, e.FirstName as EmployeeFirstName, e.LastName as EmployeeLastName, e.Title as EmployeeTitle,
	                           m.EmployeeId as ManagerId, m.FirstName as ManagerFirstName, m.LastName as ManagetLastName, m.Title as ManagerTitle
                        FROM employees AS e
                        JOIN employees AS m ON e.ReportsTo = m.EmployeeID
                        WHERE e.ReportsTo is not null";
            return await _context.Database.GetDbConnection()
               .QueryAsync<EmployeeManagerModel>(sql);

        }
    }
}
