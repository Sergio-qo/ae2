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

        }
    }
}