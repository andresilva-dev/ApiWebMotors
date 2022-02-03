using Newtonsoft.Json;
using System;

namespace WebMotors.Entidades
{
    public class Veiculo
    {
		private int _id;
		private decimal _price;
		private int _anoModelo;
		private int _anoFabricacao;
		private int _quilometragem;
		public Veiculo(int id)
		{
			if (id <= 0)
			{
				throw new Exception("O valor informado para o id é inválido!");
			}
		}
		[JsonProperty("ID")]
		public int Id => _id;
		public string Make { get; set; }
		public string Model { get; set; }
		public string Version { get; set; }
		public string Image { get; set; }
		public int KM
		{
			get => _quilometragem;
			set
			{
				if (value < 0)
				{
					throw new Exception("O valor informado para quilometragem do veículo é inválido!");
				}

				_quilometragem = value;
			}
		}
		public decimal Price 
		{ 
			get => _price;
			set 
			{ 
				if(value < 0 )
				{
					throw new Exception("O valor informado para o veículo é inválido!");
				}
				
				_price = value;
			} 
		}
		public int YearModel 
		{
			get => _anoModelo;
			set
			{
				if (value < 1500)
				{
					throw new Exception("O valor informado para o ano do modelo do veículo é inválido!");
				}

				_anoModelo = value;
			}
		}
		public int YearFab
		{
			get => _anoFabricacao;
			set
			{
				if (value < 1500 || value > DateTime.Now.Year)
				{
					throw new Exception("O valor informado para o ano do modelo do veículo é inválido!");
				}

				_anoFabricacao = value;
			}
		}
		public string Color { get; set; }
		public string Observacao { get; set; }
        public override bool Equals(object obj)
        {
			return (obj is Veiculo veiculo) && veiculo.Id == Id;
        }
        public override string ToString()
        {
            return $"Veículo id: {Id}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
