using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace aaaaaaaaaaaaaaaaaaa.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
