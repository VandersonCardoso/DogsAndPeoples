
namespace DogsAndPeoples
{
    partial class FormRelatorioCaesDonos
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRaca = new System.Windows.Forms.TextBox();
            this.buttonGerarRelatorio = new System.Windows.Forms.Button();
            this.dataGridViewRelatorio = new System.Windows.Forms.DataGridView();
            this.Id_Cao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Cao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Dono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Dono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raça: ";
            // 
            // textBoxRaca
            // 
            this.textBoxRaca.Location = new System.Drawing.Point(56, 16);
            this.textBoxRaca.Name = "textBoxRaca";
            this.textBoxRaca.Size = new System.Drawing.Size(214, 20);
            this.textBoxRaca.TabIndex = 1;
            // 
            // buttonGerarRelatorio
            // 
            this.buttonGerarRelatorio.Location = new System.Drawing.Point(287, 14);
            this.buttonGerarRelatorio.Name = "buttonGerarRelatorio";
            this.buttonGerarRelatorio.Size = new System.Drawing.Size(106, 23);
            this.buttonGerarRelatorio.TabIndex = 2;
            this.buttonGerarRelatorio.Text = "&Gerar Relatório";
            this.buttonGerarRelatorio.UseVisualStyleBackColor = true;
            this.buttonGerarRelatorio.Click += new System.EventHandler(this.buttonGerarRelatorio_Click);
            // 
            // dataGridViewRelatorio
            // 
            this.dataGridViewRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cao,
            this.Nome_Cao,
            this.Raca,
            this.Id_Dono,
            this.Nome_Dono});
            this.dataGridViewRelatorio.Location = new System.Drawing.Point(14, 43);
            this.dataGridViewRelatorio.Name = "dataGridViewRelatorio";
            this.dataGridViewRelatorio.ReadOnly = true;
            this.dataGridViewRelatorio.Size = new System.Drawing.Size(760, 395);
            this.dataGridViewRelatorio.TabIndex = 3;
            // 
            // Id_Cao
            // 
            this.Id_Cao.DataPropertyName = "Id_Cao";
            this.Id_Cao.HeaderText = "Id Cão";
            this.Id_Cao.Name = "Id_Cao";
            // 
            // Nome_Cao
            // 
            this.Nome_Cao.DataPropertyName = "Nome_Cao";
            this.Nome_Cao.HeaderText = "Nome do Cão";
            this.Nome_Cao.Name = "Nome_Cao";
            // 
            // Raca
            // 
            this.Raca.DataPropertyName = "Raca";
            this.Raca.HeaderText = "Raça";
            this.Raca.Name = "Raca";
            // 
            // Id_Dono
            // 
            this.Id_Dono.DataPropertyName = "Id_Dono";
            this.Id_Dono.HeaderText = "Id Dono";
            this.Id_Dono.Name = "Id_Dono";
            // 
            // Nome_Dono
            // 
            this.Nome_Dono.DataPropertyName = "Nome_Dono";
            this.Nome_Dono.HeaderText = "Nome do Dono";
            this.Nome_Dono.Name = "Nome_Dono";
            // 
            // FormRelatorioCaesDonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRelatorio);
            this.Controls.Add(this.buttonGerarRelatorio);
            this.Controls.Add(this.textBoxRaca);
            this.Controls.Add(this.label1);
            this.Name = "FormRelatorioCaesDonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Cães e Donos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRaca;
        private System.Windows.Forms.Button buttonGerarRelatorio;
        private System.Windows.Forms.DataGridView dataGridViewRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Cao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Dono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Dono;
    }
}