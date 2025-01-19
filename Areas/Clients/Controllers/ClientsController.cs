using BarberManagement.DTOs;
using BarberManagement.Models;
using BarberManagement.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BarberManagement.Areas.Clients.Controllers
{
	public class ClientsController : Controller
	{
		ISearchClientService _searchClientService;
		IInsertClientService _inserClientService;

		public ClientsController(
			ISearchClientService searchClient,
			IInsertClientService inserClient)
		{
			_searchClientService = searchClient;
			_inserClientService = inserClient;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult RegisterClient()
		{
			return View();
		}

		[HttpPost]
		public IActionResult RegisterClientPost(ClientModel dataClient)
		{
			if (ModelState.IsValid)
			{
				_inserClientService.InsertClient(dataClient);
				TempData["SuccessRegister"] = "Cliente Cadastrado com sucesso!";
			}
			else
			{
				ModelState.AddModelError("Error", "Não foi possível cadastrar o cliente!");
			}

			return RedirectToAction("RegisterClient");
		}

		[HttpPost]
		public IActionResult SearchClient([FromBody] SearchTermDto searchTerm)
		{
			string name = searchTerm.SearchTerm;

			var clients = _searchClientService.SearchClient(name);

			return Ok(clients);
		}
	}
}
