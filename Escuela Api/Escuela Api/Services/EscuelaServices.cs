using Escuela_Api.Models;
using Escuela_Api.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Escuela_Api.Services
{
   
    public class EscuelaServices
    {
        public readonly EscuelaDbContext _EscuelaDB;
        public EscuelaServices(EscuelaDbContext EscuelaDB)
        {
            _EscuelaDB = EscuelaDB; 

        }
        public List<Estudiante> VerListadoTodosLosEstudiantes()
        {
            var EstudianteBuscado = _EscuelaDB.Estudiante.ToList();
            return EstudianteBuscado;
        }
        public List<Profesor> VerListadoTodosLosProfesores()    
        {
            var ProfesorBuscado = _EscuelaDB.Profesor.ToList();
            return ProfesorBuscado;
        }
        public List<Materia> VerListadoTodasLasMaterias()
        {
            var MateriaBuscada = _EscuelaDB.Materia.Include(x => x.profesor).OrderByDescending(x => x.idprofesor).ToList();
            return MateriaBuscada;
        }
        public List<Calificacion> VerListadoTodasLasCalificaciones()
        {
            var CalificacionBuscada = _EscuelaDB.Calificacion.Include(x => x.Estudiante).Include(x => x.Materia).ToList();
            return CalificacionBuscada;
        }

        public bool Agregar(Estudiante EstudianteAgregar)
        {
            try
            {
                _EscuelaDB.Estudiante.Add(EstudianteAgregar);
                _EscuelaDB.SaveChanges();
                return true;
                
            }
           catch(Exception error)
            {
                return false;
            }
           
        }
        public bool AgregarProfesor(Profesor ProfesorAgregar)
        {
            try
            {
                _EscuelaDB.Profesor.Add(ProfesorAgregar);
                _EscuelaDB.SaveChanges();
                return true;

            }
            catch (Exception error)
            {
                return false;
            }

        }
        public bool AgregarMateria(Materia MateriaAgregar)
        {
            try
            {
                _EscuelaDB.Materia.Add(MateriaAgregar);
                _EscuelaDB.SaveChanges();
                return true;

            }
            catch (Exception error)
            {
                return false;
            }

        }
        public bool AgregarCalificacion(Calificacion CalificacionAgregar)
        {
            try
            {
                _EscuelaDB.Calificacion.Add(CalificacionAgregar);
                _EscuelaDB.SaveChanges();
                return true;

            }
            catch (Exception error)
            {
                return false;
            }

        }

    }
}
