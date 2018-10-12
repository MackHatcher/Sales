﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesApp.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public ProductModel()
        {
            Sales = new HashSet<SaleModel>();
        }

        public virtual ICollection<SaleModel> Sales { get; set; }
    }
}