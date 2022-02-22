using EFProjectTwo.Data.IRepositories;
using EFProjectTwo.Domain;

namespace EFProjectTwo.Data.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
    }
}
