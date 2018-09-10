using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NWT.Application.Customers.Commands.CreateCustomer
{
    public interface ICreateCustomerCommand
    {
        Task Execute(CreateCustomerModel customer);
    }
}
