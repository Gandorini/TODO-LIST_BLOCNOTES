using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Bloc
{
    public partial class FormAnotacoes : Form
    {

        private static string stringdeconecxao = "Server=(localdb)\\MSSQLLocalDB;Database=BlocDBB;Trusted_Connection=True;TrustServerCertificate=True;";
        private static SqlConnection db = new SqlConnection(stringdeconecxao);

        public FormAnotacoes()
        {
            InitializeComponent();

            txtAnotacoesTexto.Multiline = true;
            txtAnotacoesTexto.Width = 658;
            txtAnotacoesTexto.Height = 400;

            FormAnotacoes_Load(this, EventArgs.Empty);
        }


        private void FormAnotacoes_Load(object sender, EventArgs e)
        {

            cbCategorias.Items.Clear();

            string query = "SELECT CategoriaNome FROM Categorias";

            using (SqlConnection connection = new SqlConnection(stringdeconecxao))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string categoriaNome = reader.GetString(0);
                            cbCategorias.Items.Add(categoriaNome);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar categorias: {ex.Message}", "ERRO CATEGORIAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT a.NomeTXT, c.CategoriaNome, a.AnotacoesTxt 
        FROM Anotacoes a
        JOIN Categorias c ON a.CategoriaNome = c.CategoriaNome";

            using (SqlConnection db = new SqlConnection(stringdeconecxao))
            using (SqlCommand command = new SqlCommand(query, db))
            {
                try
                {
                    db.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nome = reader.GetString(0);
                            string categoria = reader.GetString(1);
                            string anotacao = reader.GetString(2);

                            MessageBox.Show($"Nome:\n {nome}\nCategoria:\n {categoria}\nAnotação:\n {anotacao}","Visualizar o seu Texto",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao visualizar as anotações: {ex.Message}", "ERRO VISUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeAnota.Clear();
            txtAnotacoesTexto.Clear();
            cbCategorias.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeAnotacao = txtNomeAnota.Text;
            string categoria = cbCategorias.SelectedItem as string;
            string anotacao = txtAnotacoesTexto.Text;

            if (string.IsNullOrWhiteSpace(nomeAnotacao) || string.IsNullOrWhiteSpace(categoria) || string.IsNullOrWhiteSpace(anotacao))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Anotacoes (NomeTXT, CategoriaNome, AnotacoesTxt) VALUES (@NomeTXT, @CategoriaNome, @AnotacoesTxt)";

            using (SqlConnection connection = new SqlConnection(stringdeconecxao))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NomeTXT", nomeAnotacao);
                    command.Parameters.AddWithValue("@CategoriaNome", categoria);
                    command.Parameters.AddWithValue("@AnotacoesTxt", anotacao);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Anotação salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar a anotação: {ex.Message}", "ERRO SALVAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private string TextodaAnotacao = string.Empty;
        private void txtAnotacoesTexto_TextChanged(object sender, EventArgs e)
        {
            if(txtAnotacoesTexto.Text != null)
            {
                TextodaAnotacao = txtAnotacoesTexto.Text;
            }
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategorias.SelectedItem != null)
            {
                string categoriaSelecionada = cbCategorias.SelectedItem.ToString();
            }
        }
    }
}



