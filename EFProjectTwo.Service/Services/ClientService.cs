using EFProjectTwo.Service.Interfaces;
using EFProjectTwo.Data.IRepositories;
using EFProjectTwo.Data.Repositories;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EFProjectTwo.Domain;
using System;


namespace EFProjectTwo.Service.Services
{
    public class ClientService : IClientService
    {
        private IClientRepository _clientRepo;

        public ClientService()
        {
            _clientRepo = new ClientRepository();
        }

        public Task<Client> GetClientAsync(Expression<Func<Client, bool>> pred)
        {
            return _clientRepo.GetAsync(pred);
        }
    }
}
