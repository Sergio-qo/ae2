using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace PlaceMyBet.Models
{
    public class PlaceMyBetContext : DbContext
    {
        public DbSet<Mercado> Mercados { get; set; }
        public DbSet<Evento> Eventos{ get; set; }
        public DbSet<Apuesta> Apuestas{ get; set; }
        public DbSet<Cuenta> Cuentas{ get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }

        public PlaceMyBetContext()
        {

        }

        public PlaceMyBetContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=placemybet;Uid=root;Pwd='';SslMode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(new Usuario("fff@gmail.com", 19, "s", "qo"));
            modelBuilder.Entity<Cuenta>().HasData(new Cuenta(1, "fff@gmail.com", "BANKIA", "555"));
            modelBuilder.Entity<Evento>().HasData(new Evento(1, "Valencia", "Barcelona"));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(1, 1, 1, 2, 2, "UNDER 2.5",1));
            
        }
    }
}