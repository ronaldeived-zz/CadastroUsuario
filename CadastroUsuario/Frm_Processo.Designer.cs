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
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Lbl_Usuario.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(171, 22);
            this.Lbl_Usuario.TabIndex = 0;
            this.Lbl_Usuario.Text = "Bem vindo, Usuario!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 466);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1185, 189);
            this.dataGridView1.TabIndex = 1;
            // 
            // Frm_Processo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 667);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lbl_Usuario);
            this.Name = "Frm_Processo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processo";
            this.Load += new System.EventHandler(this.Processo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}