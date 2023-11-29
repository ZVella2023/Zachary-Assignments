using Data.DataContext;
using Domain.Interface;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class TicketDBRepository : ITickets
    {
        private AirlineDbContext _airlineDbContext;
        public TicketDBRepository(AirlineDbContext airlineDbContext)
        {
            _airlineDbContext = airlineDbContext;
        }

        public bool Book(Ticket ticket)
        {
            // Check for double booking
            if (_airlineDbContext.Tickets.Any(t => t.FlightIdFK == ticket.FlightIdFK && !t.Cancelled))
            {
                return false;
            }

            _airlineDbContext.Tickets.Add(ticket);
            _airlineDbContext.SaveChanges();
            return true;
        }
        public void Cancel(Ticket ticket)
        {
            ticket = _airlineDbContext.Tickets.Find(ticket.Id);

            if (ticket != null)
            {
                ticket.Cancelled = true;
                _airlineDbContext.SaveChanges();
            }
        }

        public Ticket? GetTicket(Guid id)
        {
            return GetTickets().SingleOrDefault(x => x.Id == id);
        }

        public IQueryable<Ticket> GetTickets()
        {
            return _airlineDbContext.Tickets;
        }
    }
}
