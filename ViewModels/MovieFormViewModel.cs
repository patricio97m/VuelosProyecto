using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Fecha de lanzamiento")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Stock")]
        [Required]
        [Range(1, 100)]
        public byte? NumberInStock { get; set; }

        [Display(Name = "Género")]
        [Required]
        public byte? GenreId { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Editar película" : "Nueva película";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}