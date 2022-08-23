using Microsoft.EntityFrameworkCore;

using Laboratorio_web_15_8_2022.Modelos;

namespace Laboratorio_web_15_8_2022.Datos
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {

        }
        public DbSet<Categoria> Categoria{get; set;}
    }
}
