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
    class DTO_artista
    {
        private int idartista;
        private string nome;
        private int cpf;
        private String teleone;

        public int Idartista { get => idartista; set => idartista = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public String Teleone { get => teleone; set => teleone = value; }
    }
}
