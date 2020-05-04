using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDominioProductos.DTOs
{
    public class CategoriaDto
    {
        private string nombre;
        private string descripcion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
