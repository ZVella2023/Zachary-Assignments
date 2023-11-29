using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface ITickets
    {
        IQueryable<Ticket> GetTickets();
        Ticket? GetTicket(Guid id);
        bool Book(Ticket ticket);
        void Cancel(Ticket ticket);
    }
}
