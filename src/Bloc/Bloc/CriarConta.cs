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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bloc
{
    public partial class CriarConta : Form
    {
        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=BlocDB_2222123;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        public CriarConta()
        {
            InitializeComponent();
        }

        private void CriarConta_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string NovoUtil = txtNomeCriar.Text;
            string NovaPasse = txtPalavraPasseCriar.Text;

            if (string.IsNullOrEmpty(NovoUtil) || string.IsNullOrEmpty(NovaPasse))
            {
                MessageBox.Show("Por favor, preencha o nome de utilizador e a palavra-passe.");
                return;
            }

            // Inserir novo utilizador na tabela Utilizador
            if (NovoUtilizador(NovoUtil, NovaPasse))
            {
                MessageBox.Show("Conta criada com sucesso!");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Erro ao criar a conta. Por favor, tente novamente.");
            }
        }

        private bool NovoUtilizador(string username, string password)
        {
            string query = "INSERT INTO Utilizador (Username, PasswordHash) VALUES (@Username, @PasswordHash)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@PasswordHash", password); 

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }
    }

