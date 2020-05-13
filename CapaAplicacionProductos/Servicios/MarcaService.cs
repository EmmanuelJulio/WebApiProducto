using CapaDominioProductos.Comandos;
using CapaDominioProductos.DTOs;
using CapaDominioProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacionProductos.Servicios
{
    public interface IMarcaService
    {
        MarcaDto createMarca(string nombre);
    }
    public class MarcaService :IMarcaService
    {
        private readonly IGenericsRepository repository;

        public MarcaService(IGenericsRepository repository)
        {
            this.repository = repository;
        }

        public MarcaDto createMarca(string nombre)
        {
            var entity = new Marca()
            {
                Nombre = nombre
            };
            repository.Agregar<Marca>(entity);
            return new MarcaDto { Nombre = entity.Nombre };
        }
    }
}
