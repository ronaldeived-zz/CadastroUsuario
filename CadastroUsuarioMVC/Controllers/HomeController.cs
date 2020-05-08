using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using CadastroUsuarioBL;
using CadastroUsuarioModels;

namespace CadastroUsuarioMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Processo
        [HttpGet]
        public ActionResult Index()
        {
            List<Processo> listaProcessos = new List<Processo>();

            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand command = new SqlCommand("Select * from PROCESSO", connection);
                command.CommandType = CommandType.Text;
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var processo = new Processo();

                    processo.Id_Processo = Convert.ToInt32(reader["ID_PROCESSO"]);
                    processo.Id_Status = Convert.ToInt32(reader["ID_STATUS"]);
                    processo.Id_Cidade = Convert.ToInt32(reader["ID_CIDADE"]);
                    processo.Nome = reader["NOME"].ToString();
                    processo.Cpf = Convert.ToDecimal(reader["CPF"]);
                    processo.Rg = Convert.ToInt32(reader["RG"]);
                    processo.Nascimento = Convert.ToDateTime(reader["NASCIMENTO"]);
                    processo.Email = reader["EMAIL"].ToString();
                    processo.Cep = Convert.ToInt32(reader["CEP"]);
                    processo.Rua = reader["RUA"].ToString();
                    processo.Numero = reader["NUMERO"].ToString();
                    processo.Complemento = reader["COMPLEMENTO"].ToString();
                    processo.Bairro = reader["BAIRRO"].ToString();
                    processo.Celular = Convert.ToDecimal(reader["CELULAR"]);
                    processo.Sexo = reader["SEXO"].ToString();
                    listaProcessos.Add(processo);
                }
            }
            return View(listaProcessos);
        }

        public ActionResult Editar(int id)
        {
            return RedirectToAction("Editar", "Processo", new { id = id });
        }
    }
}