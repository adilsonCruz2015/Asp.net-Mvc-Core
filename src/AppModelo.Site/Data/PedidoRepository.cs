using AppModelo.Site.Models;

namespace AppModelo.Site.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido Obter()
        {
            return new Pedido();
        }
    }

    public interface IPedidoRepository
    {
        Pedido Obter(); 
    }
}
