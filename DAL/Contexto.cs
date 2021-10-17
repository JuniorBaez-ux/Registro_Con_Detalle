using Microsoft.EntityFrameworkCore;
using Registro_Con_Detalle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Con_Detalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Permisos> Permiso { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"data source = data\rolescontrol.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permisos>().HasData(
                new Permisos { PermisoId = 1, Nombre = "Usuario", Descripcion = "Para usuarios" },
                new Permisos { PermisoId = 2, Nombre = "Administrador", Descripcion = "Para administradores" });

        }
    }
}
