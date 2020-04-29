using System;
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
        int indexRow;
        int ID;
        SqlConnection con = new SqlConnection(@"Data Source=BRPC003828;Initial Catalog=CADASTRO_USUARIO;Persist Security Info=True;User ID=sa;Password=Gftbr!2020");
        SqlCommand cmd;
        SqlDataAdapter db;

        public Frm_Processo()
        {
            InitializeComponent();
        }

        private void Processo_Load(object sender, EventArgs e)
        {
            SqlDataAdapter db = new SqlDataAdapter("SELECT * FROM PROCESSO", "server = BRPC003828; database = CADASTRO_USUARIO; UID = sa; password = Gftbr!2020"); 
            DataSet ds = new DataSet();
            db.Fill(ds, "PROCESSO");
            dataGridView1.DataSource = ds.Tables["PROCESSO"].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

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
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (Txt_Status.Text != "" && Txt_Cidade.Text != "" && Txt_Nome.Text != "" && Txt_Cpf.Text != "" && Txt_Rg.Text != "")
            {
                try
                {
                    cmd = new SqlCommand(@"INSERT INTO PROCESSO(ID_STATUS, ID_CIDADE, NOME, CPF, RG, NASCIMENTO, EMAIL, CEP, RUA, NUMERO, COMPLEMENTO, BAIRRO, CELULAR, SEXO)
                        VALUES(@STATUS, @CIDADE, @NOME, @CPF, @RG, @NASCIMENTO, @EMAIL, @CEP, @RUA, @NUMERO, @COMPLEMENTO, @BAIRRO, @CELULAR, @SEXO)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@STATUS", Txt_Status.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@CIDADE", Txt_Cidade.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@NOME", Txt_Nome.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@CPF", Txt_Cpf.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@RG", Txt_Rg.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@NASCIMENTO", Txt_Nascimento.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@EMAIL", Txt_Email.Text.ToLower());
                    cmd.Parameters.AddWithValue("@CEP", Txt_Cep.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@RUA", Txt_Rua.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@NUMERO", Txt_Numero.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@COMPLEMENTO", Txt_Complemento.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@BAIRRO", Txt_Bairro.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@CELULAR", Txt_Celular.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@SEXO", Txt_Sexo.Text.ToUpper());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluído com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (Txt_Nome.Text != "" && Txt_Cpf.Text != "")
            {
                cmd = new SqlCommand(@"update PROCESSO set ID_STATUS = @Status, ID_CIDADE=@Cidade,
                    NOME = @Nome, CPF = @Cpf, RG = @Rg, NASCIMENTO = @Nascimento, EMAIL = @Email, 
                    CEP = @Cep, RUA = @Rua, NUMERO = @Numero, COMPLEMENTO = @Complemento, BAIRRO = @Bairro, 
                    CELULAR = @Celular, SEXO = @Sexo where ID_PROCESSO = @id", con);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@STATUS", Txt_Status.Text.ToUpper());
                cmd.Parameters.AddWithValue("@CIDADE", Txt_Cidade.Text.ToUpper());
                cmd.Parameters.AddWithValue("@NOME", Txt_Nome.Text.ToUpper());
                cmd.Parameters.AddWithValue("@CPF", Txt_Cpf.Text.ToUpper());
                cmd.Parameters.AddWithValue("@RG", Txt_Rg.Text.ToUpper());
                cmd.Parameters.AddWithValue("@NASCIMENTO", Txt_Nascimento.Text.ToUpper());
                cmd.Parameters.AddWithValue("@EMAIL", Txt_Email.Text.ToLower());
                cmd.Parameters.AddWithValue("@CEP", Txt_Cep.Text.ToUpper());
                cmd.Parameters.AddWithValue("@RUA", Txt_Rua.Text.ToUpper());
                cmd.Parameters.AddWithValue("@NUMERO", Txt_Numero.Text.ToUpper());
                cmd.Parameters.AddWithValue("@COMPLEMENTO", Txt_Complemento.Text.ToUpper());
                cmd.Parameters.AddWithValue("@BAIRRO", Txt_Bairro.Text.ToUpper());
                cmd.Parameters.AddWithValue("@CELULAR", Txt_Celular.Text.ToUpper());
                cmd.Parameters.AddWithValue("@SEXO", Txt_Sexo.Text.ToUpper());
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Processo atualizado com sucesso!");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Não atualizou!");
                }
                
            }
            else
            {
                MessageBox.Show("Selecione um processo para atualizar!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            ID = Convert.ToInt32(row.Cells[0].Value.ToString());
            Txt_Status.Text = row.Cells[1].Value.ToString();
            Txt_Cidade.Text = row.Cells[2].Value.ToString();
            Txt_Nome.Text = row.Cells[3].Value.ToString();
            Txt_Cpf.Text = row.Cells[4].Value.ToString();
            Txt_Rg.Text = row.Cells[5].Value.ToString();
            Txt_Nascimento.Text = row.Cells[6].Value.ToString();
            Txt_Email.Text = row.Cells[7].Value.ToString();
            Txt_Cep.Text = row.Cells[8].Value.ToString();
            Txt_Rua.Text = row.Cells[9].Value.ToString();
            Txt_Numero.Text = row.Cells[10].Value.ToString();
            Txt_Complemento.Text = row.Cells[11].Value.ToString();
            Txt_Bairro.Text = row.Cells[12].Value.ToString();
            Txt_Celular.Text = row.Cells[13].Value.ToString();
            Txt_Sexo.Text = row.Cells[14].Value.ToString();
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            if (Txt_Excluir.Text != "")
            {
                try
                {
                    cmd = new SqlCommand(@"delete PROCESSO WHERE ID_PROCESSO = @id", con);
                    cmd.Parameters.AddWithValue("@id", Txt_Excluir.Text);
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Processo excluido com sucesso!");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Falha na exclusão");
                    }
                }
                catch (SqlException erro)
                {
                    MessageBox.Show("Falha na execução " + erro);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
