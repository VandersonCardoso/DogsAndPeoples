
namespace DogsAndPeoples
{
    partial class FormRelacionamentoCaesDono
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
            this.comboDono = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCao = new System.Windows.Forms.ComboBox();
            this.buttonCriarVinculo = new System.Windows.Forms.Button();
            this.buttonExcluirVinculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboDono
            // 
            this.comboDono.FormattingEnabled = true;
            this.comboDono.Location = new System.Drawing.Point(12, 38);
            this.comboDono.Name = "comboDono";
            this.comboDono.Size = new System.Drawing.Size(246, 21);
            this.comboDono.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cão";
            // 
            // comboCao
            // 
            this.comboCao.FormattingEnabled = true;
            this.comboCao.Location = new System.Drawing.Point(12, 89);
            this.comboCao.Name = "comboCao";
            this.comboCao.Size = new System.Drawing.Size(246, 21);
            this.comboCao.TabIndex = 3;
            // 
            // buttonCriarVinculo
            // 
            this.buttonCriarVinculo.Location = new System.Drawing.Point(12, 129);
            this.buttonCriarVinculo.Name = "buttonCriarVinculo";
            this.buttonCriarVinculo.Size = new System.Drawing.Size(117, 23);
            this.buttonCriarVinculo.TabIndex = 4;
            this.buttonCriarVinculo.Text = "&Criar Vínculo";
            this.buttonCriarVinculo.UseVisualStyleBackColor = true;
            this.buttonCriarVinculo.Click += new System.EventHandler(this.buttonCriarVinculo_Click);
            // 
            // buttonExcluirVinculo
            // 
            this.buttonExcluirVinculo.Location = new System.Drawing.Point(141, 129);
            this.buttonExcluirVinculo.Name = "buttonExcluirVinculo";
            this.buttonExcluirVinculo.Size = new System.Drawing.Size(117, 23);
            this.buttonExcluirVinculo.TabIndex = 5;
            this.buttonExcluirVinculo.Text = "&Excluir Vínculo";
            this.buttonExcluirVinculo.UseVisualStyleBackColor = true;
            this.buttonExcluirVinculo.Click += new System.EventHandler(this.buttonExcluirVinculo_Click);
            // 
            // FormRelacionamentoCaesDono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 176);
            this.Controls.Add(this.buttonExcluirVinculo);
            this.Controls.Add(this.buttonCriarVinculo);
            this.Controls.Add(this.comboCao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDono);
            this.Name = "FormRelacionamentoCaesDono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relacionamento de Cães e Donos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboDono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCao;
        private System.Windows.Forms.Button buttonCriarVinculo;
        private System.Windows.Forms.Button buttonExcluirVinculo;
    }
}