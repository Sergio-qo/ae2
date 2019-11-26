using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class EventosRepository
    {
        
        internal List<Evento> Retrieve()
        {
            using (var context = new PlaceMyBetContext())
            {
                var eventos = context.Eventos.ToList();
                return eventos;
            }
        }

        internal void RetrieveDTO()
        {
            /*MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from partido";*/
            try
            {
                /*con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<EventoDTO> eventos = new List<EventoDTO>();
                while (reader.Read())
                {
                    eventos.Add(new EventoDTO(reader.GetString(1), reader.GetString(2)));
                }
                con.Close();*/
                //return null;
            }
            catch (/*MySqlException ex*/ InvalidCastException e)
            {
                Console.WriteLine("Se ha producido un error: " + e);
                //return null;
            }
        }

        internal void Delete(int id)
        {
            using (var context = new PlaceMyBetContext())
            {
                context.Eventos.Remove(context.Eventos.FirstOrDefault(e => e.EventoId == id));
                context.SaveChanges();
            }
        }

        internal void Update(int id, string equipol, string equipov)
        {
            using (var context = new PlaceMyBetContext())
            {
                Evento evento = context.Eventos.FirstOrDefault(e => e.EventoId == id);
                evento.EquipoL = equipol;
                evento.EquipoV = equipov;
                context.SaveChanges();
            }
        }
    }
}