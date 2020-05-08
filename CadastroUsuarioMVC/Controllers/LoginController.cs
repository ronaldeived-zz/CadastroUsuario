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
using CadastroUsuarioModels;

namespace CadastroUsuarioMvc.Controllers
{
    public class LoginController : Controller
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
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return Content("Tente de novo");
            }
        }
    }
}