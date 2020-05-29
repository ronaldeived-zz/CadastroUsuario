using CadastroUsuarioDAL;
<<<<<<< HEAD
using CadastroUsuarioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
using CadastroUsuarioEntity;
using CadastroUsuarioModels;
using System.Collections.Generic;
>>>>>>> developerMVC

namespace CadastroUsuarioBL
{
    public class ProcessoBL
    {
<<<<<<< HEAD
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
=======
        private ProcessoContext db = new ProcessoContext();
        private ProcessoDAL dal = new ProcessoDAL();

        public List<Processo> HomeProcesso(List<decimal> lista_status)
        {
            return db.HomeProcesso(lista_status);
        }

        public decimal CadastrarProcesso(Processo processo)
        {
            if (processo != null)
            {
                return db.CadastrarProcesso(processo);
            }
            else
                return new decimal(null);
        }

        public Processo GetProcesso(decimal id)
        {
            return db.GetProcesso(id);
        }

        public bool PostEditar(Processo processo)
        {
            if (processo != null)
            {
                db.PostEditar(processo);
                return true;
            }
            else
                return false;
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
>>>>>>> developerMVC
        }
    }
}
