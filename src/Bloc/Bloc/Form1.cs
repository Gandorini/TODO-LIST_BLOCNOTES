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

        private static string stringdeconecxao = "Server=(localdb)\\MSSQLLocalDB;Database=BlocDB_2222123;Trusted_Connection=True;TrustServerCertificate=True;";


        private static SqlConnection db = new SqlConnection(stringdeconecxao);
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            CriarConta criarconta = new CriarConta();
             criarconta.Show();
            form1.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Utili = txtNome.Text;
            string Passe = txtPalavraPasse.Text;

            if (string.IsNullOrEmpty(Utili) || string.IsNullOrEmpty(Passe))
            {
                MessageBox.Show("Por favor, preencha o nome de utilizador e a palavra-passe.");
                return;
            }

            if (VerifyLogin(Utili, Passe))
            {
                MessageBox.Show("Login bem-sucedido!","Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Menu menu = new Menu();
                menu.Show();
                Form1 form1 = new Form1();
                form1.Hide();
                
                  
            }
            else
            {
                MessageBox.Show("Nome de utilizador ou palavra-passe incorretos. Por favor, tente novamente ou crie uma conta.","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private bool VerifyLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(stringdeconecxao))
            {
                string query = "SELECT COUNT(*) FROM Utilizador WHERE Username = @Username AND PasswordHash = @PasswordHash";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@PasswordHash", password);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                finally
                {
                    connection.Close();
                }
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
    }
}
