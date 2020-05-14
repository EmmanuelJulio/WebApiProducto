using CapaDominioProductos.Comandos;
using CapaDominioProductos.DTOs;
using CapaDominioProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacionProductos.Servicios
{
    public interface IPrecioProductoService
    {
        PrecioProducto createPrecioProducto(PrecioProductoDto precio);
    }
    public class PrecioProductoService : IPrecioProductoService
    {
        private readonly IGenericsRepository repository;

        public PrecioProductoService(IGenericsRepository repository)
        {
            this.repository = repository;
        }

        public PrecioProducto createPrecioProducto(PrecioProductoDto precio)
        {
            var entity = new PrecioProducto()
            {
                Precioreal = precio.Precioreal,
                Precioventa = precio.Precioventa,
                Fecha = DateTime.Now
                
            };
            repository.Agregar<PrecioProducto>(entity);
            return entity;
        }
    }
}
