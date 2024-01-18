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
using DAL;
using CatalogoMusica.BLL;

namespace CatalogoMusica
{
    public partial class Cadastro : Form
    {
        DTO_Cliente DTOCliente = new DTO_Cliente();
        BLL_cliente BLLliente = new BLL_cliente();
        
        public Cadastro()
        {
            InitializeComponent();
        }

        public void limpar ()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtSenha.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                    DTOCliente.Nome = txtNome.Text ;
                    DTOCliente.Email = txtEmail.Text;
                    DTOCliente.Senha = txtSenha.Text;
                    DTOCliente.Telefone = txtTelefone.Text;
                    BLLliente.InserirCliente(DTOCliente);
                    MessageBox.Show("Cadastrado Realizado com Sucesso!");
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
           txtEmail.Text = "";
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }

        private void txtTelefone_Click(object sender, EventArgs e)
        {
            txtTelefone.Text = "";
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
