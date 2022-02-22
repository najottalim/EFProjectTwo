using System.Linq.Expressions;
using System.Threading.Tasks;
using EFProjectTwo.Domain;
using System;


namespace EFProjectTwo.Service.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserAsync(Expression<Func<User, bool>> pred);
    }
}
