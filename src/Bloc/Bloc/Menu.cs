using Hangfire.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Bloc
{
   
    public partial class Menu : Form
    {

        private static string stringdeconecxao = "Server=(localdb)\\MSSQLLocalDB;Database=BlocDBB;Trusted_Connection=True;TrustServerCertificate=True;";
        private static SqlConnection db = new SqlConnection(stringdeconecxao);



        private FormAnotacoes anotacoes;
        private FormDocumentos documentos;
        private FormListaLeitura listaLeitura;
        private Calendário calendario;

        public Menu()
        {
            InitializeComponent();
            AtualizarData();
            mdiProp();


        }


        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232,234,237);
        }


        private void timerAtualizacao_Tick(object sender, EventArgs e)
        {

            AtualizarData();
        }

        private void AtualizarData()
        {

            lblDataAtual.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    
        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 101)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnAnotacoes.Width = sidebar.Width;
                    pnListaLeitura.Width = sidebar.Width;
                    pnDocumento.Width = sidebar.Width;
                    pnCalendario.Width = sidebar.Width;
                    pnSair.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 223)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnAnotacoes.Width = sidebar.Width;
                    pnListaLeitura.Width = sidebar.Width;
                    pnDocumento.Width = sidebar.Width;
                    pnCalendario.Width = sidebar.Width;
                    pnSair.Width = sidebar.Width;

                }

            }
        }

        private void btnHam_Click_1(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (documentos != null && documentos.Visible)
            {
                documentos.Visible = false;
            }
            if (calendario != null && calendario.Visible)
            {
               calendario.Visible = false;
            }
            if (listaLeitura != null && listaLeitura.Visible)
            {
                listaLeitura.Visible = false;
            }


            anotacoes = new FormAnotacoes();
            anotacoes.FormClosed += anotacoes_FormClosed;
            anotacoes.MdiParent = this;
            anotacoes.Show();


            if (anotacoes == null || anotacoes.IsDisposed)
            {
                anotacoes.Close();
            }
        }

        private void anotacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            anotacoes = null;

        }
        private void btnListaLeitura_Click(object sender, EventArgs e)
        {
            if (documentos != null && documentos.Visible)
            {
                documentos.Visible = false;
            }
            if (calendario != null && calendario.Visible)
            {
                calendario.Visible = false;
            }
            if (anotacoes != null && anotacoes.Visible)
            {
                anotacoes.Visible = false;
            }

            if (calendario == null || calendario.IsDisposed)
            {
                listaLeitura = new FormListaLeitura();
                listaLeitura.FormClosed += listaleitura_FormClosed;
                listaLeitura.MdiParent = this;
                listaLeitura.Show();

            }
            else
            {
                listaLeitura.Activate();
            }

        }

        private void listaleitura_FormClosed(object sender, FormClosedEventArgs e)
        {
           listaLeitura = null;

        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            if (listaLeitura != null && listaLeitura.Visible)
            {
               listaLeitura.Visible = false;
            }
            if (calendario != null && calendario.Visible)
            {
                calendario.Visible = false;
            }
            if (anotacoes != null && anotacoes.Visible)
            {
                anotacoes.Visible = false;
            }


            if (calendario == null || calendario.IsDisposed)
            { 
            documentos = new FormDocumentos();
            documentos.FormClosed += documentos_FormClosed;
            documentos.MdiParent = this;
            documentos.Show();
            }
            else
            {
                documentos.Activate();
            }
        }

        private void documentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            documentos = null;

        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            if (listaLeitura != null && listaLeitura.Visible)
            {
                listaLeitura.Visible=false;
            }
            if (documentos != null && documentos.Visible)
            {
                documentos.Visible = false;
            }
            if (anotacoes != null && anotacoes.Visible)
            {
                anotacoes.Visible = false;
            }



            if (calendario == null || calendario.IsDisposed)
            {
         
                calendario = new Calendário();
                calendario.FormClosed += calendario_FormClosed;
                calendario.MdiParent = this;
                calendario.Show();
            }
            else
            {
                calendario.Activate();
            }
        }

        private void calendario_FormClosed(object sender, FormClosedEventArgs e)
        {
            calendario = null;

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

           this.Close();
           form1.Show();
        }

        private void linklbremoverconta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int userIdToDelete = ObterIdDoUsuarioParaExcluir();

            if (userIdToDelete > 0)
            {
                if (ConfirmarExclusaoUsuario(userIdToDelete))
                {
                    MessageBox.Show("Conta excluída com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Exclusão cancelada pelo usuário.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObterIdDoUsuarioParaExcluir()
        {
            string username = Prompt.ShowDialog("Por favor, insira o nome de usuário:", "Excluir Usuário");

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Nome de usuário não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(stringdeconecxao))
                {
                    connection.Open();
                    string query = "SELECT UserID FROM Utilizador WHERE Username = @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private bool ConfirmarExclusaoUsuario(int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringdeconecxao))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("sp_ConfirmarExclusaoUsuario", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", userId);
                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar excluir usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 300 };
            Button confirmation = new Button() { Text = "Ok", Left = 250, Width = 100, Top = 100, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }

}

