using BarberManagement.DTOs;
using BarberManagement.Models;
using BarberManagement.ViewModels;

namespace BarberManagement.Repository.Interfaces
{
    public interface ISearchClientService
    {
        public IEnumerable<ClientViewModel> SearchClient(string searchTerm);
    }
}
