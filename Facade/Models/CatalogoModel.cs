using System.Collections.Generic;

namespace Facade.Models
{
    public class CatalogoModel
    {
        public IEnumerable<VeiculoModel> Carros { get; set; }
        public int Pagina { get; set; }
    }
}