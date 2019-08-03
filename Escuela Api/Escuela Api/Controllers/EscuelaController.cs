using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escuela_Api.Models;
using Escuela_Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Escuela_Api.Controllers
{
    [Route("api/escuela")]
    [ApiController]
    public class EscuelaController : ControllerBase
    {
        private readonly EscuelaServices _EscuelaServicio; 
        public EscuelaController(EscuelaServices EscuelaServicio)
        {
            _EscuelaServicio = EscuelaServicio;

        }
        public IActionResult Prueba()
        {
            return Ok("Funciona");

        }

        [Route("VerEstudiante")]
        [HttpGet]
        public IActionResult VerListadodeEstudiantes()
         {

            var resultado = _EscuelaServicio.VerListadoTodosLosEstudiantes();
            return Ok(resultado);

        }
        [Route("VerProfesor")]
        [HttpGet]
        public IActionResult VerListadodeProfesores()
        {

            var resultado = _EscuelaServicio.VerListadoTodosLosProfesores();
            return Ok(resultado);


        }
        [Route("VerMateria")]
        [HttpGet]
        public IActionResult VerListadodeMaterias()
        {

            var resultado = _EscuelaServicio.VerListadoTodasLasMaterias();
            return Ok(resultado);

        }
        [Route("VerCalificacion")]
        [HttpGet]
        public IActionResult VerListadodeCalificaciones()
        {

            var resultado = _EscuelaServicio.VerListadoTodasLasCalificaciones();
            return Ok(resultado);

        }
        [Route("AgregarEstudiante")]
        [HttpPost]
        public IActionResult AgregarEstudiante([FromBody] Estudiante EstudianteAgregar)
        {
            if (_EscuelaServicio.Agregar(EstudianteAgregar))
            {
                return Ok("Se agrego el estudiante correctamente");
            }
           else 
            {
                return BadRequest();
            }
        }
        [Route("AgregarProfesor")]
        [HttpPost]
        public IActionResult AgregarProfesor([FromBody] Profesor ProfesorAgregar)
        {
            if (_EscuelaServicio.AgregarProfesor(ProfesorAgregar))
            {
                return Ok("Se agrego el profesor correctamente");
            }
            else
            {
                return BadRequest();
            }
        }
        [Route("AgregarMateria")]
        [HttpPost]
        public IActionResult AgregarMateria([FromBody] Materia MateriaAgregar)
        {
            if (_EscuelaServicio.AgregarMateria(MateriaAgregar))
            {
                return Ok("Se agrego la materia correctamente");
            }
            else
            {
                return BadRequest();
            }
        }
        [Route("AgregarCalificacion")]
        [HttpPost]
        public IActionResult AgregarCalificacion([FromBody] Calificacion CalificacionAgregar)
        {
            if (_EscuelaServicio.AgregarCalificacion(CalificacionAgregar))
            {
                return Ok("Se agrego la calificacion correctamente");
            }
            else
            {
                return BadRequest();
            }
        }

    }
}