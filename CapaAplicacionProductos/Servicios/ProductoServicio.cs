using CapaDominioProductos.Comandos;
using CapaDominioProductos.DTOs;
using CapaDominioProductos.Entidades;
using CapaDominioProductos.Querys;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CapaAplicacionProductos.Servicios
{
    public interface IProductoService
    {
        ProductoDto createProducto(int imagen, int precioproducto, int categoria, int marca, string nombre, string descripcion, int stock);
        List<ProductoDto> BusquedaProducto(int precio);
        Producto EliminarProducto(ProductoDto producto);
        List<ProductoDto> GetAllProducto();

    }
    public class ProductoServicio: IProductoService
    {


        private readonly IGenericsRepository repository;
        private readonly IProductoQuery _Query;

        public ProductoServicio(IGenericsRepository repository,IProductoQuery query)
        {
            this.repository = repository;
            _Query = query;
        }


        public List<ProductoDto> BusquedaProducto(int precio)
        {
            return _Query.BusquedaProducto(precio);
        }

        public ProductoDto createProducto(int imagen, int precioproducto, int categoria, int marca,string nombre,string descripcion,int stock)
        {
            var ImagenNav = repository.GetBy<ImagenProducto>(imagen);
            var PrecioProducNav = repository.GetBy<PrecioProducto>(precioproducto);
            var CategoriaNav = repository.GetBy<CategoriaProducto>(categoria);
            var MarcaNav = repository.GetBy<Marca>(marca);
            var entity = new Producto()
            {
                Nombre = nombre ,
                Descripcion = descripcion,
                PrecioID = precioproducto,
                ImagenID = imagen,
                CategoriaID = categoria,
                Stock = stock,
                MarcaID = marca ,
                ImagenProductoNavigator = ImagenNav,
                PrecioProductoNavigator = PrecioProducNav,
                CategoriaProductoNavigator = CategoriaNav,
                MarcaNavigator = MarcaNav
             

            };
            repository.Agregar<Producto>(entity);
            return new ProductoDto {Nombre = entity.Nombre ,Descripcion = entity.Descripcion,PrecioID= entity.PrecioID,ImagenID = entity.ImagenID , CategoriaID = entity.CategoriaID
            ,MarcaID = entity.MarcaID
            ,Stock = entity.Stock

            };



        }

        public Producto EliminarProducto(ProductoDto producto)
        {
            var entity = new Producto()
            {
                ProductoID  = producto.ProductoID,
                CategoriaID = producto.CategoriaID,
                Nombre = producto.Nombre ,
                Descripcion = producto.Descripcion,
                PrecioID = producto.PrecioID,
                ImagenID = producto.ImagenID,
                MarcaID =  producto.MarcaID,
                Stock = producto.Stock
                
            };
            repository.Delete<Producto>(entity);
            return entity;
        }

        public List<ProductoDto> GetAllProducto()
        {
            return _Query.GetAllProducto();
        }
    }
}
