using AppModelo.Site.Data;
using Microsoft.AspNetCore.Mvc;

namespace AppModelo.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            this._pedidoRepository = pedidoRepository;
        }

        public IActionResult Index()
        {
            var pedido = _pedidoRepository.Obter();
            return View();
        }
    }
}
