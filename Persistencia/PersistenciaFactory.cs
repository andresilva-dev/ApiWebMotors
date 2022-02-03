using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Entidades;
using WebMotors.Persistencia;

namespace Persistencia
{
    public class PersistenciaFactory
    {
        public static IPersistencia<Veiculo> Crie()
        {
            return new PersistenciaVeiculo();
        }
    }
}
