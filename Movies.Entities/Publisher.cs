using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Entities
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Year { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

       
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
