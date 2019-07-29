using System;

namespace AppModelo.Site.Models
{
    public class Pedido
    {
        public Guid Id { get; set; }

        public Pedido()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
