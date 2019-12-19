using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PlaceMyBet.Models;

namespace PlaceMyBet.Controllers
{
    public class ApuestasController : ApiController
    {
        // GET: api/Apuestas
        public List<Apuesta> Get()
        {
            var repo = new ApuestasRepository();
            List<Apuesta> apuestas = repo.Retrieve();
            return apuestas;
        }

        // GET: api/ApuestasDTO
        [Route("api/ApuestasDTO")]
        public List<ApuestaDTO> GetDTO()
        {
            var repo = new ApuestasRepository();
            List<ApuestaDTO> apuestas = repo.RetrieveDTO();
            return apuestas;
        }

        // GET: api/Apuestas/5
        [Route("api/Apuestas/{id_apuesta}")]
        public Apuesta Get(int id_apuesta)
        {
            var repo = new ApuestasRepository();
            Apuesta apuesta = repo.RetrieveById(id_apuesta);
            return apuesta;
        }

        /***EJERCICIO 1***/
        [Route("api/ApuestasBYC/{cuota}")]
        public List<ApuestaDTOID> Get(double cuota)
        {
            var repo = new ApuestasRepository();
            List<ApuestaDTOID> apuestas = repo.RetrieveBYC(cuota);
            return apuestas;
        }
        /***FIN EJERCICIO 1***/


        /***EJERCICIO 2***/
        [Route("api/ApuestasBYE/{equipo}")]
        public List<Apuesta> Get(string equipo)
        {
            var repo = new ApuestasRepository();
            List<Apuesta> apuestas = repo.RetrieveBYE(equipo);
            return apuestas;
        }
        /***FIN EJERCICIO 2***/

        // POST: api/Apuestas
        //[Authorize]
        public void Post(Apuesta a)
        {
            var repo = new ApuestasRepository();
            repo.Save(a);
        }

        // PUT: api/Apuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuestas/5
        public void Delete(int id)
        {
        }
    }
}
