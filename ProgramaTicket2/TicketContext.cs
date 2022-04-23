using Microsoft.EntityFrameworkCore;
using ProgramaTicket2.Entities;

namespace ProgramaTicket2
{
    public class TicketContext : DbContext

    {
        public TicketContext(DbContextOptions<TicketContext> options) : base(options)
        {
        }

        public DbSet<Entrance> Entrances { get; set; }
        public DbSet<Ticket> Tickets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entrance>().HasIndex(r => r.Id).IsUnique();
            modelBuilder.Entity<Ticket>().HasIndex(n => n.Id).IsUnique();
        }
    }
}
