using System;
using formulario.Entities;
using Microsoft.EntityFrameworkCore;

namespace formulario.Context
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
             : base(options)
        {}

        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<TipoDocumento> TiposDocumentos { get; set; }
    }
}
