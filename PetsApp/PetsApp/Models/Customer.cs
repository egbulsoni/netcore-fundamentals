using System;
using System.Collections.Generic;
using System.Text;

namespace PetsApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MyProperty { get; set; }
        public string? Email { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
