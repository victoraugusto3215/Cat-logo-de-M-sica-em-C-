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
    public partial class Estilo : Form
    {
        BLL_estmusical BLLestilo = new BLL_estmusical();
        DTO_estmusical DTOEstilo = new DTO_estmusical();
        public Estilo()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void Estilo_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        public void limpar()
        {
            txtNome.Clear();
            txtID.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DTOEstilo.Nome = txtNome.Text;
                BLLestilo.InserirEstilo(DTOEstilo);
                MessageBox.Show("Cadastro Realizado com Sucesso!");
                CarregarGrid();
                limpar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CarregarGrid()
        {
            try
            {
                dgvMostrarEstilo.DataSource = BLLestilo.ListarEstilos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() != string.Empty)
                {
                    DTOEstilo.IdEstmusical = int.Parse(txtID.Text);
                    BLLestilo.ExcluirEstilo(DTOEstilo.IdEstmusical);
                    MessageBox.Show("Usuario Excluido");
                }
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
            DTOEstilo.IdEstmusical = int.Parse(txtID.Text);
            DTOEstilo.Nome = txtNome.Text;
            BLLestilo.AlterarEstilo(DTOEstilo);
            MessageBox.Show("Estilo Alterado com sucesso!");
            limpar();
            CarregarGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormADM adm = new FormADM();
            this.Hide();
            adm.ShowDialog();
        }

        private void dgvMostrarEstilo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvMostrarEstilo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvMostrarEstilo.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
