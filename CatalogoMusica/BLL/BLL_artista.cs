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
    class BLL_artista
    {
        Conexao bd = new Conexao();
        public DataTable ListarArtistas()
        {
            try
            {
                string comando = "SELECT * FROM artista;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InserirArtista(DTO_artista artista)
        {
            try
            {
                string comando = "INSERT INTO artista VALUES (NULL, '" +     artista.Nome + "','"
                                                                           + artista.Cpf + "','"
                                                                           + artista.Teleone + "');";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarArtista(DTO_artista artista)
        {
            try
            {
                string comando = "UPDATE cliente SET nome = '" + artista.Nome +
                                                    "', cpf = '" + artista.Cpf +
                                                    "', telefone = '" + artista.Teleone +
                                                    "' WHERE idartista = " + artista.Idartista + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExcluirArtista(int id)
        {
            try
            {
                string comando = "DELETE FROM artista WHERE idartista = " + id + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
