using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult VerListadodeEstudiantes()
         {

            var resultado = _EscuelaServicio.VerListadoTodosLosEstudiantes();
            return Ok(resultado);

        }
        [Route("VerProfesor")]
        public IActionResult VerListadodeProfesores()
        {

            var resultado = _EscuelaServicio.VerListadoTodosLosProfesores();
            return Ok(resultado);


        }
        [Route("VerMateria")]
        public IActionResult VerListadodeMaterias()
        {

            var resultado = _EscuelaServicio.VerListadoTodasLasMaterias();
            return Ok(resultado);

        }
        [Route("VerCalificacion")]
        public IActionResult VerListadodeCalificaciones()
        {

            var resultado = _EscuelaServicio.VerListadoTodasLasCalificaciones();
            return Ok(resultado);

        }
    }
}