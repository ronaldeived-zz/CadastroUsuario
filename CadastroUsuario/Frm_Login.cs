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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=BRPC003828;Initial Catalog=CADASTRO_USUARIO;Persist Security Info=True;User ID=sa;Password=Gftbr!2020");
            string query = @"Select * from USUARIO U
                INNER JOIN USUARIO_PERFIL UP ON UP.ID_USUARIO = U.ID_USUARIO 
                WHERE LOGIN= '"+ Txt_Usuario.Text +"' AND SENHA = '"+ Txt_Senha.Text +"' AND ID_PERFIL = 3";
            SqlDataAdapter db = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            db.Fill(dt);
            try
            {
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    new Frm_Processo().Show();
                }
                else
                {
                    MessageBox.Show("Login ou Senha incorreto!");
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
