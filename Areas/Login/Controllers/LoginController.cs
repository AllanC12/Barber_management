using BarberManagement.Models;
using BarberManagement.Repository.Interfaces;
using BarberManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace BarberManagement.Areas.Controllers
{
	public class LoginController : Controller
	{
		private readonly ILogger<LoginController> _logger;

		private readonly IUnityOfWork _uow;

		public LoginController(ILogger<LoginController> logger, IUnityOfWork uow)
		{
			_logger = logger;
			_uow = uow;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult LoginPost(BarberAdminModel barber)
		{

			Authentication authClass = new Authentication(_uow);

			var name = barber.NameAdm;
			var password = barber.PasswordAdm;
			BarberAdminModel barberAuth = authClass.Authenticate(name, password);



			if (barberAuth != null)
			{
				return RedirectToAction("Index", "Agenda");
			}
			else
			{
				ModelState.AddModelError("Error", "Usuário não cadastrado!");
				return View("index");

			}

		}


	}

}
