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

    public partial class UserInfo : Form
    {
        BLL_cliente BLLcliente = new BLL_cliente();
        DTO_Cliente DTOCliente = new DTO_Cliente();
        public UserInfo()
        {
            InitializeComponent();
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            try
            {
                dgvMostrarUser.DataSource = BLLcliente.ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
        public void limpar()
        {
            txtID.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtSenha.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DTOCliente.Nome = txtNome.Text;
                DTOCliente.Email = txtEmail.Text;
                DTOCliente.Senha = txtSenha.Text;
                DTOCliente.Telefone = txtTelefone.Text;
                BLLcliente.InserirCliente(DTOCliente);
                MessageBox.Show("Cadastro Realizado com Sucesso!");
                limpar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Form1 f1 = new Form1();
                this.Close();
                this.Hide();
                f1.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() != string.Empty)
                {
                    DTOCliente.Idcliente = int.Parse(txtID.Text);
                    BLLcliente.ExcluirCliente(DTOCliente.Idcliente);
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

        private void button4_Click(object sender, EventArgs e)
        {
            FormADM adm = new FormADM();
            this.Hide();
            adm.ShowDialog();
        }

        private void dgvMostrarUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvMostrarUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvMostrarUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvMostrarUser.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefone.Text = dgvMostrarUser.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSenha.Text = dgvMostrarUser.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
