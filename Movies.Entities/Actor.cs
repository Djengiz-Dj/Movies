using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Entities
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Country { get; set; }
        public DateTime DateBirth { get; set; }

        public int MovieId { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
