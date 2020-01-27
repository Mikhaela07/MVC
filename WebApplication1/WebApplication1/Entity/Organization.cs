using System;
using System.Collections.Generic;

namespace WebApplication1.Entity
{
    public partial class Organization
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int IdOrganization { get; set; }
    }
}
