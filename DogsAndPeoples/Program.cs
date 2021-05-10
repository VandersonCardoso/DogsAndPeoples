using DogsAndPeoples.Properties;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DogsAndPeoples
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// Utilizado SqlConnection e SqlCommand para conexão/iteração com o banco
        /// Utilizados componentes como Label, TextBox, Button e ComboBox nos cadastros
        /// Utilizada classe interaction para apresentar inputBox nos botões de consulta
        /// Utilizado dataGridView na tela de relatório
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CriarEstruturaBancoDeDados();
            Application.Run(new FormTelaPrincipal());
        }

        #region Criar camada de banco de dados
        private static void CriarEstruturaBancoDeDados()
        {
            bool existeTabela = false;

            using (var conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["master"].ConnectionString))
            {
                //verifica se a conexão está fechada
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }

                //Executa scripts vinculados ao projeto para criar a estrutura do banco de dados
                var command = new SqlCommand("select case when exists((select * from information_schema.tables where table_name = 'Donos')) then 1 else 0 end", conexao);
                existeTabela = (int)command.ExecuteScalar() == 1;

                if (!existeTabela)
                {
                    command = new SqlCommand(Resources.Donos, conexao);
                    command.ExecuteNonQuery();
                }

                command = new SqlCommand("select case when exists((select * from information_schema.tables where table_name = 'Caes')) then 1 else 0 end", conexao);
                existeTabela = (int)command.ExecuteScalar() == 1;

                if (!existeTabela)
                {
                    command = new SqlCommand(Resources.Caes, conexao);
                    command.ExecuteNonQuery();
                }

                command = new SqlCommand("select case when exists((select * from information_schema.tables where table_name = 'Caes_Dono')) then 1 else 0 end", conexao);
                existeTabela = (int)command.ExecuteScalar() == 1;

                if (!existeTabela)
                {
                    command = new SqlCommand(Resources.Caes_Dono, conexao);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
