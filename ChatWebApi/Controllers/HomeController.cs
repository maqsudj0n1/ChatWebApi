using ChatWebApi.HubModels;
using ChatWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;

namespace ChatWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IHubContext<ChatHub> _context;

        public HomeController(IHubContext<ChatHub> context)
        {
            _context=context;
        }
        [HttpPost]
        public async Task<IActionResult> SendMessage(Message message)
        {
            await _context.Clients.All.SendAsync("ReceiveMessage", message);
            return Ok();
        }
    }
}
