using System;
using System.Collections.Generic;

namespace Beeld_c.Models
{
    public class Brigade
    {
        public string Description { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }
        public bool IsVerified { get; set; }
        public List<Category> Categories { get; set; }
        public int ServiceCount { get; set; }
        public int ViewCount { get; set; }
    }
}