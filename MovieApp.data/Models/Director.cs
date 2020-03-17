using System;
using System.Collections.Generic;

namespace MovieApp.data.Models
{
    public partial class Director
    {
        public Director()
        {
            Movie = new HashSet<Movie>();
        }

        public int DirectorId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int AddressId { get; set; }
        public int? HobbyId { get; set; }

        public virtual ICollection<Movie> Movie { get; set; }
    }
}
