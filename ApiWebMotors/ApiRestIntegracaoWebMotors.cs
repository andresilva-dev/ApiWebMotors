using ApiWebMotors.DTOs;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace WebMotors.Api
{
    public class ApiRestIntegracaoWebMotors
    {
        private readonly string _baseUrl = @"https://desafioonline.webmotors.com.br/api/OnlineChallenge/";

		private RestClient CrieRestClient()
		{
			RestClient restClient = new RestClient(_baseUrl);

			return restClient;
		}

		public List<DTOFabricante> ObtenhaFabricantes()
        {
			var cliente = CrieRestClient();

			var request = new RestRequest("Make/", Method.Get);
			var queryResult = cliente.ExecuteGetAsync(request);
			return JsonConvert.DeserializeObject<List<DTOFabricante>>(queryResult.Result.Content);
		}

		public List<DTOModelo> ObtenhaModelos(int idFabricante)
		{
			var cliente = CrieRestClient();

			var request = new RestRequest("Model/", Method.Get).AddQueryParameter("MakeID", idFabricante.ToString());
			var queryResult = cliente.ExecuteGetAsync(request);
			return JsonConvert.DeserializeObject<List<DTOModelo>>(queryResult.Result.Content);
		}

		public List<DTOVersao> ObtenhaVersao(int idModelo)
		{
			var cliente = CrieRestClient();

			var request = new RestRequest("Version/", Method.Get).AddQueryParameter("ModelID", idModelo.ToString());
			var queryResult = cliente.ExecuteGetAsync(request);
			return JsonConvert.DeserializeObject<List<DTOVersao>>(queryResult.Result.Content);
		}

		public List<DTOCarro> ObtenhaCarros(int pagina)
		{
			var cliente = CrieRestClient();

			var request = new RestRequest("Vehicles/", Method.Get).AddQueryParameter("Page", pagina.ToString());
			var queryResult = cliente.ExecuteGetAsync(request);
			return JsonConvert.DeserializeObject<List<DTOCarro>>(queryResult.Result.Content);
		}
	}
}
