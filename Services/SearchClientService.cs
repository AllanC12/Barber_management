using BarberManagement.Models;
using BarberManagement.Repository.Interfaces;
using BarberManagement.ViewModels;

namespace BarberManagement.Services
{
	public class SearchClientService : ISearchClientService
	{
		IUnityOfWork _uow;

		public SearchClientService(IUnityOfWork uow)
		{
			_uow = uow;
		}

		public IEnumerable<ClientViewModel> SearchClient(string searchTerm)
		{
			var terms = searchTerm.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			var firstName = terms.ElementAtOrDefault(0)?.Trim().ToLower() ?? string.Empty; ;
			var lastName = terms.ElementAtOrDefault(1)?.Trim().ToLower() ?? string.Empty;

			IEnumerable<ClientModel> result = _uow.ClientRepository.GetAll(client =>
			   client.Name.ToLower() == firstName ||
			   client.LastName.ToLower() == lastName
			);

			IEnumerable<ClientViewModel> clients = result.Select(cli => new ClientViewModel
			{
				Name = cli.Name,
				LastName = cli.LastName,
				Birthday = cli.Birthday,
				Favorite_Service = cli.Favorite_Service,
				Observation = cli.Observation
			});

			return clients;
		}
	}
}
