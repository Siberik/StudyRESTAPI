using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication2.Models
{
    public partial class Client
    {
        public Client()
        {
            UsingService = new HashSet<UsingService>();
        }

        public string NumberPhone { get; set; }
        public int IdTarif { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PatronymicName { get; set; }
        public DateTime? DateBirthday { get; set; }
        public string PassportSerial { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? DatePassport { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual Tarif IdTarifNavigation { get; set; }
        public virtual ICollection<UsingService> UsingService { get; set; }
    }
}
