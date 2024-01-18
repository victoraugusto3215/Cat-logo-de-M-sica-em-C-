using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using DAL;
namespace DTO
{
    class DTO_musica
    {
        private int idmusica;
        private string nome;
        private int artist;
        private int estmusical;

        public int Idmusica { get => idmusica; set => idmusica = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Artist { get => artist; set => artist = value; }
        public int Estmusical { get => estmusical; set => estmusical = value; }
    }
}
