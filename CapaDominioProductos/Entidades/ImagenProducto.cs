using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDominioProductos.Entidades
{
    public class ImagenProducto
    {
        private int imagenproductoID;
        private int nombre;

        public int ImagenproductoID { get => imagenproductoID; set => imagenproductoID = value; }
        public int Nombre { get => nombre; set => nombre = value; }
    }
}
