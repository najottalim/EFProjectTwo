using EFProjectTwo.Data.IRepositories;
using EFProjectTwo.Service.Interfaces;
using EFProjectTwo.Data.Repositories;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EFProjectTwo.Domain;
using System;


namespace EFProjectTwo.Service.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepo;

        public UserService()
        {
            _userRepo = new UserRepository();
        }

        public Task<User> GetUserAsync(Expression<Func<User, bool>> pred)
        {
            return _userRepo.GetAsync(pred);
        }
    }
}
