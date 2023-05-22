using Microsoft.EntityFrameworkCore;
using ParcialServicios.DAL.Entities;

namespace ParcialServicios.DAL
{
    public class SeederDB
    {
        private readonly DataBaseContext _context;

        public SeederDB(DataBaseContext context)
        { 
            _context = context;
        }

        public async Task SeederAsync() 
        {
            await _context.Database.EnsureCreatedAsync();
            await PopulateTicketsAsync();
        }
        private async Task PopulateTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 0; i < 5; i++)
                {
                    _context.Tickets.Add(new Ticket
                    {
                        Id = new Guid(),
                        EntranceGate = null,
                        IsUsed = false,
                        UseDate = null
                    });

                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
