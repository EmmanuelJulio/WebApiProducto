using System;
using System.Collections.Generic;
using System.Text;

namespace API_CAPA_DOMINIO.Entity
{
    public class Producto 
    {
        int id;
        DateTime fecha;
        string codigo;
        string marca;
        string nombre;
        decimal precio;
        

        //public int Id { get => id; set => id = value; }
        //public DateTime Fechadeactualizaion1 { get => Fechadeactualizaion; set => Fechadeactualizaion = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}
