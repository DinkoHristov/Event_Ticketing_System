using Event_Tickets_Sales.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Event_Tickets_Sales.Data.Models
{
	public class User : IdentityUser
	{
        [Required]
        [Display(Name = "First Name")]
		public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Unique Citizen Number (UCN)")]
        public string UCN { get; set; }

        [Required]
        public Role Role { get; set; }
    }
}
