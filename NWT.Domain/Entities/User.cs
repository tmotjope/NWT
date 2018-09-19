using NWT.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NWT.Domain
{
    public class User
    {
        public int Id { get; set; }
        public AdAccount AdAccount { get; set; }
    }
}
