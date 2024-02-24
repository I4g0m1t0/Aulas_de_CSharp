﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Receba.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
