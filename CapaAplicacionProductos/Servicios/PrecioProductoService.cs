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
        PrecioProductoDto createPrecioProducto(int precioReal, int PrecioVenta);
    }
    public class PrecioProductoService : IPrecioProductoService
    {
        private readonly IGenericsRepository repository;

        public PrecioProductoService(IGenericsRepository repository)
        {
            this.repository = repository;
        }

        public PrecioProductoDto createPrecioProducto(int precioReal, int PrecioVenta)
        {
            var entity = new PrecioProducto()
            {
                Precioreal = precioReal,
                Precioventa = PrecioVenta,
                Fecha = DateTime.Now
                
            };
            repository.Agregar<PrecioProducto>(entity);
            return new PrecioProductoDto { 
            Precioreal = entity.Precioreal,
            Precioventa = entity.Precioventa,
            Fecha = entity.Fecha
            };
        }
    }
}
