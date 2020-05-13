using CapaDominioProductos.Comandos;
using CapaDominioProductos.DTOs;
using CapaDominioProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CapaAplicacionProductos.Servicios
{
    public interface ICategoriaService
    {
        CategoriaDto createCategoria(string nombre, string descripcion);
    }
    public class CategoriaService :ICategoriaService
    {
        private readonly IGenericsRepository repository;

        public CategoriaService(IGenericsRepository repository)
        {
            this.repository = repository;
        }

        public CategoriaDto createCategoria(string nombre, string descripcion)
        {
            var entity = new Categoria()
            {
                Nombre = nombre,
                Descripcion = descripcion
            };
            repository.Agregar<Categoria>(entity);
            return new CategoriaDto { Nombre = entity.Nombre, Descripcion = entity.Descripcion };
        }
        
    }
}
