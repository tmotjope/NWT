using Microsoft.EntityFrameworkCore;
using NWT.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerTests
{
    
    public class TestBase
    {
        private bool useSqlite;

        public NorthwindContext GetDbContext()
        {
            var builder = new DbContextOptionsBuilder<NorthwindContext>();
            if(useSqlite)
            {
                builder.UseSqlite("DataSource=:memory:", x => { });
            }
            else
            {
                builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            }

            var dbContext = new NorthwindContext(builder.Options);
            if(useSqlite)
            {
                dbContext.Database.OpenConnection();
            }
            dbContext.Database.EnsureCreated();
            return dbContext;

        }

        public void UseSqlite() => useSqlite = true;
    }
   
}
