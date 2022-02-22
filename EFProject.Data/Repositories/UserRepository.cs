using EFProjectTwo.Data.IRepositories;
using EFProjectTwo.Domain;


namespace EFProjectTwo.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
    }
}
