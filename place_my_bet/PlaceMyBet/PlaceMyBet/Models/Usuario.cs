using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Usuario
    {
        public Usuario()
        {

        }
        public Usuario(/*List<Apuesta> apuestas,*/ /*Cuenta cuenta,*/ string id, int edad, string nombre, string apellidos)
        {
            /*Apuestas = apuestas;*/
            /*Cuenta = cuenta;*/
            UsuarioId = id;
            Edad = edad;
            Nombre = nombre;
            Apellidos = apellidos;
        }
        public List<Apuesta> Apuestas { get; set; }
        public Cuenta Cuenta { get; set; }
        public string UsuarioId { get; set; }
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
    }
}