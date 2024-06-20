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
            cbcategoriasLivros.Items.Add("Terror");
            cbcategoriasLivros.Items.Add("Comédia");
            cbcategoriasLivros.Items.Add("Aventura");
            cbcategoriasLivros.Items.Add("Drama");
            cbcategoriasLivros.Items.Add("Suspense");
            cbcategoriasLivros.Items.Add("Ficção-Científica");
            cbcategoriasLivros.Items.Add("Teatro");
            InitializeComponent();
        }

        private void FormListaLeitura_Load(object sender, EventArgs e)
        {
   
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

        }
    }
}
