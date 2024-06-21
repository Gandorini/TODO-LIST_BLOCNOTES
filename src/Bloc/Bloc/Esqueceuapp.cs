using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloc
{
    public partial class Esqueceuapp : Form
    {
        private static string stringdeconecxao = "Server=(localdb)\\MSSQLLocalDB;Database=BlocDBB;Trusted_Connection=True;TrustServerCertificate=True;";
        private static SqlConnection db = new SqlConnection(stringdeconecxao);


        public string NomeUtilizador { get; set; }
        public string Password { get; set; }
        public Esqueceuapp()
        {
            InitializeComponent();
        }

        private void SendPasswordReset(string username, string newPassword)
        {

            NomeUtilizador = txtUsername.Text.Trim();
            Password = txtNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Por favor, preencha o nome de usuário e a nova senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(stringdeconecxao))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Utilizador SET PasswordHash = @NewPassword WHERE Username = @Username";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@NewPassword", newPassword);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Senha redefinida com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nome de usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Esqueceuapp_Load(object sender, EventArgs e)
        {

        }

        private void BtnSairEsqueceuPP_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
