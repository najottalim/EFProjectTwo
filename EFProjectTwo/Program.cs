using EFProjectTwo.Service.Services;
using System.Threading.Tasks;
using System;


namespace EFProjectTwo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var clientService = new ClientService();

            var client = await clientService.GetClientAsync(p => p.Id == 2);
     
            Console.WriteLine(client.Name);

        }
    }
}
