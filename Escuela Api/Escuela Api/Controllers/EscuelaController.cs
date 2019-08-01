using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Escuela_Api.Controllers
{
    [Route("api/escuela")]
    [ApiController]
    public class EscuelaController : ControllerBase
    {

        public IActionResult Prueba()
        {
            return Ok("Funciona");

        }
    }
}