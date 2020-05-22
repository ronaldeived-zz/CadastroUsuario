using CadastroUsuarioBL;
using CadastroUsuarioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroUsuarioMvc.Controllers
{
    public class FluxoController : HomeController
    {
        public ActionResult EncaminhaGerente(int id)
        {
            FluxoBL bl = new FluxoBL();
            if (bl.EncaminhaGerente(id))
                return RedirectToAction("Index", "Home");
            else
                return RedirectToAction("", "");
        }
        public ActionResult AprovarGerente(int id)
        {
            FluxoBL bl = new FluxoBL();
            if (bl.VerificaNacionalidade(id) == 1)
            {
                bl.Aprovar(id);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                bl.EncaminhaControleRisco(id);
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult AprovarControleRisco(int id)
        {
            FluxoBL bl = new FluxoBL();
            bl.Aprovar(id);
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Reprovar(int id)
        {
            FluxoBL bl = new FluxoBL();
            bl.Reprovar(id);
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Correcao(int id)
        {
            FluxoBL bl = new FluxoBL();
            bl.EncaminhaCorrecao(id);
            return RedirectToAction("Index", "Home");
        }
    }
}