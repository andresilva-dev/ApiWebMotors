using MySqlConnector;
using System;
using WebMotors.Entidades;

namespace WebMotors.Persistencia
{
    public class PersistenciaVeiculo
    {
        public void InsiraVeiculo(Veiculo carro)
        {
            var sqlInsert = $@"INSERT INTO TB_ANUNCIOWEBMOTORS(ID, MARCA, MODELO, VERSAO, ANO, QUILOMETRAGEM, OBSERVACAO) 
                                                       VALUES(@ID, @MARCA, @MODELO, @VERSAO, @ANO, @QUILOMETRAGEM, @OBSERVACAO)";

            using (var conexao = Conexao.GetConexao())
            using (var transction = conexao.BeginTransaction())
            using (var cmd = new MySqlCommand())
            {
                cmd.Transaction = transction;
                cmd.Connection = conexao;
                cmd.CommandText = sqlInsert;

                PrepareParametros(carro, cmd);

                cmd.ExecuteNonQuery();
                transction.Commit();
            }
        }

        public void AtualizeVeiculo(Veiculo carro)
        {
            var sqlUpdate = @"UPDATE TB_ANUNCIOWEBMOTORS SET MARCA = @MARCA, MODELO = @MODELO, VERSAO = @VERSAO, ANO = @ANO, 
                               QUILOMETRAGEM = @QUILOMETRAGEM, OBSERVACAO = @OBSERVACAO WHERE ID = @ID";

            using (var conexao = Conexao.GetConexao())
            using (var transction = conexao.BeginTransaction())
            using (var cmd = new MySqlCommand())
            {
                cmd.Transaction = transction;
                cmd.Connection = conexao;
                cmd.CommandText = sqlUpdate;

                PrepareParametros(carro, cmd);

                cmd.ExecuteNonQuery();
                transction.Commit();
            }
        }

        public void ExcluaVeiculo(int id)
        {
            string sqlDelete = $"DELETE FROM TB_ANUNCIOWEBMOTORS WHERE ID = @ID"; 

            using (var conexao = Conexao.GetConexao())
            using (var transction = conexao.BeginTransaction())
            using (var cmd = conexao.CreateCommand())
            {
                cmd.Transaction = transction;
                cmd.Connection = conexao;
                cmd.CommandText = sqlDelete;

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Prepare();
                
                cmd.ExecuteNonQuery();
                transction.Commit();
            }
        }

        public Veiculo ObtenhaVeiculo(int id)
        {
            string sqlSelect = $"SELECT * FROM TB_ANUNCIOWEBMOTORS WHERE ID = @ID";

            using (var conexao = Conexao.GetConexao())
            using (var transction = conexao.BeginTransaction())
            using (var cmd = conexao.CreateCommand())
            {
                cmd.Transaction = transction;
                cmd.Connection = conexao;
                cmd.CommandText = sqlSelect;

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Prepare();

                var reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    var identificador = Convert.ToInt32(reader["ID"].ToString());
                    
                    return new Veiculo(identificador)
                    {
                        Make = reader["MARCA"].ToString(),
                        Model = reader["MODELO"].ToString(),
                        Version = reader["VERSAO"].ToString(),
                        YearFab = Convert.ToInt32(reader["ANO"].ToString()),
                        KM = Convert.ToInt32(reader["QUILOMETRAGEM"].ToString()),
                        Observacao = reader["OBSERVACAO"].ToString()
                    };
                }

                return null;
            }
        }

        private void PrepareParametros(Veiculo carro, MySqlCommand cmd)
        {
            var observacao = carro.Observacao == null ? string.Empty : carro.Observacao;

            cmd.Parameters.AddWithValue("@ID", carro.Id);
            cmd.Parameters.AddWithValue("@MARCA", carro.Make);
            cmd.Parameters.AddWithValue("@MODELO", carro.Model);
            cmd.Parameters.AddWithValue("@VERSAO", carro.Version);
            cmd.Parameters.AddWithValue("@ANO", carro.YearFab);
            cmd.Parameters.AddWithValue("@QUILOMETRAGEM", carro.KM);
            cmd.Parameters.AddWithValue("@OBSERVACAO", observacao);
            cmd.Prepare();
        }
    }
}
