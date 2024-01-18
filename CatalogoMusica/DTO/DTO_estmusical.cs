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
    class DTO_estmusical
    {
        private int idEstmusical;
        private string nome;

        public int IdEstmusical { get => idEstmusical; set => idEstmusical = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
