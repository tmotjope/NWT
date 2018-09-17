using System;
using System.Collections.Generic;
using System.Text;

namespace NWT.Application.Managers.Commands
{
    public interface IChangeEmployeeReportsToCommand
    {
        void Execute(EmployeeUnderManagerModel model);
    }
}
