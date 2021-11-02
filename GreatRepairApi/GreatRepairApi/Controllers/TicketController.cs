using GreatRepairModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GreatRepairApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {

        [HttpGet]
        public List<Ticket> GetTickets()
        {
            return new List<Ticket>
            {
                new Ticket
                {
                    Priority = 1,
                    Created = DateTime.UtcNow
                },
                new Ticket
                {
                    Priority = 2,
                    Created = DateTime.UtcNow
                }
            };
        }
        

    }
}
