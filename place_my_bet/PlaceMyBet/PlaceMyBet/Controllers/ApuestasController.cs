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
            //var repo = new ApuestasRepository();
            //List<ApuestaDTO> apuestas = repo.RetrieveDTO();
            //return apuestas;
            using (var context = new PlaceMyBetContext())
            {
                var apuestas = context.Apuestas.ToList();
                return apuestas;
            }
        }

        // GET: api/Apuestas/5
        [Route("api/Apuestas/{id_apuesta}")]
        public void Get(int id_apuesta)
        {
            //var repo = new ApuestasRepository();
            //List<ApuestaDTOEVME> apuestas = repo.RetrieveDTOEVME(email);
            //return apuestas;
            using (var context = new PlaceMyBetContext())
            {
                var apuesta = context.Apuestas
                    .FirstOrDefault(a => a.ApuestaId == id_apuesta);
            }
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
