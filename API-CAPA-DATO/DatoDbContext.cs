using API_CAPA_DOMINIO.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;



namespace API_CAPA_DATO 
{
   public class DatoDbContext :DbContext
    {
        DbSet<Producto> productos;

        public DbSet<Producto> Productos { get => productos; set => productos = value; }

        public DatoDbContext(DbContextOptions<DatoDbContext> options) : base(options) 
           {

           }
        
    }
}
