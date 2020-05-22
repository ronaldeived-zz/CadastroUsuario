using CadastroUsuarioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarioEntity
{
    public class ProcessoContext : BaseContext
    {
        private BaseContext db = new BaseContext();

        public List<Processo> HomeProcesso(List<decimal> id_status)
        {
            return db.Processo.Where(p => id_status.Contains(p.Id_Status)).ToList();
        }
        public void CadastrarProcesso(Processo processo)
        {
            db.Processo.Add(processo);
            db.SaveChanges();
        }
        
        public Processo GetProcesso(int id)
        {
            return db.Processo.Find(id);
        }

        //public bool PostEditar(Processo processo)
        //{

        //}

        public void Excluir(decimal id)
        {
            db.Processo.Remove(db.Processo.Find(id));
            db.SaveChanges();
        }
    }
}