using System;
using System.Collections.Generic;

namespace MovieApp.data.Models
{
    public partial class Hobby
    {
        public int Id { get; set; }
        public string HobbyName { get; set; }
        public int? Rating { get; set; }
    }
}
