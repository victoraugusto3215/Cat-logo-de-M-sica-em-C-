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
    public partial class Music : Form
    {
        BLL_musica BLLMUSIA = new BLL_musica();
        DTO_musica DLLMusica = new DTO_musica();
        public Music()
        {
            InitializeComponent();
        }

        private void Music_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
        public void CarregarGrid()
        {
            try
            {
                dgvMostrarMusic.DataSource = BLLMUSIA.ListarMusicas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void limpar()
        {
            txtNome.Clear();
            txtArtista.Clear();
            txtID.Clear();
            txtEstilo.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DLLMusica.Nome = txtNome.Text;
                DLLMusica.Artist = int.Parse(txtArtista.Text);
                DLLMusica.Estmusical = int.Parse(txtEstilo.Text);
                MessageBox.Show("Cadastro Realizado com Sucesso!");
                limpar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormADM adm = new FormADM();
            this.Hide();
            adm.ShowDialog();
        }

        private void dgvMostrarMusic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvMostrarMusic.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvMostrarMusic.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtArtista.Text = dgvMostrarMusic.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEstilo.Text = dgvMostrarMusic.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
