using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NWT.Application.Customers.Commands.DeleteCustomer
{
    public interface IDeleteCustomerCommand
    {
        Task Execute(string id);
    }
}
