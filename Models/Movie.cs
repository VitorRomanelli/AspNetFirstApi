using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        
        [MinLength(1, ErrorMessage="The movie title needs a minimum with 1 character.")]
        [MaxLength(80, ErrorMessage="The movie title needs a maximum with 80 characters.")]
        [Required(ErrorMessage="Title required.")]
        public string Title { get; set; }
        
        [MinLength(20, ErrorMessage="The movie description needs a minimum with 20 character.")]
        [MaxLength(160, ErrorMessage="The movie description needs a maximum with 160 characters.")]
        public string Description { get; set; }
        
        [Required(ErrorMessage="Classification required.")]
        public string Classification { get; set; }
        
        [Required(ErrorMessage="Gender required.")]
        public string Gender { get; set; }

    }
}