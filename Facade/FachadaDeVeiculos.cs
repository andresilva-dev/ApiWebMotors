using WebMotors.Entidades;
using WebMotors.Persistencia;

namespace WebMotors.Facade
{
    public class FachadaDeVeiculos
    {
        private PersistenciaVeiculo _persistencia = new PersistenciaVeiculo();
        public void InsiraVeiculo(Veiculo veiculo)
        {
            _persistencia.InsiraVeiculo(veiculo);
        }

        public void ExcluaVeiculo(int id)
        {
            _persistencia.ExcluaVeiculo(id);
        }

        public void AtualizeVeiculo(Veiculo veiculo)
        {
            _persistencia.AtualizeVeiculo(veiculo);
        }

        public Veiculo ObtenhaVeiculo(int id)
        {
            return _persistencia.ObtenhaVeiculo(id);
        }
    }
}
