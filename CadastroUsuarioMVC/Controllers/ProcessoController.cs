using CadastroUsuarioBL;
using CadastroUsuarioModels;
using System.Web.Mvc;

namespace CadastroUsuarioMvc.Controllers
{
    public class ProcessoController : Controller
    {
        private ProcessoBL bl = new ProcessoBL();
        private CidadeBL Cbl = new CidadeBL();
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
            if (bl.CadastrarProcesso(processo))
                return RedirectToAction("Index", "Home");
            else
                return Content("Não salvo");
        }

        [HttpGet]
        public ActionResult Excluir(decimal id)
        {
            if (bl.ExcluirProcesso(id))
                return RedirectToAction("Index", "Home");
            else
                return Content("Algo deu errado");
        }

        public void GetPais()
        {
            ViewBag.GetPais = Cbl.GetListaPais();
        }

        public ActionResult GetListaEstado(int id_Pais)
        {
            return Json(new SelectList(Cbl.GetListaEstado(id_Pais), "ID_ESTADO", "NOME"), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetListaCidade(int id_Estado)
        {
            return Json(new SelectList(Cbl.GetListaCidade(id_Estado), "ID_CIDADE", "NOME"), JsonRequestBehavior.AllowGet);
        }
        
    }
}