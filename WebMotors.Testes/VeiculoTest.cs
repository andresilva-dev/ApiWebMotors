using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebMotors.Entidades;

namespace WebMotors.TestesUnitarios
{
    [TestClass]
    public class VeiculoTest
    {
        [TestMethod]
        public void Deve_disparar_excecao_caso_seja_informado_um_id_invalido()
        {
            Assert.ThrowsException<Exception>(()=> new Veiculo(-5));
        }
        [TestMethod]
        public void Deve_disparar_excecao_caso_seja_informado_um_valor_invalido_para_price()
        {
            var veiculo = new Veiculo(1);
            Assert.ThrowsException<Exception>(() => veiculo.Price = -10);
        }
        [TestMethod]
        public void Deve_disparar_excecao_caso_seja_informado_um_valor_invalido_para_km()
        {
            var veiculo = new Veiculo(1);
            Assert.ThrowsException<Exception>(() => veiculo.KM = -1);
        }
        [TestMethod]
        public void Deve_disparar_excecao_caso_seja_informado_um_valor_invalido_para_yearModel()
        {
            var veiculo = new Veiculo(1);
            Assert.ThrowsException<Exception>(() => veiculo.YearModel = 1499);
        }
        [TestMethod]
        public void Deve_disparar_excecao_caso_seja_informado_um_valor_invalido_para_yearFab()
        {
            var veiculo = new Veiculo(1);
            Assert.ThrowsException<Exception>(() => veiculo.YearFab = 1499);

            Assert.ThrowsException<Exception>(() => veiculo.YearFab = DateTime.Now.Year +2);
        }
    }
}
