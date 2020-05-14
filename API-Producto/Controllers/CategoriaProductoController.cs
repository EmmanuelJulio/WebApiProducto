using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaAplicacionProductos.Servicios;
using CapaDominioProductos.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Producto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaProductoController : ControllerBase
    {
        private readonly ICategoriaProductoService service;

        public CategoriaProductoController(ICategoriaProductoService service)
        {
            this.service = service;
        }
        [HttpPost]
       
        public IActionResult Post([FromQuery] int ProductoID, int CategoriaID)
        {
            return new JsonResult(service.createCategoriaProducto(ProductoID,CategoriaID)) { StatusCode = 201 };
        }

    }
}