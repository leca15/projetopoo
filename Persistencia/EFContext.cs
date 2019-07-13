using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia
{
    public class EFContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<AtdAvulso> AtdAvulso { get; set; }
        public DbSet<Caixa>  Caixa { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<RegistrarAtdCons> RegAtdCons { get; set; }
        public DbSet<Exame> Exames { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_ClinicaVet;Trusted_Connection=True");
        }
    }
}
