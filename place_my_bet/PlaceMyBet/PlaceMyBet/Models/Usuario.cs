using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Usuario
    {
        public List<Apuesta> Apuesta { get; set; }
        public Cuenta Cuenta { get; set; }
        public int UsuarioId { get; set; }
    }
}