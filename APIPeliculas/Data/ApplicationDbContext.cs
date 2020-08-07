using APIPeliculas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPeliculas.Data
{
    /**Clase donde se insertan los modelos a EF*/
    /**Instalar EF Core, EF Core SQL, EF Core Tools*/
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        /**Para inicial migracion de modelos a BD (codefirst) se usa el comando "add-migration + (nombre de la migracion)" */
        /**Para aplicar la migracion a SQL se usa el comando "update-database"*/
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Pelicula> Pelicula { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
