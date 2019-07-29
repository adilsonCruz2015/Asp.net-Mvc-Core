using Microsoft.AspNetCore.Mvc;

namespace AppModelo.Site.Modulos.Vendas.Controllers
{
    [Area("Vendas")]
    [Route("pedidos")]
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}