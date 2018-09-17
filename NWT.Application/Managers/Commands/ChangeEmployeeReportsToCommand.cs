using NWT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NWT.Application.Managers.Commands
{

    public class ChangeEmployeeReportsToCommand : IChangeEmployeeReportsToCommand
    {
        private readonly NorthwindContext _context;

        public ChangeEmployeeReportsToCommand(NorthwindContext context)
        {
            _context = context;
        }
        public void Execute(EmployeeUnderManagerModel model)
        {
            if(model.EmployeeId == model.ManagerId)
            {
                throw new ArgumentException("Employee cannot be managed by the same employee.");
            }

            var employee = _context.Employees.FirstOrDefault(e => e.EmployeeId == model.EmployeeId);
            var managerExists = _context.Employees.Any(e => e.EmployeeId == model.ManagerId); 

            if(employee == null | !managerExists)
            {
                throw new ArgumentException("Employer of manager does not exist");
            }

            employee.ReportsTo = model.ManagerId;
            _context.SaveChanges();
      
        }

       
    }
}
