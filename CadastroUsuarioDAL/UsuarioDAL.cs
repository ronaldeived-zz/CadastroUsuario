using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarioDAL
{
    public class UsuarioDAL
    {
        public DataSet GetUsuario()
        {
            ConnectionGeral connection = new ConnectionGeral();
            return connection.ReturnDataSet("SELECT * FROM USUARIO");
        }
        public bool Login(string usuario, string senha)
        {
            SqlCommand command;
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(CS))
            {
                command = new SqlCommand(@"Select U.NOME from USUARIO U
                INNER JOIN USUARIO_PERFIL UP ON UP.ID_USUARIO = U.ID_USUARIO 
                WHERE LOGIN= '" + usuario + "' AND SENHA = '" + senha + "'", connection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                dataAdapter.Fill(data);
                return data.Rows.Count == 1;
            }
        }
    }
}
