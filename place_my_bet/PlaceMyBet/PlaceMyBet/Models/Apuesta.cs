using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Apuesta
    {
        public Apuesta()
        {

        }
        public Apuesta(int id, string tipo, double cuota, double dineroApostado, int mercadoId, string usuarioId/*, Mercado mercado*//*, Usuario usuario*/)
        {
            ApuestaId = id;
            Tipo = tipo;
            Cuota = cuota;
            DineroApostado = dineroApostado;
            MercadoId = MercadoId;
            IdUsuario = usuarioId;
            /*Mercado = mercado;*/
        }
        public int ApuestaId { get; set; }
        public string Tipo { get; set; }
        public double Cuota { get; set; }
        public double DineroApostado { get; set; }
        public int MercadoId { get; set; }
        public string IdUsuario { get; set; }
        public Mercado Mercado { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

       
    }


    public class ApuestaDTO
    {
        public ApuestaDTO(int usuarioId, int eventoId, string tipo, double cuota, double dinero_apostado)
        {
            UsuarioId = usuarioId;
            EventoId = eventoId;
            Tipo = tipo;
            Cuota = cuota;
            DineroApostado = dinero_apostado;
        }
        public int UsuarioId { get; set; }
        public int EventoId { get; set; }
        public string Tipo { get; set; }
        public double Cuota { get; set; }
        public double DineroApostado { get; set; }
    }

    /*public class ApuestaDTO
    {
        public ApuestaDTO(string tipo, double cuota, double dineroApostado, int idMercado, string emailUsuario)
        {
            Tipo = tipo;
            Cuota = cuota;
            DineroApostado = dineroApostado;
            IdMercado = idMercado;
            EmailUsuario = emailUsuario;
        }
        public string Tipo { get; set; }
        public double Cuota { get; set; }
        public double DineroApostado { get; set; }
        public int IdMercado { get; set; }
        public string EmailUsuario { get; set; }
        public int MercadoId { get; set; }
        public Mercado Mercado { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }

    public class ApuestaDTOEVME
    {
        public ApuestaDTOEVME(string tipo_mercado,  int id_evento, int id, string tipo, double cuota, double dineroApostado, int idMercado, string emailUsuario)
        {
            Tipo_Mercado = tipo_mercado;
            Id_Evento = id_evento;
            Tipo = tipo;
            Cuota = cuota;
            DineroApostado = dineroApostado;
            IdMercado = idMercado;
            EmailUsuario = emailUsuario;
        }
        public string Tipo_Mercado { get; set; }
        public int Id_Evento { get; set; }
        public string Tipo { get; set; }
        public double Cuota { get; set; }
        public double DineroApostado { get; set; }
        public int IdMercado { get; set; }
        public string EmailUsuario { get; set; }
        public int MercadoId { get; set; }
        public Mercado Mercado { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }


    }*/
}