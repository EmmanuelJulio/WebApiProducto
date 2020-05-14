using CapaDominioProductos.Comandos;
using CapaDominioProductos.DTOs;
using CapaDominioProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacionProductos.Servicios
{
    public interface ICategoriaProductoService
    {
        CategoriaProductoDto createCategoriaProducto(int Producto,int Categoria);
    }
    public class CategoriaProductoService : ICategoriaProductoService
    {
        private readonly IGenericsRepository repository;

        public CategoriaProductoService(IGenericsRepository repository)
        {
            this.repository = repository;
        }

        public CategoriaProductoDto createCategoriaProducto(int Producto, int Categoria)
        {
            var ProductoNavigator = repository.GetBy<Producto>(Producto);
            var CategoriaNavigator = repository.GetBy<Categoria>(Categoria);
            var entity = new CategoriaProducto()
            {
                ProductoID = Producto,
                CategoriaID = Categoria,
                ProductoNavigator = ProductoNavigator,
                CategoriaNavigator = CategoriaNavigator
                
            };
            return new CategoriaProductoDto {ProductoID = entity.ProductoID,CategoriaID=entity.CategoriaID};
        }
    }
}
