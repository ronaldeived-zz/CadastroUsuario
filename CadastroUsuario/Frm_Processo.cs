﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroUsuario
{
    public partial class Frm_Processo : Form
    {
        /*Atributos relacionados ao index da linha na tabela e o ID_Processo */
        int indexRow;
        int id_Processo;

        /*Atributos relacionados ao banco de dados */
        SqlConnection connection = new SqlConnection(@"Data Source=BRPC003828;Initial Catalog=CADASTRO_USUARIO;Persist Security Info=True;User ID=sa;Password=Gftbr!2020");
        SqlCommand sqlCommand;
        SqlDataAdapter dataAdapter;
        public string nome_Usuario { get; set; }


        public Frm_Processo(string _nome_Usuario)
        {
            InitializeComponent();
            autoTableUpdate();
            nome_Usuario = _nome_Usuario;
            setNomeUsuario();
        }

        /* Metodo de atualização de tabela */
        private void autoTableUpdate()
        {
            sqlCommand = new SqlCommand(@"select PAIS.NOME AS PAIS, ESTADO.NOME AS ESTADO, CIDADE.NOME AS CIDADE, STATUS.DESCRICAO AS STATUS, PROCESSO.*  from PROCESSO
                INNER JOIN STATUS ON STATUS.ID_STATUS = PROCESSO.ID_STATUS
                INNER JOIN CIDADE ON CIDADE.ID_CIDADE = PROCESSO.ID_CIDADE
                INNER JOIN ESTADO ON ESTADO.ID_ESTADO = CIDADE.ID_ESTADO
            INNER JOIN PAIS ON PAIS.ID_PAIS = ESTADO.ID_PAIS", connection);

            dataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            dataAdapter.Fill(data);
            Grd_Processos.DataSource = data;
        }

        private void Grd_Processos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = Grd_Processos.Rows[indexRow];
            id_Processo = Convert.ToInt32(row.Cells[4].Value.ToString());
            Txt_Status.Text = row.Cells[5].Value.ToString();
            Txt_Cidade.Text = row.Cells[6].Value.ToString();
            Txt_Nome.Text = row.Cells[7].Value.ToString();
            Txt_Cpf.Text = row.Cells[8].Value.ToString();
            Txt_Rg.Text = row.Cells[9].Value.ToString();
            Txt_Nascimento.Text = row.Cells[10].Value.ToString();
            Txt_Email.Text = row.Cells[11].Value.ToString();
            Txt_Cep.Text = row.Cells[12].Value.ToString();
            Txt_Rua.Text = row.Cells[13].Value.ToString();
            Txt_Numero.Text = row.Cells[14].Value.ToString();
            Txt_Complemento.Text = row.Cells[15].Value.ToString();
            Txt_Bairro.Text = row.Cells[16].Value.ToString();
            Txt_Celular.Text = row.Cells[17].Value.ToString();
            Txt_Sexo.Text = row.Cells[18].Value.ToString();
        }
        /*Metodo para inserir um método*/
        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (Txt_Status.Text != "" && Txt_Cidade.Text != "" && Txt_Nome.Text != "" && Txt_Cpf.Text != "" && Txt_Rg.Text != "")
            {
                try
                {
                    sqlCommand = new SqlCommand(@"INSERT INTO PROCESSO
                        VALUES(@STATUS, @CIDADE, @NOME, @CPF, @RG, @NASCIMENTO, @EMAIL, @CEP, 
                    @RUA, @NUMERO, @COMPLEMENTO, @BAIRRO, @CELULAR, @SEXO)", connection);

                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@STATUS", Txt_Status.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@CIDADE", Txt_Cidade.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@NOME", Txt_Nome.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@CPF", Txt_Cpf.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@RG", Txt_Rg.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@NASCIMENTO", Txt_Nascimento.Text);
                    sqlCommand.Parameters.AddWithValue("@EMAIL", Txt_Email.Text.ToLower());
                    sqlCommand.Parameters.AddWithValue("@CEP", Txt_Cep.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@RUA", Txt_Rua.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@NUMERO", Txt_Numero.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@COMPLEMENTO", Txt_Complemento.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@BAIRRO", Txt_Bairro.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@CELULAR", Txt_Celular.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@SEXO", Txt_Sexo.Text.ToUpper());
                    int affectedRows = sqlCommand.ExecuteNonQuery();
                    
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Registro incluído com sucesso...");
                        autoTableUpdate();
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erro : " + exc.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

        /*Metodo para atualizar algum processo existente */
        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (Txt_Nome.Text != "" && Txt_Cpf.Text != "")
            {
                try
                {
                    sqlCommand = new SqlCommand(@"update PROCESSO set ID_STATUS = @Status, ID_CIDADE=@Cidade,
                        NOME = @Nome, CPF = @Cpf, RG = @Rg, NASCIMENTO = @Nascimento, EMAIL = @Email, CEP = @Cep, 
                        RUA = @Rua, NUMERO = @Numero, COMPLEMENTO = @Complemento, BAIRRO = @Bairro, CELULAR = @Celular, SEXO = @Sexo
                    where ID_PROCESSO = @id", connection);

                    sqlCommand.Parameters.AddWithValue("@Id", id_Processo);
                    sqlCommand.Parameters.AddWithValue("@Status", Txt_Status.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@Cidade", Txt_Cidade.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@Nome", Txt_Nome.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@Cpf", Txt_Cpf.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@Rg", Txt_Rg.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@Nascimento", Txt_Nascimento.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@Email", Txt_Email.Text.ToLower());
                    sqlCommand.Parameters.AddWithValue("@Cep", Txt_Cep.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@Rua", Txt_Rua.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@Numero", Txt_Numero.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@Complemento", Txt_Complemento.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@Bairro", Txt_Bairro.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@Celular", Txt_Celular.Text.ToUpper());
                    sqlCommand.Parameters.AddWithValue("@Sexo", Txt_Sexo.Text.ToUpper());
                    connection.Open();

                    int affectedRows = sqlCommand.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Processo atualizado com sucesso!");
                        autoTableUpdate();
                    }
                    else
                    {
                        throw new Exception(); ;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            
            else
            {
                MessageBox.Show("Selecione um processo para atualizar!");
            }
        }

        /* Metodo para a exclusão do processo */
        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            if (Txt_Excluir.Text != "")
            {
                try
                {
                    sqlCommand = new SqlCommand(@"delete PROCESSO WHERE ID_PROCESSO = @id", connection);
                    sqlCommand.Parameters.AddWithValue("@id", Txt_Excluir.Text);
                    connection.Open();
                    int affectedRows = sqlCommand.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Processo excluido com sucesso!");
                        autoTableUpdate();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Falha na execução " + exc);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        /*Metodo para limpar os campos dos compos */
        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            Txt_Status.Text = "";
            Txt_Cidade.Text = "";
            Txt_Nome.Text = "";
            Txt_Cpf.Text = "";
            Txt_Rg.Text = "";
            Txt_Nascimento.Text = "";
            Txt_Email.Text = "";
            Txt_Cep.Text = "";
            Txt_Rua.Text = "";
            Txt_Numero.Text = "";
            Txt_Complemento.Text = "";
            Txt_Bairro.Text = "";
            Txt_Celular.Text = "";
            Txt_Sexo.Text = "";
            Txt_Status.Focus();
            autoTableUpdate();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Application.Exit();
        }

        private void Frm_Processo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /* Metodo para setar o nome do usuario que está logado */
        private void setNomeUsuario()
        {
            Txt_Nome_Usuario.Text = "";
            Txt_Nome_Usuario.Text = nome_Usuario;
        }
    }
}
