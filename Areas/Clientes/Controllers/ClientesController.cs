using Microsoft.AspNetCore.Mvc;

namespace BarberManagement.Areas.Clientes.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
