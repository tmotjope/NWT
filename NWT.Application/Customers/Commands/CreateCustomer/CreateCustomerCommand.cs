using NWT.Application.Interfaces;
using NWT.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NWT.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand : ICreateCustomerCommand
    {
        private readonly NorthwindContext _context;
        private readonly INotificationService _notification;

        public CreateCustomerCommand(NorthwindContext context, INotificationService notification)
        {
            _context = context;
            _notification = notification;
        }
        public async Task Execute(CreateCustomerModel model)
        {
            var entity = new Customer
            {
                CustomerId = model.Id,
                Address = model.Address,
                City = model.City,
                CompanyName = model.CompanyName,
                ContactName = model.ContactName,
                ContactTitle = model.ContactTitle,
                Country = model.Country,
                Fax = model.Fax,
                Phone = model.Phone,
                PostalCode = model.PostalCode
            };

            _context.Customers.Add(entity);
            await _context.SaveChangesAsync();

            _notification.send();
        }
    }
}
