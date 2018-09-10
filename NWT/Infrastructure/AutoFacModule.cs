using Autofac;
using NWT.Application.Customers.Queries.GetCustomerList;
using NWT.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NWT.Infrastructure
{
    public class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(GetCustomerListQuery).Assembly)
                .Where(x => x.Name.EndsWith("Command") || x.Name.EndsWith("Query") || x.Name.EndsWith("Service"))
                .AsImplementedInterfaces();

            builder.RegisterType<MachineDateTime>().As<IDateTime>();
        }
    }
}
