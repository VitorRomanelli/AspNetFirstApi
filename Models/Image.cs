using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Image
    {
        public Image()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage="Url required.")]
        public string Url { get; set; }
    }
}