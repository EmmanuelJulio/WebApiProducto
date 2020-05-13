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
        CategoriaProductoDto createCategoriaProducto(int ProductoID,int CategoriaID);
    }
    public class CategoriaProductoService : ICategoriaProductoService
    {
        private readonly IGenericsRepository repository;

        public CategoriaProductoService(IGenericsRepository repository)
        {
            this.repository = repository;
        }

        public CategoriaProductoDto createCategoriaProducto(int ProductoID, int CategoriaID)
        {
            var ProductoNavigator = repository.GetBy<Producto>(ProductoID);
            var CategoriaNavigator = repository.GetBy<Categoria>(CategoriaID);
            var entity = new CategoriaProducto()
            {
                ProductoID = ProductoID,
                CategoriaID = CategoriaID,
                ProductoNavigator = ProductoNavigator,
                CategoriaNavigator = CategoriaNavigator
                
            };
            return new CategoriaProductoDto {ProductoID = entity.ProductoID,CategoriaID=entity.CategoriaID};
        }
    }
}
