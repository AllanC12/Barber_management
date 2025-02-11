using BarberManagement.Models;
using BarberManagement.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BarberManagement.Areas.Barber.controllers
{
	public class BarberController : Controller
	{
		IInsertBarberService _insertBarberService;
		public BarberController(IInsertBarberService insertBarber)
		{
			_insertBarberService = insertBarber;
		}
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult BarberRegister(BarberAdminModel newBarber)
		{
			if (ModelState.IsValid)
			{
				_insertBarberService.InsertBarber(newBarber);
			}
			else
			{
				throw new Exception();
			}

			return View("Index");
		}
	}
}
