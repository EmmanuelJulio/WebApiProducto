using CapaDominioProductos.Querys;
using SqlKata.Compilers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaAccesoDatosProductos.Querys
{
   public class ProductoQuery : IProductoQuery
    {
        private readonly IDbConnection connection;
        private readonly Compiler compiler;

        public ProductoQuery(IDbConnection connection, Compiler compiler)
        {
            this.connection = connection;
            this.compiler = compiler;
        }
    }
}
