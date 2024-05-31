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



namespace Bloc
{
   
    public partial class Menu : Form
    {
        FormAnotacoes anotacoes;
        FormDocumentos documentos;
        FormListaLeitura listaLeitura;
        Calendário calendario;
        
        
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


        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(anotacoes == null)
            {
                anotacoes = new FormAnotacoes();
                anotacoes.FormClosed +=  anotacoes_FormClosed;
                anotacoes.MdiParent = this;
                anotacoes.Show();
            }
            else
            {
                anotacoes.Activate();
            }
        }

        private void anotacoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            anotacoes = null;

        }

   

      
        bool sidebarExpand = true;

     
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 43)
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
                if (sidebar.Width >= 221)
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

        private void btnListaLeitura_Click(object sender, EventArgs e)
        {
            if (listaLeitura == null)
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
            if (documentos == null)
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
            if (documentos == null)
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
           this.Close();
        }

    }

}

