using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication2.Models
{
    public partial class Tarif
    {
        public Tarif()
        {
            Client = new HashSet<Client>();
        }

        public int IdTarif { get; set; }
        public string TarifName { get; set; }
        public int? Internet { get; set; }
        public int? CountMinutes { get; set; }
        public int? CountSms { get; set; }
        public decimal? Salary { get; set; }
        public byte[] TariffImage { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
