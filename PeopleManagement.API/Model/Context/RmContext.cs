using Microsoft.EntityFrameworkCore;

namespace PeopleManagement.API.Model.Context
{
    public class RmContext : DbContext
    {
        public RmContext() { }

        public RmContext(DbContextOptions<RmContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Equipe> Equipes { get; set; }

        public DbSet<Cargo> Cargos { get; set; }

    }
}
