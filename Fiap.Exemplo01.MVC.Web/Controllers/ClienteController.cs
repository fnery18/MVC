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
        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = new List<string>();
            lista.Add("Solteiro");
            lista.Add("Casado");
            lista.Add("Separado");

            ViewBag.estados = new SelectList(lista);

            return View();
        }

        private static List<Cliente> _lista = new List<Cliente>();
        [HttpPost]
        public ActionResult Cadastrar(Cliente cliente)
        {
            _lista.Add(cliente);
            TempData["msg"] = "Cliente Cadastrado!";
            return RedirectToAction("Cadastrar"); // rsolve o problema de na hora de salvar o cadastro, f5 cadastra tudo em branco.


        }

        public ActionResult Listar()
        {
            ViewBag.lista = _lista;
            return View();
        }
    }
}