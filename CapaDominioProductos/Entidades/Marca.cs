using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDominioProductos.Entidades
{
   public  class Marca
    {
        private int marcaID;
        private string nombre;

        public int MarcaID { get => marcaID; set => marcaID = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
