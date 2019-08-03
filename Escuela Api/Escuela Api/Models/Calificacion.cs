using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escuela_Api.Models
{
    public class Calificacion
    {

        public int idcalificacion { get; set; }
        public int puntaje { get; set; }
        public int idestudiante { get; set; }
        public int idmateria { get; set; }
        public Estudiante Estudiante { get; set; }
        public Materia Materia { get; set; }

        public class Map
        {

            public Map(EntityTypeBuilder<Calificacion> ebCalificacion)
            { 
                ebCalificacion.HasKey(x => x.idcalificacion);
                ebCalificacion.Property(x => x.puntaje).HasColumnName("puntaje").HasColumnType("int");
                ebCalificacion.Property(x => x.idestudiante).HasColumnName("idestudiante").HasColumnType("int");
                ebCalificacion.HasOne(x => x.Estudiante);
                ebCalificacion.Property(x => x.idmateria).HasColumnName("idmateria").HasColumnType("int");
                ebCalificacion.HasOne(x => x.Materia);

            }
        }
    }
}
