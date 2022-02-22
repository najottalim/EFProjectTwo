using Microsoft.EntityFrameworkCore;
using EFProjectTwo.Domain.Services;
using EFProjectTwo.Domain;

namespace EFProjectTwo.Data.Contexts
{
    public class NajotTalimDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Constants.NT_CONNECTION_STRING);
        }
    }
}
