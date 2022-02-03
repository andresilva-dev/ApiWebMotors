using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace WebMotors.Persistencia
{
    public class Conexao
    {
        private static MySqlConnection _conexao;

        public IConfigurationRoot Configuration { get; set; }

        public static MySqlConnection GetConexao()
        {
            if (_conexao == null)
            {
                _conexao = new MySqlConnection("Server=localhost;DataBase=teste_webmotors;Uid=root;Pwd=admin123");
            }

            _conexao.Open();
            return _conexao;
        }
    }
}
