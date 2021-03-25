using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieAssignment3.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage ="Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Year is required")]
        public int Year { get; set; }

        [Required(ErrorMessage ="Director is required")]
        public string Director { get; set; }

        [Required(ErrorMessage ="Rating is required")]
        public string Rating { get; set; }

        public bool? Edited { get; set; }

        public string LentTo { get; set; }

        [StringLength(25)]
        public string Notes { get; set; }
    }
}
