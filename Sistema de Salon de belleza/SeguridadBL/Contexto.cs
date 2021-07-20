using BL.Rentas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Rentas.CitasBL;
using static BL.Rentas.SeguridadBl;

namespace BL.Rentas
{
    public class Contexto: DbContext
    {
        public Contexto(): base("MiBaseDeDatos")
        {
           
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }
        public DbSet <Producto> Productos { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet <Citas> Citas { get; set; }
        public DbSet <Categoria> Categorias { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet <UsuariosDB> Usuarios { get; set; }   
    }
}
