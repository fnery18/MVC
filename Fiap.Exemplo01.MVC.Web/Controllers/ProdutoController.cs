using Fiap.Exemplo01.MVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> _lista = new List<Produto>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_lista);
        }

        [HttpGet] // Carrega a pagina com o formulário
        public ActionResult Cadastrar()
        {
            return View(); //<- // botao direito aqui, pra criar uma view já no lugar certo
        }

        [HttpPost]
        // mvca tab tab 

        //get abre pagina

        //post processa info

        public ActionResult Cadastrar(Produto produto)
        {
            // viewbag.nome que vc quiser (cria na hora) 

            // é como se fosse um variavel global // 
            _lista.Add(produto);
            ViewBag.prod = produto;


            TempData["mensagem"] = "Produto Cadastrado!";

            //Retorna a view Sucesso.cshtml.
            //colocar o ,produto é para o 3ºjeito de enviar as informações para outra view.
            return View("Sucesso",produto);

            //return Content(produto.Nome + " " + produto.Valor + " " + produto.Quantidade);
        }
    }
}