using WebMotors.Facade;

namespace WebMotors.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var api = new ApiRestIntegracaoWebMotors();
            //var carros = api.ObtenhaCarros(1);
            //var ultimoCarro = carros.Last();
            //ultimoCarro.ID = 3;
            var fachadaDeVeiculos = new FachadaDeVeiculos();
            //fachadaDeVeiculos.InsiraVeiculo(carros[2]);
            //fachadaDeVeiculos.AtualizeVeiculo(ultimoCarro);

            var carroObtido = fachadaDeVeiculos.ObtenhaVeiculo(1);
        }
    }
}
