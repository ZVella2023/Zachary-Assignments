using Data.Repositories;
using Domain.Interface;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class TicketsController : Controller
    {
        private ITickets _
        private TicketDBRepository _ticketDBRepository;
        public TicketsController(TicketDBRepository ticketDBRepository)
        {
            _ticketDBRepository = ticketDBRepository;
        }
        public IActionResult Index()
        {
            IQueryable<Ticket> list = _ticketDBRepository.GetTickets();

            return View(list);
        }
    }
}
