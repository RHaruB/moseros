using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using moseros.services;

namespace moseros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoserosController : ControllerBase
    {
        public IMoseros mosero;

        public MoserosController( IMoseros _moseros)
        {
            this.mosero = _moseros;
        }
        [HttpGet]
        public string ObtenerMoseros(string nombre)
        {
            return mosero.ObtenerMoseros() +" " + nombre;
        }
    }
}
