using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Fecha de lanzamiento")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Stock")]
        [Required]
        [Range(1, 100)]
        public byte NumberInStock { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Género")]
        [Required]
        public byte GenreId { get; set; }
    }
}