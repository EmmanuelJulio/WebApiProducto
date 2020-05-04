using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDominioProductos.Entidades
{
    public class Categoria
    {

        private int categoriaID;
        private string nombre;
        private string descripcion;

        public int CategoriaID { get => categoriaID; set => categoriaID = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
