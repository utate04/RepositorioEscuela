using Escuela_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Escuela_Api.Services
{
    public class EscuelaServices
    {
        public readonly Controllers___Copy.EscuelaDbContext _EscuelaDb;
        public EscuelaServices(Controllers___Copy.EscuelaDbContext EscuelaDb)
        {
            _EscuelaDb = EscuelaDb;

        }

        public List<Estudiante> VerListadodeEstudiantes()
        {
            var EstudianteBuscado = _EscuelaDb.Estudiante.ToList();
            return EstudianteBuscado;
           

        }
    }
}
