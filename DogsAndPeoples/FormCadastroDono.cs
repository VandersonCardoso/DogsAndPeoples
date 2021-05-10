using Microsoft.VisualBasic;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DogsAndPeoples
{
    public partial class FormCadastroDono : Form
    {
        private readonly SqlConnection conexao;
        private bool inserindo;
        private bool editando;

        #region FormCadastroDono
        public FormCadastroDono()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["master"].ConnectionString);
            InitializeComponent();
            textBoxNome.Enabled = false;
            inserindo = false;
            editando = false;

            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        #endregion

        #region buttonNovo_Click
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            textBoxId.Text = string.Empty;
            textBoxNome.Enabled = true;
            inserindo = true;
            editando = false;
        }
        #endregion

        #region buttonSalvar_Click
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string sql;
            var command = new SqlCommand(); ;

            if (inserindo)
            {
                sql = "Insert into Donos(Nome) values(@Nome)";
                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textBoxNome.Text;
                command.Connection = conexao;
                command.CommandText = sql;
                command.ExecuteNonQuery();

                MessageBox.Show("Dono cadastrado com sucesso.");
            }
            else if (editando)
            {
                sql = "Update Donos set Nome = @Nome Where Id_Dono = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(textBoxId.Text);
                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textBoxNome.Text;
                command.Connection = conexao;
                command.CommandText = sql;
                command.ExecuteNonQuery();

                MessageBox.Show("Cadastro do dono atualizado com sucesso.");
            }
        }
        #endregion

        #region buttonEditar_Click
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Você deve consultar o registro primeiramente antes de editá-lo.");
                return;
            }

            textBoxNome.Enabled = true;
            inserindo = false;
            editando = true;
        }
        #endregion

        #region buttonExcluir_Click
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Você deve consultar o registro primeiramente antes de excluí-lo.");
                return;
            }

            string sql = "Delete from Donos Where Id_Dono = @Id";
            var command = new SqlCommand(sql, conexao);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(textBoxId.Text);
            command.ExecuteNonQuery();
            textBoxId.Text = string.Empty;
            textBoxNome.Text = string.Empty;

            MessageBox.Show("Dono excluído com sucesso.");
        }
        #endregion

        #region FormCadastroDono_FormClosed
        private void FormCadastroDono_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao.Close();
        }
        #endregion

        #region buttonConsultar_Click
        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            string nome = Interaction.InputBox("Informe o nome", "Consultar por Nome", string.Empty, -1, -1);

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Você deve informar um nome para realizar a consulta!");
                return;
            }
            else
            {
                string sql = "Select * from Donos Where Nome = @Nome";
                var command = new SqlCommand(sql, conexao);
                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nome;
                SqlDataReader dr = command.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    textBoxId.Text = Convert.ToString(dr["Id_Dono"]);
                    textBoxNome.Text = Convert.ToString(dr["Nome"]);
                }
                else
                {
                    MessageBox.Show("Dono não encontrado!");
                }

                dr.Close();
            }
        }
        #endregion
    }
}
