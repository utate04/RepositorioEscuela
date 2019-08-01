using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela_Api.Models
{
    public class Calificacion
    {

        public int idcalificacion { get; set; }
        public int puntaje { get; set; }
        public Estudiante estudiante { get; set; }
        public Materia materia { get; set; }

        public class Map
        {
            public Map(EntityTypeBuilder<Calificacion> ebCalificacion)
            {
                ebCalificacion.HasKey(x => x.idcalificacion);
                ebCalificacion.Property(x => x.puntaje).HasColumnName("puntake").HasColumnType("int");
                ebCalificacion.HasOne(x => x.estudiante).WithMany(x => x.Calificaciones).HasForeignKey(x => x.estudiante);
                ebCalificacion.HasOne(x => x.materia).WithMany(x => x.Calificaciones).HasForeignKey(x => x.materia);


            }
        }
    }
}
