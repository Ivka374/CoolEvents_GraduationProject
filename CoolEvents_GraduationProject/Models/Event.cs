using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CoolEvents_GraduationProject.Models
{
    public class Event
    {
        [Key]
        public string EventId { get; set; }

        [Required(ErrorMessage = "Please enter the name of the event")]
        [StringLength(64)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please add a decription of the event")]
        [StringLength(255)]
        [AllowNull]
        public string Description { get; set; }

        [DataType(DataType.ImageUrl)]
        [Required(ErrorMessage = "Please add an image to represent the event")]
        public string Image { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd/MM/YYYY}")]
        [Required(ErrorMessage = "Please enter the date of the event")]
        public DateTime Date { get; set; }
    }
}
