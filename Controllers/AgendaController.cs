using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BarberManagement.Models;



namespace BarberManagement.Controllers;

public class AgendaController : Controller
{
    private readonly ILogger<AgendaController> _logger;

    public AgendaController(ILogger<AgendaController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
