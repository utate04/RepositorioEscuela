using Escuela_Api.Models;
using Escuela_Api.Persistence;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void DebeSerCapazdeAgregarenMemoria()
        {
            var builder = new DbContextOptionsBuilder<EscuelaDbContext>()
                .EnableSensitiveDataLogging()
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
            using (var context = new EscuelaDbContext(builder.Options))
            {
                context.Estudiante.Add(new Estudiante("Luis", "Cabral"));
                context.SaveChanges();

                Assert.Equal(1, context.Estudiante.Count(x => x.Nombre == "Ashly"));
            }
        }

    }
}