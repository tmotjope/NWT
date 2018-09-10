using System;
using System.Collections.Generic;
using System.Text;

namespace NWT.Common
{
    public class MachineDateTime : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
