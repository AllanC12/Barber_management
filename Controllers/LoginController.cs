using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BarberManagement.data;
using Microsoft.AspNetCore.Mvc;
using BarberManagement.ViewModels;
using Microsoft.Extensions.Logging;
using BarberManagement.Models;
using BarberManagement.Services;
using BarberManagement.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BarberManagement.Controllers
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
                Console.WriteLine("Barbeiro cadastrado");
                TempData["Success"] = $"Bem vindo {name}!";
                return RedirectToAction("Index","Agenda");
            }
            else
            {
                ModelState.AddModelError("Error", "Usuário não cadastrado!");
                return View("index");

            }


        }


    }

}
