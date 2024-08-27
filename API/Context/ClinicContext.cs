using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Context
{
    public class ClinicContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;database=clinic;user=root;password=root;", 
                ServerVersion.AutoDetect("server=localhost;port=3306;database=clinic;user=root;password=root;"));
        }

        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

    }
}