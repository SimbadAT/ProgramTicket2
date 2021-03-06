
using ProgramaTicket2.Entities;

namespace ProgramaTicket2.Data
{

    public class SeedDb
    {
        private readonly TicketContext _context;


        public SeedDb(TicketContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckEntrancesync();
            await CheckTicketAsync();
        }


        private async Task CheckTicketAsync()
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 0; i < 5000; i++)
                {
                    _context.Tickets.Add(new Ticket
                    {
                        WasUsed = false,
                        Document = "",
                        FirstName = "",

                        Entrance = new Entrance()
                        {
                            Description = ""
                        }
                    });
                    await _context.SaveChangesAsync();
                }

            }


        }
        private async Task CheckEntrancesync()
        {
            _context.Entrances.Add(new Entrance { Description = "Norte" });
            _context.Entrances.Add(new Entrance { Description = "Sur" });
            _context.Entrances.Add(new Entrance { Description = "Oriental" });
            _context.Entrances.Add(new Entrance { Description = "Occidental" });
            await _context.SaveChangesAsync();
        }
    }
}


