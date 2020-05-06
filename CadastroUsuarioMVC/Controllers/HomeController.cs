using CadastroUsuarioMvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastroUsuarioBL;

namespace CadastroUsuarioMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            UsuarioBL u = new UsuarioBL();
            if (u.Login(usuario.Login, usuario.Senha))
            {
                return RedirectToAction("Index", "Processo");
            }
            else
            {
                return Content("Tente de novo");
            }
        }
    }
}