using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PlaceMyBet.Models;

namespace PlaceMyBet.Controllers
{
    public class EventosController : ApiController
    {
        // GET: api/Eventos
        public List<Evento> Get()
        {
            var repo = new EventosRepository();
            List<Evento> eventos = repo.Retrieve();
            return eventos;
        }

        // GET: api/Eventos/5
        public void Get(int id)
        {
            //return null;
        }

        // POST: api/Eventos
        public void Post(Evento e)
        {
            using (var context = new PlaceMyBetContext())
            {
                var eventos = context.Set<Evento>();
                eventos.Add(new Evento(e.EventoId, e.EquipoV, e.EquipoL));
                context.SaveChanges();
            }
        }

        // PUT: api/Eventos/5
        public void Put(int id)
        {
            var repo = new EventosRepository();
            repo.Update(id, equipol, equipov);
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
        }
    }
}
