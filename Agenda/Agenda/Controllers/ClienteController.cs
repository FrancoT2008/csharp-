using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
