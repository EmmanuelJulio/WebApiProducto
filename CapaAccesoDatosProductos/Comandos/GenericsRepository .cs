using CapaDominioProductos.Comandos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAccesoDatosProductos.Comandos
{
    public class GenericsRepository : IGenericsRepository
    {
        private readonly Contexto contexto;
        public GenericsRepository(Contexto contexto)
        {
            this.contexto = contexto;
        }

        public void Agregar<T>(T entity) where T : class
        {
            contexto.Add(entity);
            contexto.SaveChanges();
        }
    }
}
