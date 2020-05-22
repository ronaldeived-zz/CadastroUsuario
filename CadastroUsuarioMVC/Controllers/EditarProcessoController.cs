using CadastroUsuarioBL;
using CadastroUsuarioModels;
using System.Web.Mvc;

namespace CadastroUsuarioMvc.Controllers
{
    public class EditarProcessoController : ProcessoController
    {
        [HttpGet]
        public ActionResult Editar(int id)
        {
            ProcessoViewEditar p = new ProcessoViewEditar();
            ProcessoBL bl = new ProcessoBL();
            CidadeBL blCidade = new CidadeBL();
            Processo processo = bl.GetProcesso(id);

            //p.Id_Processo = processo.Id_Processo;
            //p.Id_Cidade = processo.Id_Cidade;
            //p.Id_Status = processo.Id_Status;
            //p.Nome = processo.Nome;
            //p.Cpf = processo.Cpf;
            //p.Rg = processo.Rg;
            //p.Email = processo.Email;
            //p.Nascimento = processo.Nascimento;
            //p.Cep = processo.Cep;
            //p.Rua = processo.Rua;
            //p.Numero = processo.Numero;
            //p.Complemento = processo.Complemento;
            //p.Bairro = processo.Bairro;
            //p.Celular = processo.Celular;
            //p.Sexo = processo.Sexo;

            //p.Id_Pais = blCidade.GetIdPais(p.Id_Cidade);
            //p.Id_Estado = blCidade.GetIdEstado(p.Id_Cidade);

            GetPais();
            GetEspecificoEstado(processo.Cidade.Estado.Pais.Id_Pais);
            GetEspecificoCidade(processo.Cidade.Estado.Id_Estado);

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

        public void GetEspecificoEstado(decimal id_Pais)
        {
            CidadeBL bl = new CidadeBL();
            ViewBag.GetEstado = bl.GetListaEstado(id_Pais);
        }

        public void GetEspecificoCidade(decimal id_Estado)
        {
            CidadeBL bl = new CidadeBL();
            ViewBag.GetCidade = bl.GetListaCidade(id_Estado);
        }
    }
}