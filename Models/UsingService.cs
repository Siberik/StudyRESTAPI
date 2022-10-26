using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication2.Models
{
    public partial class UsingService
    {
        public int Id { get; set; }
        public string CodeService { get; set; }
        public DateTime? DateConnection { get; set; }
        public string NumberPhone { get; set; }

        public virtual Services CodeServiceNavigation { get; set; }
        public virtual Client NumberPhoneNavigation { get; set; }
    }
}
