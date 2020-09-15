using ExamenAlvaco.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace ExamenAlvaco.DAL
{
    public class EmpresaContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Telefono> Telefonos{ get; set; }

    }
}