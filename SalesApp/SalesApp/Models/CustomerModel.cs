﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesApp.Models
{
    public class CustomerModel
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; } 
        
        public CustomerModel()
        {
            Sales = new HashSet<SaleModel>();
        }

        public virtual ICollection<SaleModel> Sales { get; set; }
    }
}