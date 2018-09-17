using Microsoft.VisualStudio.TestTools.UnitTesting;
using NWT.Application.Reports.Queries;
using NWT.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTests.Reports
{
    [TestClass]
    public class EmployeesWithManagersQueryTests : TestBase
    {
        [TestMethod]
        public async Task ShouldReturnReport()
        {
            UseSqlite();

            var context = GetDbContext();
            NorthwindInitializer.Initialize(context);
            var command = new EmployeesWithManagersQuery(context);


            var result = await command.Execute();

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count(), 8);
            Assert.IsTrue(result.Any(c => c.ManagerTitle == "Vice President, Sales"));
            Assert.IsFalse(result.Any(c => c.EmployeeTitle == "Vice President, Sales"));
        }
    }
}
