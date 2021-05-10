
namespace DogsAndPeoples
{
    partial class FormCadastroCao
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxRaca = new System.Windows.Forms.TextBox();
            this.labelRaca = new System.Windows.Forms.Label();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 107);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(446, 20);
            this.textBoxNome.TabIndex = 7;
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(12, 65);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 6;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 91);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "Nome";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(9, 48);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "Id";
            // 
            // textBoxRaca
            // 
            this.textBoxRaca.Location = new System.Drawing.Point(12, 151);
            this.textBoxRaca.Name = "textBoxRaca";
            this.textBoxRaca.Size = new System.Drawing.Size(206, 20);
            this.textBoxRaca.TabIndex = 9;
            // 
            // labelRaca
            // 
            this.labelRaca.AutoSize = true;
            this.labelRaca.Location = new System.Drawing.Point(9, 135);
            this.labelRaca.Name = "labelRaca";
            this.labelRaca.Size = new System.Drawing.Size(33, 13);
            this.labelRaca.TabIndex = 8;
            this.labelRaca.Text = "Raça";
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(12, 12);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(75, 23);
            this.buttonNovo.TabIndex = 10;
            this.buttonNovo.Text = "&Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(93, 12);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 11;
            this.buttonConsultar.Text = "&Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(174, 12);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 12;
            this.buttonEditar.Text = "&Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(255, 12);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 13;
            this.buttonExcluir.Text = "E&xcluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(336, 12);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // FormCadastroCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 193);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.textBoxRaca);
            this.Controls.Add(this.labelRaca);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelId);
            this.Name = "FormCadastroCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cão";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCadastroCao_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxRaca;
        private System.Windows.Forms.Label labelRaca;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonSalvar;
    }
}