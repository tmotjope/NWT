﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NWT.Application.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerModel
    {
        [MaxLength(5)]
        public string Id { get; set; }

        [MaxLength(60)]
        public string Address { get; set; }

        [MaxLength(15)]
        public string City { get; set; }

        [Required]
        [MaxLength(40)]
        public string CompanyName { get; set; }

        [MaxLength(30)]
        public string ContactName { get; set; }

        [MaxLength(30)]
        public string ContactTitle { get; set; }

        [MaxLength(15)]
        public string Country { get; set; }

        [MaxLength(24)]
        public string Fax { get; set; }

        [MaxLength(24)]
        public string Phone { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }

        [MaxLength(15)]
        public string Region { get; set; }
    }
}
