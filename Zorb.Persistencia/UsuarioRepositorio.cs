using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zorb.Entidades;
using Zorb.Fronteiras.Repositorios;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace Zorb.Persistencia
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public Usuario Obter(string nome)
        {
            using (var connection = new SqlConnection(Environment.GetEnvironmentVariable("APPSETTING_padrao")))
            {
                var usuario = connection.Query("Select * from Usuario").FirstOrDefault();
                return usuario;
            }
        }

        public Usuario Obter(long id)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Padrao"].ToString()))
            {
                var usuario = connection.Query("Select * from Usuario").FirstOrDefault();
                return usuario;
            }
        }
    }
}
