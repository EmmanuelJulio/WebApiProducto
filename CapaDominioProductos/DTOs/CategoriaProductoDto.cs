using CapaDominioProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDominioProductos.DTOs
{
    public class CategoriaProductoDto
    {
        private int productoID;
        private int categoriaID;

        public int ProductoID { get => productoID; set => productoID = value; }
        public int CategoriaID { get => categoriaID; set => categoriaID = value; }

        public virtual Producto ProductoNavigator { get; set; }
        public virtual Categoria CategoriaNavigator { get; set; }

    }
}
