using WebMotors.Entidades;

namespace WebMotors.Persistencia
{
    public interface IPersistencia<T> where T : class
    {
        void Atualize(T entidade);
        void Exclua(int idEntidade);
        void Insira(T entidade);
        Veiculo Obtenha(int idEntidade);
    }
}