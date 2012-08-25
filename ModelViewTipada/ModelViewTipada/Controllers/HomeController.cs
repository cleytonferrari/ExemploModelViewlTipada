using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelViewTipada.Models;

namespace ModelViewTipada.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Listar(Pessoa pessoa)
        {
            if (string.IsNullOrEmpty(pessoa.Nome))
            {
                ViewBag.Erro = "Preencha o nome da pessoa";
                return View("Index", pessoa);
            }
            //Poderia ter aqui agora um metodo para salvar no banco de dados
            // SalvarNoBanco(pessoa);

            return View(pessoa);
        }
    }
}
