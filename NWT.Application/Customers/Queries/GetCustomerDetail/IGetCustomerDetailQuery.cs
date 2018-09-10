using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NWT.Application.Customers.Queries.GetCustomerDetail
{
    public interface IGetCustomerDetailQuery
    {
        Task<CustomerDetailModel> Execute(string id);
    }
}
