using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesApp.Models
{
    public class StoreLocationModel
    {
        public int Id { get; set; }
        public string LocationName { get; set; }

        public StoreLocationModel()
        {
            Sales = new HashSet<SaleModel>();
        }

        public virtual ICollection<SaleModel> Sales { get; set; }
    }
}