﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDominioProductos.DTOs
{
    public class ProductoDto
    {
        public int ProductoID { get; set; }
        private string nombre;
        private string descripcion;
        private int precioID;
        private int imagenID;
        private int categoriaID;
        private int marcaID;
        private int stock;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int PrecioID { get => precioID; set => precioID = value; }
        public int ImagenID { get => imagenID; set => imagenID = value; }
        public int CategoriaID { get => categoriaID; set => categoriaID = value; }
        
        public int Stock { get => stock; set => stock = value; }
        public int MarcaID { get => marcaID; set => marcaID = value; }
    }
}
