using Dapper;
using Microsoft.EntityFrameworkCore;
using NWT.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NWT.Application.Reports.Queries
{
    public class EmployeesWithManagersQueryView : IEmployeesWithManagersQuery
    {
        private readonly NorthwindContext _context;

        public EmployeesWithManagersQueryView(NorthwindContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<EmployeeManagerModel>> Execute()
        {
            var sql = "select * from viewEmployeesWithManagers";
            return await _context.Database.GetDbConnection()
               .QueryAsync<EmployeeManagerModel>(sql);

        }
    }
}
