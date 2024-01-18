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
    class BLL_estmusical
    {
        Conexao bd = new Conexao();
        public DataTable ListarEstilos()
        {
            try
            {
                string comando = "SELECT * FROM estmusical;";
                return bd.ExecutarConsulta(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void InserirEstilo(DTO_estmusical Estilos)
        {
            try
            {
                string comando = "INSERT INTO estmusical VALUES (NULL, '" + Estilos.Nome + "');";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AlterarEstilo(DTO_estmusical Estilos)
        {
            try
            {
                string comando = "UPDATE estmusical SET nome = '" + Estilos.Nome +
                                                    "' WHERE idEstmusical = " + Estilos.IdEstmusical + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExcluirEstilo(int id)
        {
            try
            {
                string comando = "DELETE FROM estmusical WHERE idEstmusical = " + id + ";";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
