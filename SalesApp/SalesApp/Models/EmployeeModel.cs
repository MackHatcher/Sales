using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SalesApp.Models
{
    public class EmployeeModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }

        public EmployeeModel()
        {
            Sales = new HashSet<SaleModel>();
        }
        
        public virtual ICollection<SaleModel> Sales { get; set; }
    }
}