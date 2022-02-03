using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Entidades;
using WebMotors.Persistencia;

namespace WebMotors.Testes
{
    [TestClass]
    public class PersistenciaTest
    {
        [TestMethod]
        public void Deve_inserir_veiculo_no_banco_de_dados ()
        {
            IPersistencia<Veiculo> persistencia = PersistenciaFactory.Crie();

            var id = 1;
            var veiculo = new Veiculo(id) { 
                Color = "Azul",
                Image = "caminhoDaImagem",
                KM = 0,
                Model = "Gol",
                Make = "Wolksvagem",
                Observacao = "Observação",
                Price = 59000,
                Version = "G6",
                YearFab = 2021,
                YearModel = 2022
            };

            persistencia.Insira(veiculo);
           
        }
    }
}
