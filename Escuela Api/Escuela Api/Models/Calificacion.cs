using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escuela_Api.Models
{
    public class Calificacion
    {

        public int idcalificacion { get; set; }
        public int puntaje { get; set; }
        public Estudiante estudiante { get; set; }
        public Materia materia { get; set; }

        internal class Map
        {
            private EntityTypeBuilder<Calificacion> entityTypeBuilder;

            public Map(EntityTypeBuilder<Calificacion> entityTypeBuilder)
            {
                this.entityTypeBuilder = entityTypeBuilder;
            }
        }
    }
}
