using CadastroUsuarioModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarioDAL
{
    public class FluxoDAL : BaseDAL
    {
        public int VerificaNacionalidade(int id)
        {
            using (connection = new SqlConnection(stringDB))
            {
                connection.Open();
                command = new SqlCommand(@"select ID_PAIS from PROCESSO P
                    INNER JOIN CIDADE C ON C.ID_CIDADE = P.ID_CIDADE
                    INNER JOIN ESTADO E ON E.ID_ESTADO = C.ID_ESTADO
                where ID_PROCESSO = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.CommandType = CommandType.Text;
                int id_pais = 0;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id_pais = Convert.ToInt32(reader["ID_PAIS"]);
                }
                connection.Close();
                return id_pais;
            }
        }

        public bool EncaminhaGerente(int id)
        {
            using (connection = new SqlConnection(stringDB))
            {
                command = new SqlCommand(@"update PROCESSO set ID_STATUS = @Status
                where ID_PROCESSO = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@Status", 1);
                connection.Open();
                int cont = command.ExecuteNonQuery();
                connection.Close();

                if (cont > 0)
                    return true;
                else
                    return false;
            }
        }
        public bool EncaminhaControleRisco(int id)
        {
            using (connection = new SqlConnection(stringDB))
            {
                command = new SqlCommand(@"update PROCESSO set ID_STATUS = @Status
                where ID_PROCESSO = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@Status", 6);
                connection.Open();
                int cont = command.ExecuteNonQuery();
                connection.Close();

                if (cont > 0)
                    return true;
                else
                    return false;
            }
        }
        public bool EncaminhaCorrecao(int id)
        {
            using (connection = new SqlConnection(stringDB))
            {
                command = new SqlCommand(@"update PROCESSO set ID_STATUS = @Status
                where ID_PROCESSO = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@Status", 5);
                connection.Open();
                int cont = command.ExecuteNonQuery();
                connection.Close();

                if (cont > 0)
                    return true;
                else
                    return false;
            }
        }
        public bool Aprovar(int id)
        {
            using (connection = new SqlConnection(stringDB))
            {
                command = new SqlCommand(@"update PROCESSO set ID_STATUS = @Status
                where ID_PROCESSO = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@Status", 3);
                connection.Open();
                int cont = command.ExecuteNonQuery();
                connection.Close();

                if (cont > 0)
                    return true;
                else
                    return false;
            }
        }
        public bool Reprovar(int id)
        {
            using (connection = new SqlConnection(stringDB))
            {
                command = new SqlCommand(@"update PROCESSO set ID_STATUS = @Status
                where ID_PROCESSO = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@Status", 2);
                connection.Open();
                int cont = command.ExecuteNonQuery();
                connection.Close();

                if (cont > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool Usuario_Processo(int id_processo, int id_usuario, int id_status)
        {
            using (connection = new SqlConnection(stringDB))
            {
                command = new SqlCommand(@"INSERT INTO USUARIO_PROCESSO 
                    VALUES(@ID_PROCESSO, @ID_USUARIO, @ID_STATUS, @DATA_ENTRADA, @DATA_SAIDA)", connection);
                connection.Open();

                command.Parameters.AddWithValue("@ID_PROCESSO", id_processo);
                command.Parameters.AddWithValue("@ID_USUARIO", id_usuario);
                command.Parameters.AddWithValue("@ID_STATUS", id_status);
                command.Parameters.AddWithValue("@DATA_ENTRADA", new DateTime().Date);
                command.Parameters.AddWithValue("@DATA_SAIDA", new DateTime().Date);

                int cont = command.ExecuteNonQuery();
                connection.Close();

                if (cont > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool VerificaMesmoUsuario(int id_processo, int id_usuario, int id_status)
        {
            using (connection = new SqlConnection(stringDB))
            {
                command = new SqlCommand(@"Select * from USUARIO_PROCESSO WHERE ID_STATUS = @status and ID_USUARIO = @usuario and ID_PROCESSO = @processo", connection);
                command.Parameters.AddWithValue("@status", id_status);
                command.Parameters.AddWithValue("@usuario", id_usuario);
                command.Parameters.AddWithValue("@processo", id_processo);
                command.CommandType = CommandType.Text;
                connection.Open();

                int cont = command.ExecuteNonQuery();
                connection.Close();

                if (cont > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
