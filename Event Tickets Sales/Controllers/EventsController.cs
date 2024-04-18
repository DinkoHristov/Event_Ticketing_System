using Event_Tickets_Sales.Data;
using Event_Tickets_Sales.Data.Models;
using Event_Tickets_Sales.Models;
using Microsoft.AspNetCore.Mvc;

namespace Event_Tickets_Sales.Controllers
{
    public class EventsController : Controller
    {
        private EventTicketsDbContext dbContext;

        public EventsController(EventTicketsDbContext context)
        {
            this.dbContext = context;
        }

        public IActionResult All()
        {
            var allEvents = dbContext.Events
                .Select(e => new AllEventsModel
                {
                    Name = e.Name,
                    Start = e.Start.ToString("dd-MMM-yyyy HH:mm"),
                    End = e.End.ToString("dd-MMM-yyyy HH:mm"),
                    Place = e.Place
                })
                .ToList();

            return View(allEvents);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EventFormModel newEvent)
        {
            if (!ModelState.IsValid)
            {
                return View(newEvent);
            }

            if (dbContext.Events.Any(e => e.Name == newEvent.Name))
            {
                ViewBag.Exists = true;

                return View();
            }

            var myEvent = new Event
            {
                Name = newEvent.Name,
                Place = newEvent.Place,
                Start = newEvent.Start,
                End = newEvent.End,
                TotalTickets = newEvent.TotalTickets,
                PricePerTicket = newEvent.PricePerTicket
            };

            dbContext.Events.Add(myEvent);

            dbContext.SaveChanges();

            ViewBag.SuccessfullyAdded = true;

            ModelState.Clear();

            return View();
        }
    }
}
