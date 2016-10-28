using Fiap.Exemplo01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult CadastrarC()
        {
            return View("Cadastrar");
        }

        private static List<Cliente> _lista = new List<Cliente>();

        public ActionResult Cadastrar(Cliente cliente)
        {
            _lista.Add(cliente);
            return Content("<h1> Cliente Cadastado!</h1>");

        }

        public ActionResult Listar()
        {
            ViewBag.lista = _lista;
            return View();
        }
    }
}