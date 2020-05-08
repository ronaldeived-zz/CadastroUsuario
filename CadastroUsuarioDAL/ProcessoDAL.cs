using CadastroUsuarioModels;
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
    public class ProcessoDAL
    {
        string stringDB = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        SqlCommand command;
        SqlConnection connection;
        SqlDataAdapter dataAdapter;

        public bool CadastrarProcesso(Processo processo)
        {

            using (connection = new SqlConnection(stringDB))
            {
                command = new SqlCommand(@"INSERT INTO PROCESSO 
                    VALUES(@STATUS, @CIDADE, @NOME, @CPF, @RG, @NASCIMENTO, @EMAIL, @CEP, 
                @RUA, @NUMERO, @COMPLEMENTO, @BAIRRO, @CELULAR, @Sexo)", connection);
                connection.Open();

                command.Parameters.AddWithValue("@CIDADE",Convert.ToInt32(processo.Id_Cidade));
                command.Parameters.AddWithValue("@STATUS", 5);
                command.Parameters.AddWithValue("@NOME", processo.Nome.ToString());
                command.Parameters.AddWithValue("@CPF", Convert.ToDecimal(processo.Cpf));
                command.Parameters.AddWithValue("@RG", Convert.ToDecimal(processo.Rg));
                command.Parameters.AddWithValue("@NASCIMENTO",Convert.ToDateTime(processo.Nascimento));
                command.Parameters.AddWithValue("@EMAIL", processo.Email.ToString());
                command.Parameters.AddWithValue("@CEP", Convert.ToDecimal(processo.Cep));
                command.Parameters.AddWithValue("@RUA", processo.Rua.ToString());
                command.Parameters.AddWithValue("@NUMERO", processo.Rua.ToString());
                command.Parameters.AddWithValue("@COMPLEMENTO", processo.Complemento.ToString());
                command.Parameters.AddWithValue("@BAIRRO", processo.Bairro.ToString());
                command.Parameters.AddWithValue("@CELULAR", Convert.ToDecimal(processo.Celular));
                command.Parameters.AddWithValue("@Sexo", processo.Sexo.ToString());
                
                int cont = command.ExecuteNonQuery();
                connection.Close();
                
                if (cont > 0)
                    return true;
                else
                    return false;
            }
        }
        
        public Processo GetProcesso(int id)
        {
            using (connection = new SqlConnection(stringDB))
            {
                Processo processo = new Processo();
                connection.Open();
                command = new SqlCommand(@"select * from PROCESSO where ID_PROCESSO = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                dataAdapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    processo.Id_Processo = Convert.ToInt32(dt.Rows[0][0].ToString());
                    processo.Id_Status = Convert.ToInt32(dt.Rows[0][1].ToString());
                    processo.Id_Cidade = Convert.ToInt32(dt.Rows[0][2].ToString());
                    processo.Nome = dt.Rows[0][3].ToString();
                    processo.Cpf = Convert.ToDecimal(dt.Rows[0][4].ToString());
                    processo.Rg = Convert.ToInt32(dt.Rows[0][5].ToString());
                    processo.Nascimento = Convert.ToDateTime(dt.Rows[0][6]);
                    processo.Email = dt.Rows[0][7].ToString();
                    processo.Cep = Convert.ToInt32(dt.Rows[0][8].ToString());
                    processo.Rua = dt.Rows[0][9].ToString();
                    processo.Numero = dt.Rows[0][10].ToString();
                    processo.Complemento = dt.Rows[0][11].ToString();
                    processo.Bairro = dt.Rows[0][12].ToString();
                    processo.Celular = Convert.ToDecimal(dt.Rows[0][13].ToString());
                    processo.Sexo = dt.Rows[0][14].ToString();
                }

                return processo;
            }
        }

        public bool PostEditar(Processo processo)
        {
            using (connection = new SqlConnection(stringDB))
            {
                command = new SqlCommand(@"update PROCESSO set ID_STATUS = @Status, ID_CIDADE=@Cidade,
                        NOME = @Nome, CPF = @Cpf, RG = @Rg, NASCIMENTO = @Nascimento, EMAIL = @Email, CEP = @Cep, 
                        RUA = @Rua, NUMERO = @Numero, COMPLEMENTO = @Complemento, BAIRRO = @Bairro, CELULAR = @Celular, SEXO = @Sexo
                where ID_PROCESSO = @id", connection);

                command.Parameters.AddWithValue("@id", processo.Id_Processo);
                command.Parameters.AddWithValue("@Cidade", Convert.ToInt32(processo.Id_Cidade));
                command.Parameters.AddWithValue("@Status", 5);
                command.Parameters.AddWithValue("@Nome", processo.Nome.ToString().ToUpper());
                command.Parameters.AddWithValue("@Cpf", Convert.ToDecimal(processo.Cpf));
                command.Parameters.AddWithValue("@Rg", Convert.ToDecimal(processo.Rg));
                command.Parameters.AddWithValue("@Nascimento", Convert.ToDateTime(processo.Nascimento));
                command.Parameters.AddWithValue("@Email", processo.Email.ToString().ToLower());
                command.Parameters.AddWithValue("@Cep", Convert.ToDecimal(processo.Cep));
                command.Parameters.AddWithValue("@Rua", processo.Rua.ToString().ToUpper());
                command.Parameters.AddWithValue("@Numero", processo.Rua.ToString().ToUpper());
                command.Parameters.AddWithValue("@Complemento", processo.Complemento.ToString().ToUpper()).;
                command.Parameters.AddWithValue("@Bairro", processo.Bairro.ToString().ToUpper());
                command.Parameters.AddWithValue("@Celular", Convert.ToDecimal(processo.Celular));
                command.Parameters.AddWithValue("@Sexo", processo.Sexo.ToString().ToUpper());
                connection.Open();
                int cont = command.ExecuteNonQuery();
                connection.Close();

                if (cont > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool Excluir(int id)
        {
            using (connection = new SqlConnection(stringDB))
            {
                command = new SqlCommand(@"DELETE PROCESSO WHERE ID_PROCESSO=@Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                int cont = command.ExecuteNonQuery();
                if (cont > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}