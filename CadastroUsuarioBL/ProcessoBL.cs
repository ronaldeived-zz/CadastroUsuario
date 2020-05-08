using CadastroUsuarioDAL;
using CadastroUsuarioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarioBL
{
    public class ProcessoBL
    {
        public bool CadastrarProcesso(Processo processo)
        {

            ProcessoDAL dal = new ProcessoDAL();

            return dal.CadastrarProcesso(processo);
        }

        public Processo GetProcesso(int id)
        {
            ProcessoDAL dal = new ProcessoDAL();

            return dal.GetProcesso(id);
        }

        public bool PostEditarProcesso(Processo processo)
        {
            ProcessoDAL dal = new ProcessoDAL();

            return dal.PostEditar(processo);
        }

        public bool ExcluirProcesso(int id)
        {
            ProcessoDAL dal = new ProcessoDAL();

            return dal.Excluir(id);
        }
    }
}
