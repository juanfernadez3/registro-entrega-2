using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Registro.Entidades;

namespace Registro.DAL
{
    public class contexto: DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server = DESKTOP-62VN6P5; database = personaDB; trusted_connection = true; ");
        }
    }
}
