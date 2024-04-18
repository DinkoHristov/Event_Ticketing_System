using Event_Tickets_Sales.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Event_Tickets_Sales.Data
{
	public class EventTicketsDbContext : IdentityDbContext<User>
	{
		public EventTicketsDbContext(DbContextOptions<EventTicketsDbContext> options)
			: base(options)
		{

		}

        public DbSet<User> Users { get; set; }

        public DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<User>()
				.HasIndex(e => e.UCN)
				.IsUnique();

			base.OnModelCreating(builder);
		}
	}
}
