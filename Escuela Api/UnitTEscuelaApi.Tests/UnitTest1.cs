using Escuela_Api.Controllers;
using Escuela_Api.Models;
using Escuela_Api.Persistence;
using Escuela_Api.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;

namespace UnitTEscuelaApi.Tests
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            
        }
       
        private EscuelaDbContext _EscuelaDbContext;
        private EscuelaDbContext _EscuelaServicio;

        [Fact]
        public void Test1()
        {
            var builder = new DbContextOptionsBuilder<EscuelaDbContext>()
                .UseInMemoryDatabase();
            var context = new EscuelaDbContext(builder.Options);
            var estudiantes = Enumerable.Range(1, 10)
                .Select(i => new Estudiante { idestudiante = i, nombre = "Ashly", apellido = "Utate" });
            context.Estudiante.AddRange(estudiantes);
            int changed = context.SaveChanges();
            _EscuelaDbContext = context;

        }
        [Fact]
        public void TestGetEstudianteById()
        {
            string expectedname = "Ashly";
            var controller = new EscuelaServices(_EscuelaServicio);
            Estudiante result = controller.VerListadodeEstudiantes(1);

        }
    }
}
