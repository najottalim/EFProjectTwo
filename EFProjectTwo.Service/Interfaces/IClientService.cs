using System.Linq.Expressions;
using System.Threading.Tasks;
using EFProjectTwo.Domain;
using System;


namespace EFProjectTwo.Service.Interfaces
{
    internal interface IClientService
    {
        Task<Client> GetClientAsync(Expression<Func<Client, bool>> pred);
    }
}
