using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escuela_Api.Models
{
    public class Estudiante
    {
        public int idestudiante { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public List<Calificacion> Calificaciones { get; set; }

        internal class Map
        {
            private EntityTypeBuilder<Estudiante> entityTypeBuilder;

            public Map(EntityTypeBuilder<Estudiante> entityTypeBuilder)
            {
                this.entityTypeBuilder = entityTypeBuilder;
            }
        }
    }
}
