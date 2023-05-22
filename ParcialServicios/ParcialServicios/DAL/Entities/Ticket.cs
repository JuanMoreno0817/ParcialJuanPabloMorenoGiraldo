using System.ComponentModel.DataAnnotations;

namespace ParcialServicios.DAL.Entities
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime? UseDate { get; set; }
        public bool IsUsed { get; set; }
        [Display(Name = "Entrada")]
        [MaxLength(10, ErrorMessage = "El campo {0} debe de tener como máximo {1} caracteres.")]
        public string? EntranceGate { get; set; }
    }
}
