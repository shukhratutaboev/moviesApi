using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace movies.Models
{
    public class UpdatedMovie
    {
        [Required]
        [Display(Name="File")]
        public IFormFile Image { get; set; }
        
        // [Required]
        // public IEnumerable<Guid> GenreIds { get; set; }

        // [Required]
        // public IEnumerable<Guid> ActorIds { get; set; }
    }
}