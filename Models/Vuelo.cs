using System;
using System.ComponentModel.DataAnnotations;

namespace Vuelos.Models
{
    public class Vuelo
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        [Display(Name = "Numero de vuelo")]
        public string Nombre { get; set; }

        [Display(Name = "Horario de llegada")]
        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime HorarioDeLLegada { get; set; }

        [StringLength(255)]
        [Required]
        [Display(Name = "Linea aerea")]
        public string LineaAerea { get; set; }

        public bool Demorado { get; set; }



    }
}