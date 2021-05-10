using System;
using System.Windows.Forms;

namespace DogsAndPeoples
{
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {
            InitializeComponent();
        }

        #region donoToolStripMenuItem_Click
        private void donoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroDono cadDono = new FormCadastroDono();
            cadDono.ShowDialog();
        }
        #endregion

        #region cãoToolStripMenuItem_Click
        private void cãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCao cadCao = new FormCadastroCao();
            cadCao.ShowDialog();
        }
        #endregion

        #region relacionamentoToolStripMenuItem_Click
        private void relacionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelacionamentoCaesDono relacionamentoCaesDono = new FormRelacionamentoCaesDono();
            relacionamentoCaesDono.ShowDialog();
        }
        #endregion

        #region caesEDonosToolStripMenuItem_Click
        private void caesEDonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioCaesDonos formRelatorioCaesDonos = new FormRelatorioCaesDonos();
            formRelatorioCaesDonos.ShowDialog();
        }
        #endregion
    }
}
