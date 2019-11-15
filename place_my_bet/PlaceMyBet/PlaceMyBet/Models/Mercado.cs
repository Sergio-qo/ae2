using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Mercado
    {
        public Mercado()
        {

        }
        public Mercado(int id, /*int eventoId,*/ double dineroApostadoUnder, double dineroApostadoOver, double cuotaUnder, double cuotaOver, string tipo, int eventoId)
        {
            MercadoId = id;
            DineroApostadoOver = dineroApostadoOver;
            DineroApostadoUnder = dineroApostadoUnder;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
            Tipo = tipo;
            /*Evento = evento;*/
            EventoId = eventoId;
        }

        public int MercadoId { get; set; }
        public double DineroApostadoUnder { get; set; }
        public double DineroApostadoOver { get; set; }
        public double CuotaUnder { get; set; }
        public double CuotaOver { get; set;}
        public string Tipo { get; set;}
        public List<Apuesta> Apuestas { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }

    public class MercadoDTO
    {
        public MercadoDTO(double cuotaUnder, double cuotaOver, string tipo)
        {
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
            Tipo = tipo;
        }

        public double CuotaUnder { get; set; }
        public double CuotaOver { get; set; }
        public string Tipo { get; set; }
    }

    /*public class MercadoDTOAP
    {
        public MercadoDTOAP(string email, string tipo_m, string tipo_a, double cuota, double din_ap)
        {
            Email = email;
            Tipo_M = tipo_m;
            Tipo_A = tipo_a;
            Cuota = cuota;
            Din_Ap = din_ap;
        }

        public string Email { get; set; }
        public string Tipo_M { get; set; }
        public string Tipo_A { get; set; }
        public double Cuota { get; set; }
        public double Din_Ap { get; set; }
        public List<Apuesta> Apuestas { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }*/
}