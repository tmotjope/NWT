using Microsoft.VisualStudio.TestTools.UnitTesting;
using NWT.Application.Managers.Commands;
using NWT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NWT.Application.Tests
{
    [TestClass]
    public class ChangeEmployerReportToCommandTest : TestBase
    {
        [TestMethod]
        public void ShouldMoveEmployeeUnderManager()
        {
            //Prepare
            var context = InitAndGetDbContext();
            var command = new ChangeEmployeeReportsToCommand(context);

            //execute
            int managerId = 2;
            command.Execute(new EmployeeUnderManagerModel
            {
                EmployeeId = 1,
                ManagerId = managerId
            });

            var result = context.Employees.Where(e => (e.EmployeeId == 1 && e.ReportsTo == managerId));

            Assert.AreEqual(result.Count(), 1);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void ShouldThrowArgumentExceptionIfEmployeeAndManagerIdSame()
        {
            //Prepare
            var context = InitAndGetDbContext();
            var command = new ChangeEmployeeReportsToCommand(context);

            //execute
            int managerId = 1;
            command.Execute(new EmployeeUnderManagerModel
            {
                EmployeeId = 1,
                ManagerId = managerId
            });

          
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void ShouldThrowArgumentExceptionIfEmployeeOrManagerNotFound()
        {
            var context = InitAndGetDbContext();
            var command = new ChangeEmployeeReportsToCommand(context);

            var managerId = 3;
            command.Execute(new EmployeeUnderManagerModel
            {
                EmployeeId = 1,
                ManagerId = managerId
            });
           
        }

        private NorthwindContext InitAndGetDbContext()
        {
            //UseSqlite();
            var context = GetDbContext();

            context.Employees.Add(new Employee
            {
                EmployeeId = 1,
                FirstName = "",
                LastName = ""
            });
            context.Employees.Add(new Employee
            {
                EmployeeId = 2,
                FirstName = "",
                LastName = ""
            });
            context.SaveChanges();
            return context;
        }
    }
}
