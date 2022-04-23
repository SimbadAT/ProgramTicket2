using System.ComponentModel.DataAnnotations;

namespace ProgramaTicket2.Entities
{
    public class Entrance
    {

        public int Id { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]

        public string Description { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
