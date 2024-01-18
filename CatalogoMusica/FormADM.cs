using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoMusica
{
    public partial class FormADM : Form
    {
        public FormADM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UserInfo user = new UserInfo();
            this.Hide();
            user.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Music music = new Music();
            this.Hide();
            music.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Estilo f1 = new Estilo();
            this.Close();
            this.Hide();
            f1.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cantor adm = new Cantor();
            this.Hide();
            adm.ShowDialog();
        }
    }
}
