using System.ComponentModel.DataAnnotations;

namespace CoolEvents_GraduationProject.Models
{
    public class Ticket
    {
        [Key]
        public string TicketId { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        public Event Event { get; set; }
    }
}
