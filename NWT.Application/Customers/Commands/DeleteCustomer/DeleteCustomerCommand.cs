using Microsoft.EntityFrameworkCore;
using NWT.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWT.Application.Customers.Commands.DeleteCustomer
{
    public class DeleteCustomerCommand : IDeleteCustomerCommand
    {
        private readonly NorthwindContext _context;

        public DeleteCustomerCommand(NorthwindContext context)
        {
            _context = context;
        }
        public async Task Execute(string id)
        {
            var entity = await _context.Customers.SingleAsync(c => c.CustomerId == id);

            _context.Customers.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
