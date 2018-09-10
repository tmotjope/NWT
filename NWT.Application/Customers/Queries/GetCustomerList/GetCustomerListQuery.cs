using Microsoft.EntityFrameworkCore;
using NWT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWT.Application.Customers.Queries.GetCustomerList
{
    public class GetCustomerListQuery : IGetCustomerListQuery
    {
        private readonly NorthwindContext _context;

        public GetCustomerListQuery(NorthwindContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CustomerListModel>> Execute()
        {
            return await _context.Customers.Select(c =>
                new CustomerListModel
                {
                    Id = c.CustomerId,
                    Name = c.CompanyName
                }).ToListAsync();
        }
    }
}
