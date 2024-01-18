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
    class BLL_musica
    {
        Conexao bd = new Conexao();
        public DataTable ListarMusicas()
        {
            try
            {
                string comando = "SELECT * FROM musica;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ListarPlaylist()
        {
            try
            {
                string comando = "SELECT * FROM playlist;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InserirMusica(DTO_musica Musica)
        {
            try
            {
                string comando = "INSERT INTO cliente VALUES (NULL, '" + Musica.Nome + "','"
                                                                           + Musica.Artist + "','"
                                                                           + Musica.Estmusical + "');";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarMusica(DTO_musica Musica)
        {
            try
            {
                string comando = "UPDATE musica SET nome = '" + Musica.Nome +
                                                    "', artist = '" + Musica.Artist +
                                                    "', estmusical = '" + Musica.Estmusical +
                                                    "' WHERE idmusica = " + Musica.Idmusica + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirMusica(int id)
        {
            try
            {
                string comando = "DELETE FROM musica WHERE idmusica = " + id + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
