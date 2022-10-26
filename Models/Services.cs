using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication2.Models
{
    public partial class Services
    {
        public Services()
        {
            UsingService = new HashSet<UsingService>();
        }

        public string CodeService { get; set; }
        public string ServiceName { get; set; }
        public decimal? SalaryService { get; set; }
        public decimal? ConnectPrice { get; set; }

        public virtual ICollection<UsingService> UsingService { get; set; }
    }
}
