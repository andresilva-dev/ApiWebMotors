using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using WebMotors.Api;

namespace WebMotors.Testes.Properties
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public void Deve_obter_relacao_de_fabricantes()
        {
            ApiRestIntegracaoWebMotors api = new ApiRestIntegracaoWebMotors();
            var fabricantes = api.ObtenhaFabricantes();

            Assert.IsTrue(fabricantes.Any());
        }

        [TestMethod]
        public void Deve_obter_relacao_de_modelos()
        {
            ApiRestIntegracaoWebMotors api = new ApiRestIntegracaoWebMotors();
            var modelos = api.ObtenhaModelos(1);

            Assert.IsTrue(modelos.Any());
        }

        [TestMethod]
        public void Deve_obter_relacao_de_versoes()
        {
            ApiRestIntegracaoWebMotors api = new ApiRestIntegracaoWebMotors();
            var versoes = api.ObtenhaVersao(1);

            Assert.IsTrue(versoes.Any());
        }

        [TestMethod]
        public void Deve_obter_relacao_de_carros()
        {
            ApiRestIntegracaoWebMotors api = new ApiRestIntegracaoWebMotors();
            var carros = api.ObtenhaCarros(1);

            Assert.IsTrue(carros.Any());
        }
    }
}
