using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela_Api.Models
{
    public class Profesor
    {

        public int idprofesor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public List<Materia> Materias { get; set; }

        public class Map
        {
            public Map(EntityTypeBuilder<Profesor> ebProfesor)
            {
                ebProfesor.HasKey(x => x.idprofesor);
                ebProfesor.Property(x => x.nombre).HasColumnName("nombre").HasMaxLength(20);
                ebProfesor.Property(x => x.apellido).HasColumnName("apellido").HasMaxLength(20);


            }
        }
    }
}
