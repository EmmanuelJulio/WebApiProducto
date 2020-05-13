using System;
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
    public class PrecioProductoController : ControllerBase
    {
        private readonly IPrecioProductoService servicio;

        public PrecioProductoController(IPrecioProductoService servicio)
        {
            this.servicio = servicio;
        }
        [HttpPost]
        public IActionResult Post([FromQuery] int precioReal,int PrecioVenta)
        {
            try
            {
                return new JsonResult(servicio.createPrecioProducto(precioReal,PrecioVenta)) { StatusCode = 201 };

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}