using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PetsApp.Models
{
    public partial class EmailAddresses
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public int? PersonId { get; set; }

        public virtual People Person { get; set; }
    }
}
