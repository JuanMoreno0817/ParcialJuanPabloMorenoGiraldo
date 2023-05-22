using System.ComponentModel.DataAnnotations;

namespace ParcialServicios.Entities
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime UseDate { get; set; }
        public Boolean IsUsed { get; set; }
        [Display(Name = "Entrada")]
        [MaxLength(10, ErrorMessage = "El campo {0} debe de tener como máximo {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string EntranceGate { get; set; }
    }
}
