using System.ComponentModel.DataAnnotations;

namespace Event_Tickets_Sales.Models
{
    public class EventFormModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Place { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{dd-Mmm-yyyy hh:mm}")]
        public DateTime Start { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{dd-Mmm-yyyy hh:mm}")]
        public DateTime End { get; set; }

        [Required]
        [Display(Name = "Total Tickets")]
        public int TotalTickets { get; set; }

        [Required]
        [Display(Name = "Price per Ticket")]
        public decimal PricePerTicket { get; set; }
    }
}
