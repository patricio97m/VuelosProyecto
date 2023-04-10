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
        [Display(Name = "Fecha agregada")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Fecha de lanzamiento")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Stock")]
        public byte NumberInStock { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Género")]
        [Required]
        public byte GenreId { get; set; }
    }
}