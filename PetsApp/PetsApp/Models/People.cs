using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PetsApp.Models
{
    public partial class People
    {
        public People()
        {
            Addresses = new HashSet<Addresses>();
            EmailAddresses = new HashSet<EmailAddresses>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<EmailAddresses> EmailAddresses { get; set; }
    }
}
