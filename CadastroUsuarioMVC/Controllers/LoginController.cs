using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
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
            if (ModelState.IsValid)
            {
                if(Autenticar(usuario.Login, usuario.Senha))
                {
                    UsuarioBL u = new UsuarioBL();
                    LoginBL bl = new LoginBL();
                    usuario = bl.Login(usuario.Login, usuario.Senha);
                    Session["ID_USUARIO"] = Convert.ToInt32(usuario.Id_Usuario);
                    Session["NOME"] = usuario.Nome.ToString();
                    Session["ID_PERFIL"] = u.AcessoParaCadastrar(usuario.Usuario_Perfis.Select(x => x.Id_Perfil).ToList());
                    Session["STATUS_PERMITIDO"] = u.GetStatus(usuario.Usuario_Perfis.Select(x => x.Id_Perfil).ToList());
                    return RedirectToAction("UserDashBoard");
                }
                else
                {
                    ModelState.AddModelError("", "Wrong username or password");
                }
            }
            return RedirectToAction("Index", usuario);
        }

        public bool Autenticar(string login, string senha)
        {
            UsuarioBL u = new UsuarioBL();
            LoginBL bl = new LoginBL();
            Usuario usuario = bl.Login(login, senha);
            if (usuario != null)
            {   
                FormsAuthentication.RedirectFromLoginPage(usuario.Login, false);
                return true;
            }
            else
                return false;
        }
        public ActionResult UserDashBoard()
        {
            if (Session["ID_USUARIO"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}