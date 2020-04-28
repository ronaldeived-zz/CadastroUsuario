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
    }
}
