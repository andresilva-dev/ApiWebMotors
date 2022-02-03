using System.Collections.Generic;

namespace Facade.Models
{
    public class CatalogoModel
    {
        public IEnumerable<VeiculoModel> Carros { get; set; }
        public int Pagina { get; set; }
    }

    public class VeiculoModel
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Version { get; set; }
        public string Image { get; set; }
        public int KM { get; set; }
        public decimal Price { get; set; }
        public int YearModel { get; set; }
        public int YearFab { get; set; }
        public string Color { get; set; }
    }
}