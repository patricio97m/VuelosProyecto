using System;
using System.ComponentModel.DataAnnotations;

namespace Vuelos.Dtos
{
    public class VueloDto
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Display(Name = "Numero de vuelo")]
        public string Nombre { get; set; }

        [Display(Name = "Horario de llegada")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm}")]
        public DateTime HorarioDeLLegada { get; set; }

        [StringLength(255)]
        [Display(Name = "Linea aerea")]
        public string LineaAerea { get; set; }

        public bool Demorado { get; set; }
    }
}