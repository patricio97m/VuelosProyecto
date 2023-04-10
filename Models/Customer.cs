using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        public bool IsSuscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Tipo de membresía")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Cumpleaños")]
        public DateTime? Birthdate { get; set; }
    }
}