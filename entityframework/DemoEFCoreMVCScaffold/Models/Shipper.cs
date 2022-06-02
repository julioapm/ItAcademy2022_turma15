using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoEFCoreMVCScaffold.Models
{
    public partial class Shipper
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public int ShipperId { get; set; }
        [Display(Name = "Company Name")]
        [StringLength(40)]
        public string CompanyName { get; set; } = null!;
        public string? Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
