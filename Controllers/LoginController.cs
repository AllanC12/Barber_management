using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BarberManagement.data;
using Microsoft.AspNetCore.Mvc;
using BarberManagement.ViewModels;
using Microsoft.Extensions.Logging;

namespace BarberManagement.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly AppDbContext _context;

        public LoginController(ILogger<LoginController> logger,AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginPost(UserViewModel user){


            return View("Index");
        }

    }
}