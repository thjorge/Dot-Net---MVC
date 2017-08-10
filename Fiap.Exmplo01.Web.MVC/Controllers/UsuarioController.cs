using Fiap.Exmplo01.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exmplo01.Web.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Salvar(Usuario usuario)
        {
            ViewBag.Nome = usuario.Nome;
            ViewBag.Idade = usuario.Idade;
            ViewBag.Email = usuario.Email;
            return View(usuario);
        }
    }
}