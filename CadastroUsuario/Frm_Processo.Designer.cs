namespace CadastroUsuario
{
    partial class Frm_Processo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_BemVindo = new System.Windows.Forms.Label();
            this.Grd_Processos = new System.Windows.Forms.DataGridView();
            this.Txt_Status = new System.Windows.Forms.TextBox();
            this.Txt_Numero = new System.Windows.Forms.TextBox();
            this.Txt_Rua = new System.Windows.Forms.TextBox();
            this.Txt_Cep = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_Nascimento = new System.Windows.Forms.TextBox();
            this.Txt_Rg = new System.Windows.Forms.TextBox();
            this.Txt_Cpf = new System.Windows.Forms.TextBox();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Txt_Sexo = new System.Windows.Forms.TextBox();
            this.Txt_Celular = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Txt_Complemento = new System.Windows.Forms.TextBox();
            this.LbL_ID_Status = new System.Windows.Forms.Label();
            this.Lbl_Complemento = new System.Windows.Forms.Label();
            this.Lbl_Rua = new System.Windows.Forms.Label();
            this.Lbl_Cep = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Lbl_Nascimento = new System.Windows.Forms.Label();
            this.Lbl_Rg = new System.Windows.Forms.Label();
            this.Lbl_Cpf = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_ID_Cidade = new System.Windows.Forms.Label();
            this.Lbl_Sexo = new System.Windows.Forms.Label();
            this.Lbl_Celular = new System.Windows.Forms.Label();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_Numero = new System.Windows.Forms.Label();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Excluir = new System.Windows.Forms.Button();
            this.Lbl_Excluir = new System.Windows.Forms.Label();
            this.Txt_Excluir = new System.Windows.Forms.TextBox();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.Txt_Nome_Usuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Processos)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_BemVindo
            // 
            this.Lbl_BemVindo.AutoSize = true;
            this.Lbl_BemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Lbl_BemVindo.Location = new System.Drawing.Point(12, 9);
            this.Lbl_BemVindo.Name = "Lbl_BemVindo";
            this.Lbl_BemVindo.Size = new System.Drawing.Size(99, 22);
            this.Lbl_BemVindo.TabIndex = 1;
            this.Lbl_BemVindo.Text = "Bem vindo,";
            // 
            // Grd_Processos
            // 
            this.Grd_Processos.AllowUserToAddRows = false;
            this.Grd_Processos.AllowUserToDeleteRows = false;
            this.Grd_Processos.AllowUserToResizeColumns = false;
            this.Grd_Processos.AllowUserToResizeRows = false;
            this.Grd_Processos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Processos.Location = new System.Drawing.Point(12, 466);
            this.Grd_Processos.Name = "Grd_Processos";
            this.Grd_Processos.ReadOnly = true;
            this.Grd_Processos.Size = new System.Drawing.Size(1185, 189);
            this.Grd_Processos.TabIndex = 19;
            this.Grd_Processos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_Processos_CellClick);
            // 
            // Txt_Status
            // 
            this.Txt_Status.Location = new System.Drawing.Point(144, 110);
            this.Txt_Status.Name = "Txt_Status";
            this.Txt_Status.Size = new System.Drawing.Size(100, 20);
            this.Txt_Status.TabIndex = 0;
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.Location = new System.Drawing.Point(398, 306);
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Size = new System.Drawing.Size(100, 20);
            this.Txt_Numero.TabIndex = 9;
            // 
            // Txt_Rua
            // 
            this.Txt_Rua.Location = new System.Drawing.Point(398, 254);
            this.Txt_Rua.Name = "Txt_Rua";
            this.Txt_Rua.Size = new System.Drawing.Size(100, 20);
            this.Txt_Rua.TabIndex = 8;
            // 
            // Txt_Cep
            // 
            this.Txt_Cep.Location = new System.Drawing.Point(398, 204);
            this.Txt_Cep.Name = "Txt_Cep";
            this.Txt_Cep.Size = new System.Drawing.Size(100, 20);
            this.Txt_Cep.TabIndex = 7;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(398, 155);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(100, 20);
            this.Txt_Email.TabIndex = 6;
            // 
            // Txt_Nascimento
            // 
            this.Txt_Nascimento.Location = new System.Drawing.Point(398, 110);
            this.Txt_Nascimento.Name = "Txt_Nascimento";
            this.Txt_Nascimento.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nascimento.TabIndex = 5;
            // 
            // Txt_Rg
            // 
            this.Txt_Rg.Location = new System.Drawing.Point(144, 306);
            this.Txt_Rg.Name = "Txt_Rg";
            this.Txt_Rg.Size = new System.Drawing.Size(100, 20);
            this.Txt_Rg.TabIndex = 4;
            // 
            // Txt_Cpf
            // 
            this.Txt_Cpf.Location = new System.Drawing.Point(144, 254);
            this.Txt_Cpf.Name = "Txt_Cpf";
            this.Txt_Cpf.Size = new System.Drawing.Size(100, 20);
            this.Txt_Cpf.TabIndex = 3;
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(144, 204);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nome.TabIndex = 2;
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(144, 155);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(100, 20);
            this.Txt_Cidade.TabIndex = 1;
            // 
            // Txt_Sexo
            // 
            this.Txt_Sexo.Location = new System.Drawing.Point(638, 254);
            this.Txt_Sexo.Name = "Txt_Sexo";
            this.Txt_Sexo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Sexo.TabIndex = 13;
            // 
            // Txt_Celular
            // 
            this.Txt_Celular.Location = new System.Drawing.Point(638, 204);
            this.Txt_Celular.Name = "Txt_Celular";
            this.Txt_Celular.Size = new System.Drawing.Size(100, 20);
            this.Txt_Celular.TabIndex = 12;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(638, 155);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(100, 20);
            this.Txt_Bairro.TabIndex = 11;
            // 
            // Txt_Complemento
            // 
            this.Txt_Complemento.Location = new System.Drawing.Point(638, 110);
            this.Txt_Complemento.Name = "Txt_Complemento";
            this.Txt_Complemento.Size = new System.Drawing.Size(100, 20);
            this.Txt_Complemento.TabIndex = 10;
            // 
            // LbL_ID_Status
            // 
            this.LbL_ID_Status.AutoSize = true;
            this.LbL_ID_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LbL_ID_Status.Location = new System.Drawing.Point(13, 109);
            this.LbL_ID_Status.Name = "LbL_ID_Status";
            this.LbL_ID_Status.Size = new System.Drawing.Size(73, 17);
            this.LbL_ID_Status.TabIndex = 18;
            this.LbL_ID_Status.Text = "ID_Status:";
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Complemento.Location = new System.Drawing.Point(520, 113);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(98, 17);
            this.Lbl_Complemento.TabIndex = 32;
            this.Lbl_Complemento.Text = "Complemento:";
            // 
            // Lbl_Rua
            // 
            this.Lbl_Rua.AutoSize = true;
            this.Lbl_Rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Rua.Location = new System.Drawing.Point(277, 258);
            this.Lbl_Rua.Name = "Lbl_Rua";
            this.Lbl_Rua.Size = new System.Drawing.Size(38, 17);
            this.Lbl_Rua.TabIndex = 33;
            this.Lbl_Rua.Text = "Rua:";
            // 
            // Lbl_Cep
            // 
            this.Lbl_Cep.AutoSize = true;
            this.Lbl_Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Cep.Location = new System.Drawing.Point(277, 208);
            this.Lbl_Cep.Name = "Lbl_Cep";
            this.Lbl_Cep.Size = new System.Drawing.Size(39, 17);
            this.Lbl_Cep.TabIndex = 34;
            this.Lbl_Cep.Text = "CEP:";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Email.Location = new System.Drawing.Point(277, 156);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(42, 17);
            this.Lbl_Email.TabIndex = 35;
            this.Lbl_Email.Text = "Email";
            // 
            // Lbl_Nascimento
            // 
            this.Lbl_Nascimento.AutoSize = true;
            this.Lbl_Nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Nascimento.Location = new System.Drawing.Point(277, 109);
            this.Lbl_Nascimento.Name = "Lbl_Nascimento";
            this.Lbl_Nascimento.Size = new System.Drawing.Size(86, 17);
            this.Lbl_Nascimento.TabIndex = 36;
            this.Lbl_Nascimento.Text = "Nascimento:";
            // 
            // Lbl_Rg
            // 
            this.Lbl_Rg.AutoSize = true;
            this.Lbl_Rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Rg.Location = new System.Drawing.Point(12, 309);
            this.Lbl_Rg.Name = "Lbl_Rg";
            this.Lbl_Rg.Size = new System.Drawing.Size(33, 17);
            this.Lbl_Rg.TabIndex = 37;
            this.Lbl_Rg.Text = "RG:";
            // 
            // Lbl_Cpf
            // 
            this.Lbl_Cpf.AutoSize = true;
            this.Lbl_Cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Cpf.Location = new System.Drawing.Point(12, 253);
            this.Lbl_Cpf.Name = "Lbl_Cpf";
            this.Lbl_Cpf.Size = new System.Drawing.Size(38, 17);
            this.Lbl_Cpf.TabIndex = 39;
            this.Lbl_Cpf.Text = "CPF:";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Nome.Location = new System.Drawing.Point(13, 203);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(49, 17);
            this.Lbl_Nome.TabIndex = 40;
            this.Lbl_Nome.Text = "Nome:";
            // 
            // Lbl_ID_Cidade
            // 
            this.Lbl_ID_Cidade.AutoSize = true;
            this.Lbl_ID_Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_ID_Cidade.Location = new System.Drawing.Point(12, 155);
            this.Lbl_ID_Cidade.Name = "Lbl_ID_Cidade";
            this.Lbl_ID_Cidade.Size = new System.Drawing.Size(77, 17);
            this.Lbl_ID_Cidade.TabIndex = 41;
            this.Lbl_ID_Cidade.Text = "ID_Cidade:";
            // 
            // Lbl_Sexo
            // 
            this.Lbl_Sexo.AutoSize = true;
            this.Lbl_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Sexo.Location = new System.Drawing.Point(535, 257);
            this.Lbl_Sexo.Name = "Lbl_Sexo";
            this.Lbl_Sexo.Size = new System.Drawing.Size(43, 17);
            this.Lbl_Sexo.TabIndex = 42;
            this.Lbl_Sexo.Text = "Sexo:";
            // 
            // Lbl_Celular
            // 
            this.Lbl_Celular.AutoSize = true;
            this.Lbl_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Celular.Location = new System.Drawing.Point(535, 207);
            this.Lbl_Celular.Name = "Lbl_Celular";
            this.Lbl_Celular.Size = new System.Drawing.Size(56, 17);
            this.Lbl_Celular.TabIndex = 43;
            this.Lbl_Celular.Text = "Celular:";
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Bairro.Location = new System.Drawing.Point(535, 156);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(50, 17);
            this.Lbl_Bairro.TabIndex = 44;
            this.Lbl_Bairro.Text = "Bairro:";
            // 
            // Lbl_Numero
            // 
            this.Lbl_Numero.AutoSize = true;
            this.Lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Numero.Location = new System.Drawing.Point(277, 306);
            this.Lbl_Numero.Name = "Lbl_Numero";
            this.Lbl_Numero.Size = new System.Drawing.Size(62, 17);
            this.Lbl_Numero.TabIndex = 45;
            this.Lbl_Numero.Text = "Número:";
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.Silver;
            this.Btn_Sair.Location = new System.Drawing.Point(194, 12);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(71, 22);
            this.Btn_Sair.TabIndex = 14;
            this.Btn_Sair.Text = "Sair";
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Lbl_Usuario.Location = new System.Drawing.Point(105, 9);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(0, 22);
            this.Lbl_Usuario.TabIndex = 4;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Salvar.Location = new System.Drawing.Point(892, 174);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(100, 30);
            this.Btn_Salvar.TabIndex = 16;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Excluir
            // 
            this.Btn_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Excluir.Location = new System.Drawing.Point(892, 306);
            this.Btn_Excluir.Name = "Btn_Excluir";
            this.Btn_Excluir.Size = new System.Drawing.Size(100, 30);
            this.Btn_Excluir.TabIndex = 18;
            this.Btn_Excluir.Text = "Excluir";
            this.Btn_Excluir.UseVisualStyleBackColor = false;
            this.Btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // Lbl_Excluir
            // 
            this.Lbl_Excluir.AutoSize = true;
            this.Lbl_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lbl_Excluir.Location = new System.Drawing.Point(823, 315);
            this.Lbl_Excluir.Name = "Lbl_Excluir";
            this.Lbl_Excluir.Size = new System.Drawing.Size(25, 17);
            this.Lbl_Excluir.TabIndex = 52;
            this.Lbl_Excluir.Text = "ID:";
            // 
            // Txt_Excluir
            // 
            this.Txt_Excluir.Location = new System.Drawing.Point(854, 312);
            this.Txt_Excluir.Name = "Txt_Excluir";
            this.Txt_Excluir.Size = new System.Drawing.Size(32, 20);
            this.Txt_Excluir.TabIndex = 20;
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Novo.Location = new System.Drawing.Point(892, 109);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(100, 30);
            this.Btn_Novo.TabIndex = 15;
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.UseVisualStyleBackColor = false;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Atualizar.Location = new System.Drawing.Point(892, 240);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(100, 30);
            this.Btn_Atualizar.TabIndex = 17;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = false;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // Txt_Nome_Usuario
            // 
            this.Txt_Nome_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nome_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome_Usuario.Location = new System.Drawing.Point(111, 12);
            this.Txt_Nome_Usuario.Name = "Txt_Nome_Usuario";
            this.Txt_Nome_Usuario.ReadOnly = true;
            this.Txt_Nome_Usuario.Size = new System.Drawing.Size(77, 20);
            this.Txt_Nome_Usuario.TabIndex = 53;
            // 
            // Frm_Processo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 667);
            this.Controls.Add(this.Txt_Nome_Usuario);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.Btn_Novo);
            this.Controls.Add(this.Lbl_Excluir);
            this.Controls.Add(this.Txt_Excluir);
            this.Controls.Add(this.Btn_Excluir);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Lbl_Numero);
            this.Controls.Add(this.Lbl_Bairro);
            this.Controls.Add(this.Lbl_Celular);
            this.Controls.Add(this.Lbl_Sexo);
            this.Controls.Add(this.Lbl_ID_Cidade);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Lbl_Cpf);
            this.Controls.Add(this.Lbl_Rg);
            this.Controls.Add(this.Lbl_Nascimento);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Lbl_Cep);
            this.Controls.Add(this.Lbl_Rua);
            this.Controls.Add(this.Lbl_Complemento);
            this.Controls.Add(this.LbL_ID_Status);
            this.Controls.Add(this.Txt_Complemento);
            this.Controls.Add(this.Txt_Bairro);
            this.Controls.Add(this.Txt_Celular);
            this.Controls.Add(this.Txt_Sexo);
            this.Controls.Add(this.Txt_Cidade);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Txt_Cpf);
            this.Controls.Add(this.Txt_Rg);
            this.Controls.Add(this.Txt_Nascimento);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Txt_Cep);
            this.Controls.Add(this.Txt_Rua);
            this.Controls.Add(this.Txt_Numero);
            this.Controls.Add(this.Txt_Status);
            this.Controls.Add(this.Grd_Processos);
            this.Controls.Add(this.Lbl_BemVindo);
            this.Name = "Frm_Processo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Processo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Processos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_BemVindo;
        private System.Windows.Forms.DataGridView Grd_Processos;
        private System.Windows.Forms.TextBox Txt_Status;
        private System.Windows.Forms.TextBox Txt_Numero;
        private System.Windows.Forms.TextBox Txt_Rua;
        private System.Windows.Forms.TextBox Txt_Cep;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_Nascimento;
        private System.Windows.Forms.TextBox Txt_Rg;
        private System.Windows.Forms.TextBox Txt_Cpf;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.TextBox Txt_Sexo;
        private System.Windows.Forms.TextBox Txt_Celular;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.TextBox Txt_Complemento;
        private System.Windows.Forms.Label LbL_ID_Status;
        private System.Windows.Forms.Label Lbl_Complemento;
        private System.Windows.Forms.Label Lbl_Rua;
        private System.Windows.Forms.Label Lbl_Cep;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Label Lbl_Nascimento;
        private System.Windows.Forms.Label Lbl_Rg;
        private System.Windows.Forms.Label Lbl_Cpf;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_ID_Cidade;
        private System.Windows.Forms.Label Lbl_Sexo;
        private System.Windows.Forms.Label Lbl_Celular;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.Label Lbl_Numero;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Excluir;
        private System.Windows.Forms.Label Lbl_Excluir;
        private System.Windows.Forms.TextBox Txt_Excluir;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_Atualizar;
        private System.Windows.Forms.TextBox Txt_Nome_Usuario;
    }
}