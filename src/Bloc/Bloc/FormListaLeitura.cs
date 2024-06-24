using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloc
{
    public partial class FormListaLeitura : Form
    {

        private static string stringdeconecxao = "Server=(localdb)\\MSSQLLocalDB;Database=BlocDBB;Trusted_Connection=True;TrustServerCertificate=True;";
        private static SqlConnection db = new SqlConnection(stringdeconecxao);

        private int savedX;
        private int savedY;

        public FormListaLeitura()
        {
            InitializeComponent();
            FormListaLeitura_Load(this, EventArgs.Empty);
        }

        private void FormListaLeitura_Load(object sender, EventArgs e)
        {
            cbcategoriasLivros.Items.Clear();
            string query = "SELECT CategoriaNome FROM Categorias WHERE CategoriaTipo = 'GeneroLivro'";

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
                            cbcategoriasLivros.Items.Add(categoriaNome);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar categorias: {ex.Message}", "ERRO CATEGORIAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Location = new Point(savedX, savedY);
        }

        private void SaveFormPosition()
        {
            savedX = this.Location.X;
            savedY = this.Location.Y;
        }

        private void FormListaLeitura_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFormPosition();
        }

        private void cbcategoriasLivros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica quando a categoria selecionada muda
        }

        private void btnSalvarObra_Click(object sender, EventArgs e)
        {
            string nomeObra = TxtNomeObra.Text;
            string categoria = cbcategoriasLivros.SelectedItem as string;

            if (string.IsNullOrWhiteSpace(nomeObra) || string.IsNullOrWhiteSpace(categoria))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO ListaLeituraa (NomeObra, CategoriaNome) VALUES (@NomeObra, @CategoriaNome)";

            using (SqlConnection connection = new SqlConnection(stringdeconecxao))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NomeObra", nomeObra);
                    command.Parameters.AddWithValue("@CategoriaNome", categoria);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Obra salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao salvar a obra: {ex.Message}", "ERRO SALVAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
