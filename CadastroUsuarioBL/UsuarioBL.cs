using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroUsuarioDAL;
using CadastroUsuarioModels;

namespace CadastroUsuarioBL
{
    public class UsuarioBL
    {

        public Usuario Login(string login, string senha)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();

            return usuarioDAL.Login(login, senha);
        }

        public bool AcessoParaCadastrar(List<decimal> perfis)
        {
            Int32 a = new Int32();
            foreach (var item in perfis)
            {
                switch (item)
                {
                    case 1:
                        //Adm
                        a = 1;
                        break;
                    case 3:
                        //Operação
                        a = 1;
                        break;
                    default:
                        break;
                }
            }
            if (a == 1)
                return true;
            else
                return false;
        }

        public List<decimal> GetStatus(List<decimal> perfis)
        {
            List<decimal> listaStatus = new List<decimal>();
            foreach (var item in perfis)
            {
                switch (item)
                {
                    case 1:
                        //Adm
                        List<decimal> statusAdm = new List<decimal>() { 1, 2, 3, 4, 5, 6 };
                        listaStatus = listaStatus.Concat(statusAdm).ToList();
                        break;
                    case 2:
                        //Gerencia
                        List<decimal> statusGer = new List<decimal>() { 1, 2, 3 };
                        listaStatus = listaStatus.Concat(statusGer).ToList();
                        break;
                    case 3:
                        //Operação
                        List<decimal> statusOpe = new List<decimal>() { 2, 3, 4, 5 };
                        listaStatus = listaStatus.Concat(statusOpe).ToList();
                        break;
                    case 4:
                        //Controle de risco
                        List<decimal> statusCtr = new List<decimal>() { 2, 3, 6 };
                        listaStatus = listaStatus.Concat(statusCtr).ToList();
                        break;
                    default:
                        break;
                }
            }
            return listaStatus;
        }
    }
}
