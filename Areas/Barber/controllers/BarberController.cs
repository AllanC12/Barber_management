using Microsoft.AspNetCore.Mvc;

namespace BarberManagement.Areas.Barber.controllers
{
	public class BarberController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult BarberRegister()
		{

			return View();
		}
	}
}
