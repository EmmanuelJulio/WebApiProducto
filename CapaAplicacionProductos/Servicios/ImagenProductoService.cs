using CapaDominioProductos.Comandos;
using CapaDominioProductos.DTOs;
using CapaDominioProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacionProductos.Servicios
{
    public interface IimagenProductoService
    {
        ImagenProductoDto createImagenProducto(int nombre);
    }
    public class ImagenProductoService : IimagenProductoService
    {
        private readonly IGenericsRepository repository;

        public ImagenProductoService(IGenericsRepository repository)
        {
            this.repository = repository;
        }

        public ImagenProductoDto createImagenProducto(int nombre)
        {
            var entity = new ImagenProducto()
            {
                Nombre = nombre 
            };
            repository.Agregar<ImagenProducto>(entity);
            return new ImagenProductoDto
            {
                Nombre  = entity.Nombre
            };
          

        }
    }
}
