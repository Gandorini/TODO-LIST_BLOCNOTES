using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bloc
{

    public partial class Form1 : Form
    {
        

        
            private static string stringdeconecxao = "Server=(localdb)\\MSSQLLocalDB;Database=BlocDBB;Trusted_Connection=True;TrustServerCertificate=True;";
            private static SqlConnection db = new SqlConnection(stringdeconecxao);

        public Form1()
            {
                InitializeComponent();
        
            }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            CriarConta criarconta = new CriarConta();

            criarconta.FormClosed += new FormClosedEventHandler((sende, a) =>
            {
                if (criarconta.DialogResult == DialogResult.OK)
                {
                    txtNome.Text = criarconta.NomeUtilizador;
                    txtPalavraPasse.Text = criarconta.Password;
                }
                this.Show();
            });
            this.Hide();
            criarconta.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtNome.Text;
            string password = txtPalavraPasse.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, preencha o nome de utilizador e a palavra-passe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (VerifyLogin(username, password))
            {
                MessageBox.Show("Login bem-sucedido!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu menu = new Menu();
                menu.Owner = this;
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Nome de utilizador ou palavra-passe incorretos. Por favor, tente novamente ou crie uma conta.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifyLogin(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM Utilizador WHERE Username = @Username AND PasswordHash = @PasswordHash";

            try
            {
                using (SqlConnection connection = new SqlConnection(stringdeconecxao))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@PasswordHash", password);

                        int userCount = (int)command.ExecuteScalar();
                        return userCount == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPalavraPasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSairLogin_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linklbPalavrapasse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Esqueceuapp forgotPasswordForm = new Esqueceuapp();
         

            forgotPasswordForm.FormClosed += new FormClosedEventHandler((sende, a) =>
            {
                if (forgotPasswordForm.DialogResult == DialogResult.OK)
                {
                    txtNome.Text = forgotPasswordForm.NomeUtilizador;
                    txtPalavraPasse.Text = forgotPasswordForm.Password;
                }
                this.Show();
            });
            this.Hide();
            forgotPasswordForm.ShowDialog();
        }
    }
}

