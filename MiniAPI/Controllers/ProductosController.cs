using Microsoft.AspNetCore.Mvc;
using MiniAPI.Datos;
using MiniAPI.Modelo;

namespace MiniAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly AppBdContenido atributoA;

        public ProductosController(AppBdContenido atributoA)
        {
            this.atributoA = atributoA;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {
            return atributoA.Productos.ToList();
        }
    }
}
