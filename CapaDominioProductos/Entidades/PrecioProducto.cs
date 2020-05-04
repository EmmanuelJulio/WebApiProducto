using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDominioProductos.Entidades
{
    public class PrecioProducto
    {
        private int precioproductoID;
        private decimal precioreal;
        private decimal precioventa;
        private DateTime fecha;

        
        public decimal Precioreal { get => precioreal; set => precioreal = value; }
        public decimal Precioventa { get => precioventa; set => precioventa = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int PrecioproductoID { get => precioproductoID; set => precioproductoID = value; }
    }
}
