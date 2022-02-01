using ApiWebMotors;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {

            var a =  new Conexao();


            var api = new ApiRestIntegracaoWebMotors();

            var fabricantes = api.ObtenhaFabricantes();
            var modelos = api.ObtenhaModelos(1);
            var versoes = api.ObtenhaVersao(1);

            var veiculos = new List<DTOCarro>();
            for (int i = 1; i < 50; i++) {
                var carros = api.ObtenhaCarros(i);
                veiculos.AddRange(carros);
            }
           
        }
    }
}
