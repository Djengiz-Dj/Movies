﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }



        public virtual ICollection<Movie> Movies { get; set; }
    }
}
