using CapaDominioProductos.Comandos;
using CapaDominioProductos.DTOs;
using CapaDominioProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacionProductos.Servicios
{
    public interface IProductoService
    {
        Producto createProducto(ProductoDto producto);
    }
    public class ProductoServicio: IProductoService
    {


        private readonly IGenericsRepository repository;


        public ProductoServicio(IGenericsRepository repository)
        {
            this.repository = repository;
        }

        public Producto createProducto(ProductoDto producto)
        {
            var entity = new Producto()
            {

                //Descripcion = producto.Descripcion,
                //Marca = producto.Marca,
                //Precio = producto.Precio,
                //Nombre = producto.Nombre

            };
            repository.Agregar<Producto>(entity);
            return entity;



        }








    }
}
