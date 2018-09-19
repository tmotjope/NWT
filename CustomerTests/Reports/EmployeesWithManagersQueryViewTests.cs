using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NWT.Application.Reports.Queries;
using NWT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWT.Application.Tests
{
    [TestClass]
    public class EmployeesWithManagersQueryViewTests : TestBase
    {
        [TestMethod]
        public async Task ShouldReturnReport()
        {
            UseSqlite();
            var context = GetDbContext();

            NorthwindInitializer.Initialize(context);
            context.Database.GetDbConnection().Execute(@"
                CREATE VIEW viewEmployeesWithManagers(
                        EmployeeFirstName, EmployeeLastName, EmployeeTitle,
                        ManagerFirstName, ManagetLastName, ManagerTitle)
                AS 
                SELECT e.FirstName as EmployeeFirstName, e.LastName as EmployeeLastName, e.Title as EmployeeTitle,
                        m.FirstName as ManagerFirstName, m.LastName as ManagetLastName, m.Title as ManagerTitle
                FROM employees AS e
                JOIN employees AS m ON e.ReportsTo = m.EmployeeID
                WHERE e.ReportsTo is not null");

            var command = new EmployeesWithManagersQueryView(context);


            var result = await command.Execute();

            var doesContainManager = result.Any(c => c.ManagerTitle == "Vice President, Sales");
            var doesNotContainManager = result.Any(c => c.EmployeeTitle == "Vice President, Sales");
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count(), 8);
            Assert.IsTrue(doesContainManager);
            Assert.IsFalse(doesNotContainManager);

        }
    }
}
