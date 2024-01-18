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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            Form1 form = new Form1();
            this.Hide();
            cadastro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String valor;
            DTO_Cliente Cliente = new DTO_Cliente();
            BLL_cliente bllCliente = new BLL_cliente();
            Cliente.Email = txtEmail.Text;
            Cliente.Senha = txtSenha.Text;
            MessageBox.Show(valor = bllCliente.VerificarLogin(Cliente));
            if(Cliente.Email == "adm" && Cliente.Senha == "adm" && valor == "Usuario encontrado!")
            {
                FormADM adm = new FormADM();
                this.Hide();
                adm.ShowDialog();
            }
            if(valor == "Usuario encontrado!")
            {
                FormUser fUser = new FormUser();
                this.Hide();
                fUser.ShowDialog();
            }
            else
            {

            }
           /* if(txtEmail.Text == "" && txtPASSWORD.Text == "")
            {*/
               
           /* }
            else
            {
               /* FormUser fUser = new FormUser();
                this.Hide();
                fUser.ShowDialog();*//*
            } */
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
