using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaAplicacionProductos.Servicios;
using CapaDominioProductos.DTOs;
using CapaDominioProductos.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Producto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService servicio;


        public ProductoController(IProductoService servicio)
        {
            this.servicio = servicio;
        }

        [HttpPost]
        public Producto Post(ProductoDto producto)
        {
            return servicio.createProducto(producto);
        }
        [HttpGet]
        public IActionResult GETSearchPrice([FromQuery] int precio)
        {
            try
            {
                return new JsonResult(servicio.BusquedaProducto(precio)) { StatusCode = 200 };

            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);

            }
        }
    }
}