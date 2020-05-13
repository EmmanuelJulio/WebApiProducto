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

        [HttpPost("Post")]
        public IActionResult Post([FromQuery] int imagen,int precioproducto,int categoria,int marca,string nombre,string descripcion,int stock)
        {
            try
            {
                return new  JsonResult(servicio.createProducto(imagen, precioproducto, categoria, marca,nombre,descripcion,stock)) { StatusCode = 201};

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }        
        }

        //busca un producto por su precio
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

        //devuelve una lista de productos

        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
            try
            {
                return new JsonResult(servicio.GetAllProducto()) { StatusCode = 200 };

            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);

            }
        }
    }
}