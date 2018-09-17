﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NWT.Domain
{
    [Table("Order Details")]
    public partial class OrderDetail
    {
     
        public int OrderId { get; set; }
    
        public int ProductId { get; set; }
 
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }


        public virtual Order Order { get; set; }
  
        public virtual Product Product { get; set; }
    }
}
