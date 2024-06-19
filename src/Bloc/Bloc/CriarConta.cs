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
        private static string stringconexao = "Server=(localdb)\\MSSQLLocalDB;Database=BlocDBB;Trusted_Connection=True;TrustServerCertificate=True";
        private SqlConnection connection = new SqlConnection(stringconexao);

        public string NomeUtilizador { get; set; }
        public string Password { get; set; }

        public CriarConta()
        {
            InitializeComponent();
        }

        private void CriarConta_Load(object sender, EventArgs e)
        {
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            NomeUtilizador = txtNomeCriar.Text.Trim();
            Password = txtPalavraPasseCriar.Text.Trim();

            if (string.IsNullOrEmpty(NomeUtilizador) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Por favor, preencha o nome de utilizador e a palavra-passe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (NovoUtilizador(NomeUtilizador, Password))
                {
                    MessageBox.Show("Conta criada com sucesso!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao criar a conta. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar a conta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir usuário no banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void BtnSairCriarConta_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}

