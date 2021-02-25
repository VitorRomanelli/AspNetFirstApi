using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Movie
    {
        public Movie()
        {
            Id = Guid.NewGuid();
        }
        
        [Key]
        public Guid Id { get; set; }
        
        [MinLength(1, ErrorMessage="The movie title needs a minimum with 1 character.")]
        [MaxLength(80, ErrorMessage="The movie title needs a maximum with 80 characters.")]
        [Required(ErrorMessage="Title required.")]
        public string Title { get; set; }
        
        [MinLength(20, ErrorMessage="The movie description needs a minimum with 20 character.")]
        [MaxLength(1200, ErrorMessage="The movie description needs a maximum with 1200 characters.")]
        public string Description { get; set; }
        
        [Required(ErrorMessage="Classification required.")]
        public string Classification { get; set; }
        
        [Required(ErrorMessage="Gender required.")]
        public string Gender { get; set; }

        [Required(ErrorMessage="Images required.")]
        public List<Image> Images { get; set; }
    }
}