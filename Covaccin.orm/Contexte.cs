using System;
using Microsoft.EntityFrameworkCore;

namespace Covaccin.orm
{
    public class Contexte : DbContext
    {
        public DbSet<Personne> Personnes { get; set; }

        public DbSet<Injection> Injections { get; set; }

        public DbSet<TypeVaccin> TypeVaccins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlite("Data Source = covaccin.db");
        }
    }
}
