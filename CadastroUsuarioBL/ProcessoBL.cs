using CadastroUsuarioDAL;
using CadastroUsuarioEntity;
using CadastroUsuarioModels;
using System.Collections.Generic;

namespace CadastroUsuarioBL
{
    public class ProcessoBL
    {
        private ProcessoContext db = new ProcessoContext();
        private ProcessoDAL dal = new ProcessoDAL();

        public List<Processo> HomeProcesso(List<decimal> lista_status)
        {
            return db.HomeProcesso(lista_status);
        }

        public bool CadastrarProcesso(Processo processo)
        {
            if (processo != null)
            {
                db.CadastrarProcesso(processo);
                return true;
            }
            else
                return false;
        }

        public Processo GetProcesso(int id)
        {
            return db.GetProcesso(id);
        }

        public bool PostEditarProcesso(Processo processo)
        {
            return dal.PostEditar(processo);
        }

        public bool ExcluirProcesso(decimal id)
        {
            if (id != 0)
            {
                db.Excluir(id);
                return true;
            }
            else
                return false;
        }

        public string GetStatus(int id_status)
        {
            return dal.GetStatus(id_status);
        }
    }
}
