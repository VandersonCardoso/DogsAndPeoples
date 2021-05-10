using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DogsAndPeoples
{
    public partial class FormRelatorioCaesDonos : Form
    {
        private readonly SqlConnection conexao;

        #region FormRelatorioCaesDonos
        public FormRelatorioCaesDonos()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["master"].ConnectionString);
            InitializeComponent();

            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        #endregion

        #region buttonGerarRelatorio_Click
        private void buttonGerarRelatorio_Click(object sender, EventArgs e)
        {
            dataGridViewRelatorio.Rows.Clear();

            string sql = @"Select cd.Id_Cao, c.Nome as Nome_Cao, c.Raca, cd.Id_Dono, d.Nome as Nome_Dono
                           From Caes_Dono cd
                           Inner join Caes c on cd.Id_Cao = c.Id_Cao
                           Inner join Donos d on cd.Id_Dono = d.Id_Dono
                           Where c.Raca = @Raca";
            var command = new SqlCommand(sql, conexao);
            command.Parameters.Add("@Raca", SqlDbType.VarChar).Value = textBoxRaca.Text;
            SqlDataReader dr = command.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    object[] values = new object[dr.FieldCount];

                    if (dataGridViewRelatorio.Rows.Count == 0)
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            dataGridViewRelatorio.Columns.Add(dr.GetName(i), dr.GetName(i));
                        }
                    }

                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        values[i] = dr.GetValue(i);
                    }

                    dataGridViewRelatorio.Rows.Add(values);
                }
            }
            else
            {
                MessageBox.Show("Nenhum resultado encontrado para o filtro informado!");
            }

            dr.Close();
        }
        #endregion
    }
}
