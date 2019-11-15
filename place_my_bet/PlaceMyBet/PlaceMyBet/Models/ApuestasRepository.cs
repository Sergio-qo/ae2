using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace PlaceMyBet.Models
{
    public class ApuestasRepository
    {
        /*private MySqlConnection Connect()
        {
            string connString = "Server=localhost;Port=3306;Database=mydb;Uid=root;password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }*/
        internal List<Apuesta> Retrieve()
        {
            using (var context = new PlaceMyBetContext())
            {
                List<Apuesta> apuestas = context.Apuestas.Include(a => a.Mercado).ToList();
                return apuestas;
            }
        }

        internal Apuesta RetrieveById(int id_apuesta)
        {
            using (var context = new PlaceMyBetContext())
            {
                var apuesta = context.Apuestas
                    .FirstOrDefault(a => a.ApuestaId == id_apuesta);
                return apuesta;
            }
        }

        internal void RetrieveDTO()
        {
            /*MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from apuesta";*/
            try
            {
                /*con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<ApuestaDTO> apuestas = new List<ApuestaDTO>();
                while (reader.Read())
                {
                    apuestas.Add(new ApuestaDTO(reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5)));
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

        internal void Save(Apuesta a)
        {
            CultureInfo cullInfo = new System.Globalization.CultureInfo("es-ES");

            cullInfo.NumberFormat.NumberDecimalSeparator = ".";

            cullInfo.NumberFormat.CurrencyDecimalSeparator = ".";

            cullInfo.NumberFormat.PercentDecimalSeparator = ".";

            cullInfo.NumberFormat.CurrencyDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = cullInfo;

            ///*MySqlConnection con = Connect();
            //MySqlCommand command = con.CreateCommand();
            //command.CommandText = "insert into apuesta values(" + a.Id + "," + "'" + a.Tipo + "'" + "," + a.Cuota + "," + a.DineroApostado+","+a.IdMercado+"," + "'" + a.EmailUsuario + "'" + ");";
            //*/
            //try
            //{
            //    /*con.Open();
            //    command.ExecuteNonQuery();*/

            //}
            //catch (/*MySqlException e*/ InvalidCastException e)
            //{
            //    Console.WriteLine("Error " + e);
            //}
            ////con.Close();
            //if (a.Tipo.ToUpper() == "OVER")
            //{
            //    //command.CommandText = "UPDATE mercado SET dinero_apostado_over = dinero_apostado_over + " + a.DineroApostado + " WHERE id=" + a.IdMercado+";";
            //}
            //if (a.Tipo.ToUpper() == "UNDER")
            //{
            //    //command.CommandText = "UPDATE mercado SET dinero_apostado_under = dinero_apostado_under + " + a.DineroApostado + " WHERE id=" + a.IdMercado + ";";
            //}
            //try
            //{
            //    /*con.Open();
            //    command.ExecuteNonQuery();*/

            //}
            //catch (/*MySqlException e*/ InvalidCastException e)
            //{
            //    Console.WriteLine("Error " + e);
            //}
            ///*con.Close();
            //con.Open();
            //command.CommandText = "select dinero_apostado_over from mercado where id="+ a.IdMercado+"; ";
            //MySqlDataReader reader = command.ExecuteReader();
            //reader.Read();*/
            //double dino;
            ///*double dino = reader.GetDouble(0);
            //reader.Close();
            //con.Close();*/

            ///*con.Open();
            //command.CommandText = "select dinero_apostado_under from mercado where id=" + a.IdMercado + "; ";
            //reader = command.ExecuteReader();
            //reader.Read();*/
            //double dinu;
            ///*double dinu = reader.GetDouble(0);
            //reader.Close();
            //con.Close();*/
            //double po = 0;
            //double pu = 0;
            ///*double po = dino / (dino + dinu);
            //double pu = dinu / (dinu + dino);*/

            //double co = Convert.ToDouble((1 / po) * 0.95);
            //double cu = Convert.ToDouble((1 / pu) * 0.95);

            ////command.CommandText = "update mercado set cuota_over = '" + co + "' where id =" + a.IdMercado + ";";
            //try
            //{
            //    /*con.Open();
            //    command.ExecuteNonQuery();*/

            //}
            //catch (/*MySqlException e*/ InvalidCastException e)
            //{
            //    Console.WriteLine("Error " + e);
            //}
            ////con.Close();

            ////command.CommandText = "update mercado set cuota_under = '"+cu+"' where id ="+ a.IdMercado +"; ";
            //try
            //{
            //    /*con.Open();
            //    command.ExecuteNonQuery();*/

            //}
            //catch (/*MySqlException e*/ InvalidCastException e)
            //{
            //    Console.WriteLine("Error " + e);
            //}
            ////con.Close();
            double dino;
            double dinu;

            using (var context = new PlaceMyBetContext())
            {
                var apuestas = context.Set<Apuesta>();
                apuestas.Add(a);
                context.SaveChanges();
            }

            using (var context = new PlaceMyBetContext())
            {
                Mercado mercado = context.Mercados
                    .FirstOrDefault(m => m.MercadoId == a.MercadoId);
                dino = mercado.DineroApostadoOver;
                dinu = mercado.DineroApostadoUnder;

                double po = dino / (dino + dinu);
                double pu = dinu / (dinu + dino);
                double co = Convert.ToDouble((1 / po) * 0.95);
                double cu = Convert.ToDouble((1 / pu) * 0.95);

                mercado.CuotaOver = co;
                mercado.CuotaUnder = cu;

                if (a.Tipo.ToUpper() == "OVER")
                {
                    mercado.DineroApostadoOver = dino + a.DineroApostado;
                }
                if (a.Tipo.ToUpper() == "UNDER")
                {
                    mercado.DineroApostadoOver = dinu + a.DineroApostado;
                }

                context.SaveChanges();
            }

            

          
        }

        internal void RetrieveDTOEVME(string email)
        {
            /*MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT m.tipo, a.tipo, a.cuota, a.dinero_apostado, m.id_partido, a.id, m.id FROM apuesta a, mercado m WHERE a.id_mercado = m.id AND a.email_usuario = "+"'"+ email + "'"+";";
            */
            try
            {
                /*con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                List<ApuestaDTOEVME> apuestas = new List<ApuestaDTOEVME>();
                while (reader.Read())
                {
                    apuestas.Add(new ApuestaDTOEVME(reader.GetString(0), reader.GetInt32(4), reader.GetInt32(5), reader.GetString(1), reader.GetDouble(2), reader.GetDouble(3), reader.GetInt32(6), email));
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
    }
}