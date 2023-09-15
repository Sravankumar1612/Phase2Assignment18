﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment18.Models
{

     [Table("Movie")]
    public class Movie
    {
            [Key]
            public int Id { get; set; }
            [Required]
            public string Title { get; set; }
            [Required]
            public string Genre { get; set; }
            [Required]
            public string Director { get; set; }
    }
    
}
