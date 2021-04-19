using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Entities
{
    public class WishList
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int MovieId { get; set; }
        public int CategoryId { get; set; }
        public int ProductionId { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
