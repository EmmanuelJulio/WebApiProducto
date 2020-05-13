﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaAplicacionProductos.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Producto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaService service;

        public CategoriasController(ICategoriaService service)
        {
            this.service = service;
        }
        [HttpPost]
        public IActionResult Post(string nombre, string Descripcion)
        {
            try
            {
                return new JsonResult(service.createCategoria(nombre,Descripcion)) { StatusCode = 201 };

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}