using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto_Integrador_JS_DM_PZ.Models.Dominio;

    public class Proyecto_Integrador_JS_DM_PZContext : DbContext
    {
        public Proyecto_Integrador_JS_DM_PZContext (DbContextOptions<Proyecto_Integrador_JS_DM_PZContext> options)
            : base(options)
        {
        }

        public DbSet<Proyecto_Integrador_JS_DM_PZ.Models.Dominio.BlogPost> BlogPost { get; set; } = default!; //conectar con la base de datos

        public DbSet<Proyecto_Integrador_JS_DM_PZ.Models.Dominio.Tag> Tag { get; set; } = default!;
    }
