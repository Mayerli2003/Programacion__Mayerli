using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APImamm.Controllers
{
    public class ProductoController : ApiController
    {
        [System.Web.Http.HttpPost]   
        public IHttpActionResult Add()
        {
            using(Models.BarBDEntities dato= new Models.BarBDEntities())
            {
                var oProducto = new Models.Producto();
                oProducto.nomProd = "Chakalaka";
                oProducto.descripcion = "fresa";
                oProducto.precio = Convert.ToDecimal(1.5);
                oProducto.cantidad = 10;
                oProducto.estado = 1;

                dato.Producto.Add(oProducto);
                dato.SaveChanges();

            }
            return Ok("Guardado correctamente");
        }
    }
}
