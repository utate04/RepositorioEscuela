using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escuela_Api.Models
{
    public class Estudiante
    {
        public int idestudiante { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        //public List<Calificacion> Calificaciones { get; set; }

        public class Map
        {

            public Map(EntityTypeBuilder<Estudiante> ebEstudiante)
            {
                ebEstudiante.HasKey(x => x.idestudiante);
                ebEstudiante.Property(x => x.nombre).HasColumnName("nombre").HasMaxLength(20);
                ebEstudiante.Property(x => x.apellido).HasColumnName("apellido").HasMaxLength(20);

            }
        }
    }
}
