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
    public partial class FormAnotacoes : Form
    {
        public FormAnotacoes()
        {
            InitializeComponent();

            txtAnotacoesTexto.Multiline = true;
            txtAnotacoesTexto.Width = 857;
            txtAnotacoesTexto.Height = 500;
        }

        private void txtAnotacoesTexto_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
