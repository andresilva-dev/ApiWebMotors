using Facade.Models;
using Persistencia;
using System.Collections.Generic;
using System.Linq;
using WebMotors.Api;
using WebMotors.Entidades;
using WebMotors.Persistencia;

namespace WebMotors.Facade
{
    public class FachadaDeVeiculos
    {
        private IPersistencia<Veiculo> _persistencia = PersistenciaFactory.Crie();
        public void InsiraVeiculo(Veiculo veiculo)
        {
            _persistencia.Insira(veiculo);
        }

        public void ExcluaVeiculo(int id)
        {
            _persistencia.Exclua(id);
        }

        public void AtualizeVeiculo(Veiculo veiculo)
        {
            _persistencia.Atualize(veiculo);
        }

        public Veiculo ObtenhaVeiculo(int id)
        {
            return _persistencia.Obtenha(id);
        }

        public IEnumerable<VeiculoModel> ObtenhaVeiculosWebMotors(int pagina)
        {
            ApiRestIntegracaoWebMotors _api = new ApiRestIntegracaoWebMotors();
            var veiculos = _api.ObtenhaCarros(pagina);
            
            return veiculos.Select(a => new VeiculoModel()
            {
                ID = a.ID,
                Color = a.Color,
                Image = a.Image,
                KM = a.KM,
                Make = a.Make,
                Model = a.Model,
                Price = a.Price,
                Version = a.Version,
                YearFab = a.YearFab,
                YearModel = a.YearModel
            });
        }
    }
}
