﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PlaceMyBet.Models;

namespace PlaceMyBet.Controllers
{
    public class MercadosController : ApiController
    {
        // GET: api/Mercados
        public List<Mercado> Get()
        {
            //var repo = new MercadosRepository();
            //List<MercadoDTO> mercados = repo.RetrieveDTO();
            //return mercados;
            using (var context = new PlaceMyBetContext())
            {
                var mercados = context.Mercados.ToList();
                return mercados;
            }
        }

        // GET: api/Mercados/5
        [Route("api/Mercados/{id_mercado}")]
        public Mercado Get(int id_mercado)
        {
            //var repo = new MercadosRepository();
            //List<Mercado> mercados = repo.RetrieveByEventoId(id_evento);
            //return mercados;
            using (var context = new PlaceMyBetContext())
            {
                var mercado = context.Mercados
                    .FirstOrDefault(m => m.MercadoId == id_mercado);
                return mercado;
            }
        }

        [Authorize (Roles = "Admin")]
        public void GetDTOAP  (int id_mercado)
        {
            //var repo = new MercadosRepository();
            //List<MercadoDTOAP> mercados = repo.RetrieveAP(id_mercado);
            //return mercados;
        }

        // POST: api/Mercados
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Mercados/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mercados/5
        public void Delete(int id)
        {
        }
    }
}
