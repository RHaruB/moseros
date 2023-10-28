using moseros.Models;
using moseros.viewmodels;

namespace moseros.services
{
    public interface IMoseros
    {
        public List<Amante> ObtenerMoseros();

        public bool setMosero(MoserosVM moseros);
    }
}
