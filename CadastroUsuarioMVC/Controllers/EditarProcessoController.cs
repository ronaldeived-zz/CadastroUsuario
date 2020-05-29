using CadastroUsuarioBL;
using CadastroUsuarioModels;
using System;
using System.Web.Mvc;

namespace CadastroUsuarioMvc.Controllers
{
    public class EditarProcessoController : ProcessoController
    {
        private ProcessoBL bl = new ProcessoBL();
        private CidadeBL Cbl = new CidadeBL();
        private FluxoBL fBL = new FluxoBL();

        [HttpGet]
        public ActionResult Editar(decimal id)
        {
            Processo processo = bl.GetProcesso(id);

            GetPais();
            GetEspecificoEstado(processo.Cidade.Estado.Id_Pais);
            GetEspecificoCidade(processo.Cidade.Estado.Id_Estado);

            return View("Editar", processo);
        }

        [HttpPost]
        public ActionResult Editar(Processo processo)
        {
            processo.Id_Cidade = processo.Cidade.Id_Cidade;
            var id_usuario = Convert.ToDecimal(Session["ID_USUARIO"]);
            var id_status = processo.Id_Status;
            var id_processo = processo.Id_Processo;
            if (bl.PostEditar(processo))
            {
                fBL.Rastreabilidade(id_processo, id_usuario, id_status);
                return RedirectToAction("Index", "Home");
            }
            else
                return Content("Algo deu errado!");
        }

        public void GetEspecificoEstado(decimal id_Pais)
        {
            ViewBag.GetEstado = Cbl.GetListaEstado(id_Pais);
        }

        public void GetEspecificoCidade(decimal id_Estado)
        {
            ViewBag.GetCidade = Cbl.GetListaCidade(id_Estado);
        }
    }
}