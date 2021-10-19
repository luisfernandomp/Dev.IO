using DevIO.UI.AppModelo.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.AppModelo.Controllers
{
    public class HomeController : Controller
    {
        /*
         
         * Caso não fosse possível criar um construtor
         * Usar a palavra reservada [FromServices]
         
         public IActionResult Index([FromServices] IPedidoRepository _pedidoRepository)
         {
             var pedido = _pedidoRepository.ObterPedido();
             return View();
         }
         
         */

        private readonly IPedidoRepository _pedidoRepository;

        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Secret()
        {
            return View();
        }

        [Authorize(Policy = "PodeExcluir")]
        public IActionResult SecretClaim()
        {
            return View("Secret");
        }

        [Authorize(Policy = "PodeEscrever")]
        public IActionResult SecretClaimGravar()
        {
            return View("Secret");
        }

        [Authorize]
        public IActionResult Index()
        {
            var pedido = _pedidoRepository.ObterPedido();
            return View();
        }
    }
}
