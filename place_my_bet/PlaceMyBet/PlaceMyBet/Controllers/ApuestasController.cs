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

        // GET: api/Apuestas/5
        [Route("api/Apuestas/{id_apuesta}")]
        public Apuesta Get(int id_apuesta)
        {
            var repo = new ApuestasRepository();
            Apuesta apuesta = repo.RetrieveById(id_apuesta);
            return apuesta;
        }

        // POST: api/Apuestas
        [Authorize]
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
