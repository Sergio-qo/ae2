using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Cuenta
    {
        public int CuentaId { get; set; }
        public Usuario Usuario { get; set; }
        public string UsuarioId { get; set; }
        public string Nombre_Banco { get; set; }
        public string Num_Tarjeta { get; set; }
    }
}