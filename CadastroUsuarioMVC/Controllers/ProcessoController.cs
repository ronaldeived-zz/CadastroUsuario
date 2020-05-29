using CadastroUsuarioBL;
using CadastroUsuarioModels;
using System.Web.Mvc;
using System;
using System.Net;

namespace CadastroUsuarioMvc.Controllers
{
    public class ProcessoController : Controller
    {
        private ProcessoBL pBL = new ProcessoBL();
        private CidadeBL cBL = new CidadeBL();
        private FluxoBL fBL = new FluxoBL();

        // GET: Processo
        [HttpGet]
        public ActionResult Index()
        {
            GetPais();
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Processo processo)
        {
            var id_usuario = Convert.ToDecimal(Session["ID_USUARIO"]);
            var id_processo =  pBL.CadastrarProcesso(processo);
            var novo = pBL.GetProcesso(id_processo);
            fBL.Rastreabilidade(id_processo, id_usuario, novo.Id_Status);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Excluir(decimal id)
        {
            if (pBL.ExcluirProcesso(id))
                return RedirectToAction("Index", "Home");
            else
                return Content("Algo deu errado");
        }

        public ActionResult Detalhes(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Processo pROCESSO = pBL.GetProcesso(id);
            if (pROCESSO == null)
            {
                return HttpNotFound();
            }
            return View(pROCESSO);
        }

        public void GetPais()
        {
            ViewBag.GetPais = cBL.GetListaPais();
        }

        public ActionResult GetListaEstado(int id_Pais)
        {
            return Json(new SelectList(cBL.GetListaEstado(id_Pais), "ID_ESTADO", "NOME"), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetListaCidade(int id_Estado)
        {
            return Json(new SelectList(cBL.GetListaCidade(id_Estado), "ID_CIDADE", "NOME"), JsonRequestBehavior.AllowGet);
        }
    }
}