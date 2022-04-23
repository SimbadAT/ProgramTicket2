using System.ComponentModel.DataAnnotations;

namespace ProgramaTicket2.Models
{
    public class EditTicketViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Usado")]
        public bool WasUsed { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Document { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string FirstName { get; set; }

        [Display(Name = "Fecha")]
        public DateTime? Date { get; set; }
    }
}