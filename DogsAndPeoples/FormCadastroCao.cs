using Microsoft.VisualBasic;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DogsAndPeoples
{
    public partial class FormCadastroCao : Form
    {
        private readonly SqlConnection conexao;
        private bool inserindo;
        private bool editando;

        #region FormCadastroCao
        public FormCadastroCao()
        {
            //Inicializa os componentes, conexão com o banco e textboxes desabilitados, obrigando o usuário a realizar alguma ação através dos botões
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["master"].ConnectionString);
            InitializeComponent();
            textBoxNome.Enabled = false;
            textBoxRaca.Enabled = false;
            inserindo = false;
            editando = false;

            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        #endregion

        #region FormCadastroCao_FormClosed
        private void FormCadastroCao_FormClosed(object sender, FormClosedEventArgs e)
        {
            //encerra a conexão com o banco
            conexao.Close();
        }
        #endregion

        #region buttonNovo_Click
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            //Realiza a inclusão de um cão, habilitando somente os textboxes necessários
            textBoxId.Text = string.Empty;
            textBoxNome.Enabled = true;
            textBoxRaca.Enabled = true;
            inserindo = true;
            editando = false;
        }
        #endregion

        #region buttonConsultar_Click
        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            //Apresenta um inputBox para inclusão do nome para realização da consulta
            string nome = Interaction.InputBox("Informe o nome", "Consultar por Nome", string.Empty, -1, -1);

            //Valida se foi informado algum nome antes de realizar a consulta no banco
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Você deve informar um nome para realizar a consulta!");
                return;
            }
            else
            {
                string sql = "Select * from Caes Where Nome = @Nome";
                var command = new SqlCommand(sql, conexao);
                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nome;
                SqlDataReader dr = command.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    textBoxId.Text = Convert.ToString(dr["Id_Cao"]);
                    textBoxNome.Text = Convert.ToString(dr["Nome"]);
                    textBoxRaca.Text = Convert.ToString(dr["Raca"]);
                }
                else
                {
                    MessageBox.Show("Cão não encontrado!");
                }

                dr.Close();
            }
        }
        #endregion

        #region buttonEditar_Click
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Valida se existe um Id correspondente ao registro para realizar a edição do mesmo
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Você deve consultar o registro primeiramente antes de editá-lo.");
                return;
            }

            textBoxNome.Enabled = true;
            textBoxRaca.Enabled = true;
            inserindo = false;
            editando = true;
        }
        #endregion

        #region buttonExcluir_Click
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //Valida se existe um Id correspondente ao registro para realizar a edição do mesmo
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Você deve consultar o registro primeiramente antes de excluí-lo.");
                return;
            }

            string sql = "Delete from Caes Where Id_Cao = @Id";
            var command = new SqlCommand(sql, conexao);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(textBoxId.Text);
            command.ExecuteNonQuery();

            MessageBox.Show("Cão excluído com sucesso.");
        }
        #endregion

        #region buttonSalvar_Click
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string sql;
            var command = new SqlCommand(); ;

            //Valida se o registro está sendo inserido/editado para utilizar o comando SQL correspondente
            if (inserindo)
            {
                sql = "Insert into Caes(Nome, Raca) values(@Nome, @Raca)";
                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textBoxNome.Text;
                command.Parameters.Add("@Raca", SqlDbType.VarChar).Value = textBoxRaca.Text;
                command.Connection = conexao;
                command.CommandText = sql;
                command.ExecuteNonQuery();

                MessageBox.Show("Cão cadastrado com sucesso.");
            }
            else if (editando)
            {
                sql = "Update Caes set Nome = @Nome, Raca = @Raca Where Id_Cao = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = int.Parse(textBoxId.Text);
                command.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textBoxNome.Text;
                command.Parameters.Add("@Raca", SqlDbType.VarChar).Value = textBoxRaca.Text;
                command.Connection = conexao;
                command.CommandText = sql;
                command.ExecuteNonQuery();

                MessageBox.Show("Cadastro do cão atualizado com sucesso.");
            }
        }
        #endregion
    }
}
