using System.ComponentModel.DataAnnotations;

namespace Event_Tickets_Sales.Data.Models
{
	public class Event
	{
		[Key]
        public Guid Id { get; set; }

		[Required]
        public string Name { get; set; }

		[Required]
        public string Place { get; set; }

		[Required]
        public DateTime Start { get; set; }

		[Required]
        public DateTime End { get; set; }

		[Required]
		[Display(Name = "Total Tickets")]
        public int TotalTickets { get; set; }

		[Required]
		[Display(Name = "Price Per Ticket")]
        public decimal PricePerTicket { get; set; }
    }
}
