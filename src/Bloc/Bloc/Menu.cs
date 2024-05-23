using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloc
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            AtualizarData();
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

        }

        bool menuExpand = false;

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if(menuContainer.Height >= 165)
                {
                    timerMenu.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer -= 10;
                if(menuContainer.Height <= 46)
                {
                    timerMenu.Stop();
                    menuExpand = false;
                }
            }

        }
    }

}

