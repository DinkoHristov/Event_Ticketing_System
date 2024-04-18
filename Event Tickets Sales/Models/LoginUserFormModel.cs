using System.ComponentModel.DataAnnotations;

namespace Event_Tickets_Sales.Models
{
    public class LoginUserFormModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public bool IsRemembered { get; set; }
    }
}
