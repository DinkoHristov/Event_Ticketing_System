using Event_Tickets_Sales.Data;
using Event_Tickets_Sales.Data.Models;
using Event_Tickets_Sales.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Event_Tickets_Sales.Controllers
{
    public class AccountController : Controller
	{
        private EventTicketsDbContext dbContext;
        private readonly SignInManager<User> signInManager;

        public AccountController(EventTicketsDbContext context, SignInManager<User> signInManager)
        {
            this.dbContext = context;
            this.signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserFormModel user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            var dbUser = dbContext.Users.FirstOrDefault(u => u.UserName == user.Username && u.PasswordHash == user.Password);
            
            if (dbUser != null)
            {
                await signInManager.SignInAsync(dbUser, false);

                return RedirectToAction("Index", "Home");
            }

            ViewBag.UserNotFound = true;

            ModelState.Clear();

            return View();
        }

        public IActionResult Register() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterUserFormModel user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            if (this.dbContext.Users.Any(u => u.UserName == user.Username))
            {
                ViewBag.Registered = true;

                return View();
            }

            ViewBag.SuccessfullyAdded = true;

            var newUser = new User
            {
                UserName = user.Username,
                PasswordHash = user.Password,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UCN = user.UCN
            };

            dbContext.Users.Add(newUser);

            dbContext.SaveChanges();

            ModelState.Clear();

            return View();
        }
    }
}
