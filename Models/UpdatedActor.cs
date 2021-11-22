using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace movies.Models
{
    public class UpdatedActor
    {
        [Required]
        [Display(Name="File")]
        public IFormFile Image { get; set; }
    }
}