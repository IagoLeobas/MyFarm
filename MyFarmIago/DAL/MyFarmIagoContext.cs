using MyFarmIago.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MyFarmIago.DAL
{
    public class MyFarmIagoContext : DbContext
    {
        public MyFarmIagoContext() : base("MyFarmIagoContext")
        {
        }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Ave> Aves { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Bovino> Bovinos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vacina> Vacinas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}