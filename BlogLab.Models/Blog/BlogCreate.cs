using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MinLength(8, ErrorMessage = "Must be 8-40 characters")]
        [MaxLength(40, ErrorMessage = "Must be 8-40 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [MinLength(300, ErrorMessage = "Must be 300-3000 characters")]
        [MaxLength(3000, ErrorMessage = "Must be 300-3000 characters")]
        public string Content { get; set; }
        public int? PhtoId { get; set; }


    }
}

