using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using CatalogoMusica.BLL;

namespace CatalogoMusica
{
    public partial class FormUser : Form
    {
        BLL_musica bllmusic = new BLL_musica();
        DTO_musica dtoMusic = new DTO_musica();
        DTO_Cliente dtoCliente = new DTO_Cliente();
        Form1 form1 = new Form1();

        public FormUser()
        {
            InitializeComponent();
            CarregarGrid();
        }
        public void CarregarGrid()
        {
            try
            {
                dtvVisualisarmusica.DataSource = bllmusic.ListarPlaylist();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }

        private void dtvVisualisarmusica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            form1.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
