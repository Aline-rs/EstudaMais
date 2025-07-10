using Microsoft.EntityFrameworkCore;

namespace EstudaMais.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<Models.MateriaModel> Materias { get; set; }
    }
}
