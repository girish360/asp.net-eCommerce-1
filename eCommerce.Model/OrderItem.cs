﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int ProductID { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}