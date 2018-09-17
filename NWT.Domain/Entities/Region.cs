using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NWT.Domain
{
    public partial class Region
    {
        public Region()
        {
            Territories = new HashSet<Territory>();
        }


        public int RegionId { get; set; }

        public string RegionDescription { get; set; }


        public virtual ICollection<Territory> Territories { get; set; }
    }
}
