using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Cuenta
    {
        public Cuenta()
        {

        }
        public Cuenta(int id, /*Usuario usuario,*/ string usuarioId, string nombreBanco, string numTarjeta)
        {
            CuentaId = id;
            /*Usuario = usuario;*/
            UsuarioId = usuarioId;
            NombreBanco = nombreBanco;
            NumTarjeta = numTarjeta;
        }

        public int CuentaId { get; set; }
        public Usuario Usuario { get; set; }
        public string UsuarioId { get; set; }
        public string NombreBanco { get; set; }
        public string NumTarjeta { get; set; }
    }
}