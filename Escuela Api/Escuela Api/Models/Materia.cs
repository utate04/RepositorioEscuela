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
    }
}
