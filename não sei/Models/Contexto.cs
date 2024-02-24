

using Microsoft.EntityFrameworkCore;

namespace não_sei.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
