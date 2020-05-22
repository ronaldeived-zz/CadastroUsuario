using CadastroUsuarioDAL;
using CadastroUsuarioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarioBL
{
    public class FluxoBL
    {
        public int VerificaNacionalidade(int id)
        {
            FluxoDAL dal = new FluxoDAL();
            return dal.VerificaNacionalidade(id);
        }
        public bool EncaminhaGerente(int id)
        {
            FluxoDAL dal = new FluxoDAL();
            return dal.EncaminhaGerente(id);
        }
        public bool EncaminhaControleRisco(int id)
        {
            FluxoDAL dal = new FluxoDAL();
            return dal.EncaminhaControleRisco(id);
        }
        public bool EncaminhaCorrecao(int id)
        {
            FluxoDAL dal = new FluxoDAL();
            return dal.EncaminhaCorrecao(id);
        }
        public bool Aprovar(int id)
        {
            FluxoDAL dal = new FluxoDAL();
            return dal.Aprovar(id);
        }
        public bool Reprovar(int id)
        {
            FluxoDAL dal = new FluxoDAL();
            return dal.Reprovar(id);
        }
       
    }
}
