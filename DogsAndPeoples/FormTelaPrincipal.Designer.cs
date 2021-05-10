
namespace DogsAndPeoples
{
    partial class FormTelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relacionamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caesEDonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donoToolStripMenuItem,
            this.cãoToolStripMenuItem,
            this.relacionamentoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // donoToolStripMenuItem
            // 
            this.donoToolStripMenuItem.Name = "donoToolStripMenuItem";
            this.donoToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.donoToolStripMenuItem.Text = "Dono";
            this.donoToolStripMenuItem.Click += new System.EventHandler(this.donoToolStripMenuItem_Click);
            // 
            // cãoToolStripMenuItem
            // 
            this.cãoToolStripMenuItem.Name = "cãoToolStripMenuItem";
            this.cãoToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.cãoToolStripMenuItem.Text = "Cão";
            this.cãoToolStripMenuItem.Click += new System.EventHandler(this.cãoToolStripMenuItem_Click);
            // 
            // relacionamentoToolStripMenuItem
            // 
            this.relacionamentoToolStripMenuItem.Name = "relacionamentoToolStripMenuItem";
            this.relacionamentoToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.relacionamentoToolStripMenuItem.Text = "Relacionamento de Cães e Donos";
            this.relacionamentoToolStripMenuItem.Click += new System.EventHandler(this.relacionamentoToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caesEDonosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // caesEDonosToolStripMenuItem
            // 
            this.caesEDonosToolStripMenuItem.Name = "caesEDonosToolStripMenuItem";
            this.caesEDonosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.caesEDonosToolStripMenuItem.Text = "Cães e Donos";
            this.caesEDonosToolStripMenuItem.Click += new System.EventHandler(this.caesEDonosToolStripMenuItem_Click);
            // 
            // FormTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caesEDonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relacionamentoToolStripMenuItem;
    }
}

