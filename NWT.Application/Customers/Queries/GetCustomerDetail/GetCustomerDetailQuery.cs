using Microsoft.EntityFrameworkCore;
using NWT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWT.Application.Customers.Queries.GetCustomerDetail
{
    public class GetCustomerDetailQuery : IGetCustomerDetailQuery
    {
        private readonly NorthwindContext _context;

        public GetCustomerDetailQuery(NorthwindContext context)
        {
            _context = context;
        }
        public async Task<CustomerDetailModel> Execute(string id)
        {
            var entity = await _context.Customers.SingleOrDefaultAsync(c => c.CustomerId == id);

            return new CustomerDetailModel {
                Id = entity?.CustomerId,
                Address = entity?.Address,
                City = entity?.City,
                CompanyName = entity?.CompanyName,
                ContactName = entity?.ContactName,
                ContactTitle = entity?.ContactTitle,
                Country = entity?.Country,
                Fax = entity?.Fax,
                Phone = entity?.Phone,
                PostalCode = entity?.PostalCode,
                Region = entity?.Region               
            };

        }
    }
}
