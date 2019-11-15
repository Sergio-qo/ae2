using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace PlaceMyBet.Models
{
    public class MercadosRepository
    {
        internal List<Mercado> Retrieve()
        {
            using (var context = new PlaceMyBetContext())
            {
                //var mercados = context.Mercados.ToList();
                List<Mercado> mercados = context.Mercados.Include(p => p.Evento).ToList();
                return mercados;
            }
        }

        internal Mercado RetrieveById(int id_mercado)
        {
            using (var context = new PlaceMyBetContext())
            {
                var mercado = context.Mercados
                    .FirstOrDefault(m => m.MercadoId == id_mercado);
                return mercado;
            }
        }

        internal void RetrieveDTO()
        {
            /*MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from mercado";*/
            try
            {
                /*con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<MercadoDTO> mercados = new List<MercadoDTO>();
                while (reader.Read())
                {
                    mercados.Add(new MercadoDTO(reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5), reader.GetInt32(6)));
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

        internal List<Mercado> RetrieveByEventoId(int id_evento)
        {
            /*MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM mercado WHERE id_partido = " + id_evento +";";*/
            try
            {
                /*con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<Mercado> mercados = new List<Mercado>();
                while (reader.Read())
                {
                    mercados.Add(new Mercado(reader.GetInt32(0), reader.GetDouble(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetString(5), reader.GetInt32(6)));
                }*/
                return null;
            }
            catch (/*MySqlException ex*/ InvalidCastException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        internal void RetrieveAP(int id_mercado)
        {
            /*MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT a.email_usuario, m.tipo, a.tipo, a.dinero_apostado, a.cuota FROM mercado m, apuesta a WHERE a.id_mercado = m.id and m.id = " + id_mercado+";";
            */
            try
            {
                /*con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<MercadoDTOAP> mercados = new List<MercadoDTOAP>();
                while (reader.Read())
                {
                    mercados.Add(new MercadoDTOAP(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(4), reader.GetDouble(3)));
                }*/
                //return null;
            }
            catch (/*MySqlException ex*/ InvalidCastException e)
            {
                Console.WriteLine(e);
                //return null;
            }
        }

        internal void Save(Mercado m)
        {
            using (var context = new PlaceMyBetContext())
            {
                var mercados = context.Set<Mercado>();
                mercados.Add(m);
                context.SaveChanges();
            }

        }
    }
}