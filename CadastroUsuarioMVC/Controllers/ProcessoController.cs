using CadastroUsuarioBL;
using CadastroUsuarioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroUsuarioMvc.Controllers
{
    public class ProcessoController : Controller
    {
        // GET: Processo
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Cadastrar(Processo processo)
        {
            ProcessoBL bl = new ProcessoBL();

            if (bl.CadastrarProcesso(processo))
                return RedirectToAction("Index", "Processo");
            else
                return Content("Não salvo");
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            ProcessoBL bl = new ProcessoBL();
            Processo processo = bl.GetProcesso(id);

            return View("Editar", processo);
        }

        [HttpPost]
        public ActionResult Editar(Processo processo)
        {
            ProcessoBL bl = new ProcessoBL();

            if (bl.PostEditarProcesso(processo))
                return RedirectToAction("Index", "Home");
            else
                return Content("Algo deu errado!");
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            ProcessoBL bl = new ProcessoBL();

            if (bl.ExcluirProcesso(id))
                return RedirectToAction("Index", "Home");
            else
                return Content("Algo deu errado");
        }

        //[HttpPost]
        //public ActionResult Excluir(int id)
        //{
        //    ProcessoBL bl = new ProcessoBL();

        //    if (bl.ExcluirProcesso(id)) 
        //        return RedirectToAction("Index", "Home");
        //    else
        //        return Content("Algo deu errado");
        //}
    }
}