using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using SalesApp.Models;

namespace SalesApp.Models
{
    public class SaleModel
    {
        public int? Id { get; set; }
        public DateTimeOffset Date { get; set; }

        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public int? EmployeeId { get; set; }

        public SaleModel()
        {
            Products = new HashSet<ProductModel>();    
        }

        
        public virtual CustomerModel Customer { get; set; }
        
        public virtual StoreLocationModel StoreLocation { get; set; }
        
        public virtual EmployeeModel Employee { get; set; }
        
        public virtual ICollection<ProductModel> Products { get; set; }
        
    }
}

    
