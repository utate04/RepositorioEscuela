using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela_Api.Models
{
    public class Materia
    {
        public int idmateria { get; set; }
        public string nombre { get; set; }
        public Profesor profesor { get; set; }
        public List<Calificacion> Calificaciones { get; set; }

        public class Map {
            public Map(EntityTypeBuilder<Materia> ebMateria)
            {
                ebMateria.HasKey(x => x.idmateria);
                ebMateria.Property(x => x.nombre).HasColumnName("nombre").HasMaxLength(20);
                ebMateria.HasOne(x => x.profesor).WithMany(x => x.Materias).HasForeignKey(x => x.profesor);


            }
        }
    }
}
