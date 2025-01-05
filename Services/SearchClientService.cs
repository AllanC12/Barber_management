using BarberManagement.DTOs;
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

            IEnumerable<ClientModel> result = _uow.ClientRepo.GetAll(client => client.Name == searchTerm);

            IEnumerable<ClientViewModel> clients = result.Select(cli => new ClientViewModel
            {
                Name = cli.Name,
                Birthday = cli.Birthday,
                Favorite_Service = cli.Favorite_Service,
                Observation = cli.Observation
            });

            return clients;
        }
    }
}
