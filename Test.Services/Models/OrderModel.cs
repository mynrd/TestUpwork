﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Services.Models
{
    public class OrderModel
    {
        public OrderModel()
        {
            this.Products = new List<OrderProduct>();
        }

        public int OrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public IEnumerable<OrderProduct> Products { get; set; }
    }
}