using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escuela_Api.Models
{
    public class Materia
    {
        public int idmateria { get; set; }
        public string nombre { get; set; }
        public int idprofesor { get; set; }
        public Profesor profesor { get; set; }
        //public List<Calificacion> Calificaciones { get; set; }

        public class Map {

            public Map(EntityTypeBuilder<Materia> ebMateria)
            {
                ebMateria.HasKey(x => x.idmateria);
                ebMateria.Property(x => x.nombre).HasColumnName("nombre").HasMaxLength(20);
                ebMateria.Property(x => x.idprofesor).HasColumnName("idprofesor").HasColumnType("int");
                ebMateria.HasOne(x => x.profesor);

            }
        }
    }
}
