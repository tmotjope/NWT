using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NWT.Application.Customers.Queries.GetCustomerList
{
    public interface IGetCustomerListQuery
    {
        Task<IEnumerable<CustomerListModel>> Execute();
    }
}
