using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escuela_Api.Models
{
    public class Profesor
    {

        public int idprofesor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public List<Materia> Materias { get; set; }

        internal class Map
        {
            private EntityTypeBuilder<Profesor> entityTypeBuilder;

            public Map(EntityTypeBuilder<Profesor> entityTypeBuilder)
            {
                this.entityTypeBuilder = entityTypeBuilder;
            }
        }
    }
}
