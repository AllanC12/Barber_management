using Microsoft.AspNetCore.Mvc;
using BarberManagement.DTOs;
using BarberManagement.Repository.Interfaces;

namespace BarberManagement.Areas.Clients.Controllers
{
    public class ClientsController : Controller
    {
        ISearchClientService _searchClientService;

        public ClientsController(ISearchClientService searchClient)
        {
            _searchClientService = searchClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchClient([FromBody] SearchTermDto searchTerm)
        {
            string name = searchTerm.SearchTerm;

            var clients =  _searchClientService.SearchClient(name);

            return Ok(clients);
        }
    }
}
