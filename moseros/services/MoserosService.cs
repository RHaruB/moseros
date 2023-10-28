using moseros.Models;
using moseros.viewmodels;

namespace moseros.services
{
    public class MoserosService : IMoseros
    {
        private MoserosContext _context;

        public MoserosService(MoserosContext context)
        {
            this._context = context;
        }
        public List<Amante> ObtenerMoseros()
        {
            var moseros = _context.Amantes.ToList();

            return moseros;

        }
        public bool setMosero(MoserosVM moseros)
        {
            bool registrado = false;

            try
            {
                Amante amanteBD = new Amante();
                amanteBD.Nombre = moseros.nombre;
                amanteBD.Edad = moseros.edad;

                _context.Amantes.Add(amanteBD);

                _context.SaveChanges();
                registrado = true;
            }
            catch (Exception)
            {

                registrado = false;
            }

         

            return registrado;
        }
       
    }
}
