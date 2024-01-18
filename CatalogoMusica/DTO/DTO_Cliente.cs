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
     class DTO_Cliente
    {
        private int idcliente;
        private string nome;
        private string email;
        private String telefone;
        private string senha;

        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
