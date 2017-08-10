using Fiap.Exmplo01.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exmplo01.Web.MVC.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Gravar(Funcionario funcionario)
        {
            //Passar os valores para tela
            ViewBag.Nome = funcionario.Nome;
            ViewBag.Data = funcionario.Data;
            ViewBag.Sal = funcionario.Salario;
            return View(funcionario);
        }

    }
}