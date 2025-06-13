﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int? UserId { get; set; }
        public User user { get; set; }
        public List<Order> Orders { get; set; }

    }
}
