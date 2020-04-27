using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sintagri.Modelo.Entidades;
using Sintagri.Modelo.Entidades.Cultivos;
using Sintagri.Modelo.Entidades.Empresas;
using Sintagri.Modelo.Entidades.Enfermedades;
using Sintagri.Modelo.Entidades.Inventario;
using Sintagri.Modelo.Entidades.Misc;
using Sintagri.Modelo.Entidades.Trabajadores;

namespace Sintagri.Modelo.DataBase.MSSQLServer.Models
{
    public class SQLServerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\MSSQLSERVER01;Database=SINTAGRI;Trusted_Connection=True;")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(MyLoggerFactory);
        }

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder
                .AddFilter((category, level) =>
                    category == DbLoggerCategory.Database.Command.Name
                    && level == LogLevel.Information)
                .AddConsole();
        });

        public DbSet<Agricola> Agricolas { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }

        public DbSet<Fertilizante> Fertilizantes { get; set; }
        public DbSet<Fitosanitario> Fitosanitarios { get; set; }
        public DbSet<Aguas> Aguas { get; set; }

        public DbSet<PFQ_Fertilizante> Propiedades_Fertilizantes { get; set; }
        public DbSet<PFQ_Fitosanitario> Propiedades_Fitosanitarios { get; set; }
        public DbSet<PFQ_Agua> Propiedades_Agua { get; set; }

        public DbSet<Ingrediente_Activo> Ingredientes_Activos { get; set; }
        public DbSet<Formulacion> Formulaciones { get; set; }

        public DbSet<Cultivo> Cultivos { get; set; }
        public DbSet<Enfermedad> Enfermedades { get; set; }
        public DbSet<Plaga> Plagas { get; set; }

        public DbSet<Agronomo> Agronomos { get; set; }
        public DbSet<Roles> Roles { get; set; }

        //public DbSet<>

        public DbSet<Potreros> Potreros { get; set; }
        public DbSet<Predio> Predios { get; set; }
        public DbSet<Sectores> Sectores { get; set; }
        public DbSet<Valvulas> Valvulas { get; set; }

    }
}
