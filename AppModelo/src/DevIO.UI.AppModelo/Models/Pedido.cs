using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.AppModelo.Models
{
    public class Pedido
    {
        public Pedido()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
