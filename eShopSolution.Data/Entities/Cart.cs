﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Cart
    {
        public int ID { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public Guid UserId { set; get; }
        public Product Product { set; get; }
        public DateTime DateCreated { set; get; }
    }
}
