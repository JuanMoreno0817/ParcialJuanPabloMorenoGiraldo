using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ParcialServicios.DAL.Entities;
using System.Net.Sockets;

namespace WebPages.Controllers
{
    public class TicketController : Controller
    {
        private readonly IHttpClientFactory _httpClient;
        public TicketController(IHttpClientFactory httpClient) 
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index(Guid? ticketId)
        {
            var url = String.Format("https://localhost:7098/api/Ticket/GetTicketById/{0}", ticketId);
            var json = await _httpClient.CreateClient().GetStringAsync(url);
            Ticket ticket = JsonConvert.DeserializeObject<Ticket>(json);
            return View(ticket);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid? ticketId)
        {
            var url = String.Format("https://localhost:7098/api/Ticket/GetTicketById/{0}", ticketId);
            var json = await _httpClient.CreateClient().GetStringAsync(url);
            Ticket ticket = JsonConvert.DeserializeObject<Ticket>(json);
            return View(ticket);
        }
    }
}
