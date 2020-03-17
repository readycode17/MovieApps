using System;
using System.Collections.Generic;

namespace MovieApp.data.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
    }
}
