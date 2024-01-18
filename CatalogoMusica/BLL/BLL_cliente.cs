using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using DAL;
using DTO;

namespace CatalogoMusica.BLL
{
    class BLL_cliente
    {
        Conexao bd = new Conexao();
        public DataTable ListarClientes()
        {
            try
            {
                string comando = "SELECT * FROM cliente;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String VerificarLogin(DTO_Cliente Cliente)
        {
            DataTable valor;
            string comando = "Select * from cliente where email = '" + Cliente.Email +"' and senha = '"+ Cliente.Senha + "';";
            valor = bd.ExecutarConsulta(comando);
            if(valor.Rows.Count > 0)
            {
                return "Usuario encontrado!";
            }
            else
            {
                return "Não encontrado. Verifique o usuario e senha";
            }
        }

        public void InserirCliente(DTO_Cliente Cliente)
        {
            try
            {
                string comando = "INSERT INTO cliente VALUES (NULL, '" +     Cliente.Nome + "','"
                                                                           + Cliente.Email + "','"
                                                                           + Cliente.Telefone + "','"
                                                                           + Cliente.Senha + "');";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void AlterarCliente(DTO_Cliente Cliente)
        {
            try
            {
                string comando = "UPDATE cliente SET nome = '" + Cliente.Nome +
                                                    "', email = '" + Cliente.Email +
                                                    "', telefone = '" + Cliente.Telefone +
                                                    "', senha = '" + Cliente.Senha +
                                                    "' WHERE idcliente = " + Cliente.Idcliente + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExcluirCliente(int id)
        {
            try
            {
                string comando = "DELETE FROM cliente WHERE idcliente = " + id + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
