using Escuela_Api.Controllers;
using Escuela_Api.Models;
using Escuela_Api.Persistence;
using Escuela_Api.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;

namespace EscuelaApiTest
{
    public class UnitTest1
    {
        EscuelaDbContext dbContext = new EscuelaDbContext(new DbContextOptions<EscuelaDbContext>());
       
        public readonly EscuelaDbContext _EscuelaDB;
        public UnitTest1(EscuelaDbContext EscuelaDB)
        {
            _EscuelaDB = EscuelaDB;

        }
        private readonly EscuelaServices _EscuelaServicio;
        public UnitTest1(EscuelaServices EscuelaServicio)
        {
            _EscuelaServicio = EscuelaServicio;

        }

      
        public void Add(string nombre, string apellido)
        {
            var controller = new Estudiante { nombre = nombre, apellido = apellido };
            _EscuelaServicio.Agregar(controller);
            _EscuelaDB.SaveChanges();
        }

    }
}
