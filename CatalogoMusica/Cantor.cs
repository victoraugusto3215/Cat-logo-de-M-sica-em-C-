using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using CatalogoMusica.BLL;
namespace CatalogoMusica
{
    public partial class Cantor : Form
    { DTO_artista artista = new DTO_artista();
       BLL_artista bll = new BLL_artista();

        public Cantor()
        {
            InitializeComponent();
        }
        public void limpar()
        {
            txtNome.Clear();
            txtID.Clear();
            txtcpf.Clear();
            txtTelefone.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                artista.Nome = txtNome.Text;
                artista.Cpf = int.Parse(txtcpf.Text);
                artista.Teleone = txtTelefone.Text;
                bll.InserirArtista(artista);
                MessageBox.Show("Cadastro Realizado com Sucesso!");
                limpar();
                CarregarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            artista.Idartista = int.Parse(txtID.Text);
            artista.Nome = txtNome.Text;
            artista.Cpf = int.Parse(txtcpf.Text);
            artista.Teleone = txtTelefone.Text;
            bll.AlterarArtista(artista);
            MessageBox.Show("Artista Alterado com sucesso!");
            CarregarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtID.Text);
            bll.ExcluirArtista(codigo);
            MessageBox.Show("Artista excluido com sucesso!");
            CarregarGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormADM adm = new FormADM();
            this.Hide();
            adm.ShowDialog();
        }

        private void Cantor_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
        public void CarregarGrid()
        {
            try
            {
                dgvMostrarUser.DataSource = bll.ListarArtistas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMostrarUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvMostrarUser.Rows[e.RowIndex].Cells[0].Value.ToString();
           txtNome.Text = dgvMostrarUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcpf.Text = dgvMostrarUser.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefone.Text = dgvMostrarUser.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
