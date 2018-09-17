using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NWT.Domain
{
    public partial class EmployeeTerritory
    {

        public int EmployeeId { get; set; }

        public string TerritoryId { get; set; }


        public virtual Employee Employee { get; set; }

        public virtual Territory Territory { get; set; }
    }
}
