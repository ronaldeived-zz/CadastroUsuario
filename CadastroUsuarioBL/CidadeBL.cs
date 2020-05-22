using CadastroUsuarioDAL;
using CadastroUsuarioModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarioBL
{
    public class CidadeBL
    {
        private CidadeDAL dal = new CidadeDAL();
        public List<Pais> GetListaPais()
        {
            return dal.GetListaPais();
        }

        public List<Estado> GetListaEstado(decimal id_Pais)
        {
            return dal.GetListaEstado(id_Pais);
        }

        public List<Cidade> GetListaCidade(decimal id_Estado)
        {
            return dal.GetListaCidade(id_Estado);
        }

        public int GetIdEstado(decimal id_cidade)
        {
            return dal.GetIdEstado(id_cidade);
        }

        public int GetIdPais(decimal id_cidade)
        {
            return dal.GetIdPais(id_cidade);
        }

        public string GetNomeCidade(decimal id_cidade)
        {
            return dal.GetNomeCidade(id_cidade);
        }

        public string GetNomeEstado(decimal id_cidade)
        {
            return dal.GetNomeEstado(id_cidade);
        }

        public string GetNomePais(decimal id_cidade)
        {
            return dal.GetNomePais(id_cidade);
        }
    }
}
