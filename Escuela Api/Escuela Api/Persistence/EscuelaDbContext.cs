using Escuela_Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela_Api.Persistence
{
    public class EscuelaDbContext: DbContext
    {
        public EscuelaDbContext(DbContextOptions opciones): base(opciones)
        {

        }

        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<Calificacion> Calificacion { get; set; }

        protected override void OnModelCreating(ModelBuilder modelB)
        {
            new Estudiante.Map(modelB.Entity<Estudiante>());
            new Profesor.Map(modelB.Entity<Profesor>());
            new Materia.Map(modelB.Entity<Materia>());
            new Calificacion.Map(modelB.Entity<Calificacion>());
            base.OnModelCreating(modelB);
        }
        
    }
}
