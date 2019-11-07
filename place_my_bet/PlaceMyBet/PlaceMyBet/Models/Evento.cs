using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Evento
    {
        public Evento()
        {

        }
        public Evento(int id, string equipov, string equipol/*, List<Mercado> mercados*/)
        {
            EventoId = id;
            EquipoL = equipol;
            EquipoV = equipov;
            /*Mercados = mercados;*/
        }
        public int EventoId { get; set; }
        public string EquipoL { get; set; }
        public string EquipoV { get; set; }

        public List<Mercado> Mercados { get; set; }
    }

    /*public class EventoDTO
    {
        public EventoDTO(string equipov, string equipol)
        {
            EquipoL = equipol;
            EquipoV = equipov;
        }
        public string EquipoL { get; set; }
        public string EquipoV { get; set; }
        public List<Mercado> Mercados { get; set; }
    }*/
}