using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escuela_Api.Models
{
    public class Materia
    {
        public int idmateria { get; set; }
        public string nombre { get; set; }
        public Profesor profesor { get; set; }
        public List<Calificacion> Calificaciones { get; set; }

        internal class Map
        {
            private EntityTypeBuilder<Materia> entityTypeBuilder;

            public Map(EntityTypeBuilder<Materia> entityTypeBuilder)
            {
                this.entityTypeBuilder = entityTypeBuilder;
            }
        }
    }
}
