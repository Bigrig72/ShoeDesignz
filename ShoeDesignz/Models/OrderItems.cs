﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeDesignz.Models
{
    public class OrderItems
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }

    }
}
