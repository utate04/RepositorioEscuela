using Escuela_Api.Models;
using Escuela_Api.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Escuela_Api.Services
{
    public class EscuelaServices
    {
        public readonly EscuelaDbContext _EscuelaDb;
        public EscuelaServices(EscuelaDbContext EscuelaDb)
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
