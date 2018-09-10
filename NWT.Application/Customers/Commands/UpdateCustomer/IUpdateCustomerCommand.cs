using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NWT.Application.Customers.Commands.UpdateCustomer
{
    public interface IUpdateCustomerCommand
    {
        Task Execute(UpdateCustomerModel customer); 
    }
}
