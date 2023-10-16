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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cargo>().HasData(new Cargo()
            {
                Name = "Engenharia", 
                Id = 1,
                Descricao = "Engenheiro de Inovação"
            },
            new Cargo()
            {
                Name = "Coordenador",
                Id = 2,
                Descricao = "Coordenador Equipes"
            });

            modelBuilder.Entity<Equipe>().HasData(new Equipe()
            {
                Name = "Atenas",
                Id = 1,
                Descricao = "Setor Inovação"
            },
            new Equipe()
            {
                Name = "Coordenador",
                Id = 2,
                Descricao = "Coordenador Equipes"
            }); 

            modelBuilder.Entity<User>().HasData(new User()
            {
                Name = "Luan Bregunce",
                Id = 1,
                CargoId = 1,
                DateAdmissao = DateTime.Now,
                EquipeId = 1,
                SetorId = 1,
                Empresa = "RM Mais Projetos"
            },
            new User()
            {
                Name = "Carlos Eduardo",
                Id = 2,
                CargoId = 1,
                DateAdmissao = DateTime.Now,
                EquipeId = 1,
                SetorId = 1,
                Empresa = "RM Mais Projetos"
            });
        }
    }
}
