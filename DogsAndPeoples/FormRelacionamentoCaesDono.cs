using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DogsAndPeoples
{
    public partial class FormRelacionamentoCaesDono : Form
    {
        private readonly SqlConnection conexao;

        #region FormRelacionamentoCaesDono
        public FormRelacionamentoCaesDono()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["master"].ConnectionString);
            InitializeComponent();

            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }

            CarregarComboDono();
            CarregarComboCao();
        }
        #endregion

        #region buttonCriarVinculo_Click
        private void buttonCriarVinculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboDono.DisplayMember) || string.IsNullOrEmpty(comboCao.DisplayMember))
            {
                MessageBox.Show("Você deve selecionar um dono e um cão para criar o vínculo!");
                return;
            }

            string sql = "Select Count(*) as Qtde From Caes_Dono Where Id_Cao = @Id_Cao";
            var command = new SqlCommand(sql, conexao);
            command.Parameters.Add("@Id_Cao", SqlDbType.Int).Value = int.Parse(comboCao.SelectedValue.ToString());
            bool caoJaVinculado = (int)command.ExecuteScalar() > 0;

            if (caoJaVinculado)
            {
                MessageBox.Show("O vínculo não pode ser realizado, pois este cão já está vinculado à este ou à outro dono!");
                return;
            }

            sql = "Insert into Caes_Dono(Id_Dono, Id_Cao) values(@Id_Dono, @Id_Cao)";
            command = new SqlCommand(sql, conexao);
            command.Parameters.Add("@Id_Dono", SqlDbType.Int).Value = int.Parse(comboDono.SelectedValue.ToString());
            command.Parameters.Add("@Id_Cao", SqlDbType.Int).Value = int.Parse(comboCao.SelectedValue.ToString());
            command.ExecuteNonQuery();

            MessageBox.Show("Vínculo criado com sucesso");
        }
        #endregion

        #region CarregarComboDono
        private void CarregarComboDono()
        {
            string sql = "Select Id_Dono, Nome From Donos";
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();
            da.Fill(ds, "Dono");
            comboDono.DisplayMember = "Nome";
            comboDono.ValueMember = "Id_Dono";
            comboDono.DataSource = ds.Tables["Dono"];
        }
        #endregion

        #region CarregarComboCao
        private void CarregarComboCao()
        {
            string sql = "Select Id_Cao, Nome From Caes";
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();
            da.Fill(ds, "Cao");
            comboCao.DisplayMember = "Nome";
            comboCao.ValueMember = "Id_Cao";
            comboCao.DataSource = ds.Tables["Cao"];
        }
        #endregion

        #region buttonExcluirVinculo_Click
        private void buttonExcluirVinculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboDono.DisplayMember) || string.IsNullOrEmpty(comboCao.DisplayMember))
            {
                MessageBox.Show("Você deve selecionar um dono e um cão para remover o vínculo!");
                return;
            }

            string sql = "Delete from Caes_Dono Where Id_Dono = @Id_Dono and Id_Cao = @Id_Cao";
            var command = new SqlCommand(sql, conexao);
            command.Parameters.Add("@Id_Dono", SqlDbType.Int).Value = int.Parse(comboDono.SelectedValue.ToString());
            command.Parameters.Add("@Id_Cao", SqlDbType.Int).Value = int.Parse(comboCao.SelectedValue.ToString());
            command.ExecuteNonQuery();

            MessageBox.Show("Vínculo excluído com sucesso");
        }
        #endregion
    }
}
