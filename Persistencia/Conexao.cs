using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System.Configuration;
using System.IO;

namespace Persistencia
{
    public class Conexao
    {
        private MySqlConnection _conexao;

        public IConfigurationRoot Configuration { get; set; }

        public Conexao() 
        {
            _conexao = new MySqlConnection("Server=localhost;DataBase=teste_webmotors;Uid=root;Pwd=admin123");
            _conexao.Open();
        }
    }
}
