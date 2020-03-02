using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Examen_Unidad_I
{
    class ConsultaBD:Conexion
    {
        public void guardarAccion(Personaje personaje)
        {
            try
            {
                Connection.Open();
                Command = new MySqlCommand("INSERT INTO log VALUES(0, @nombre, @arma, @accion, @hora);", Connection);
                Command.Parameters.AddWithValue("@nombre", personaje.Nombre);
                Command.Parameters.AddWithValue("@arma", personaje.Arma);
                Command.Parameters.AddWithValue("@accion", personaje.Movimiento);
                Command.Parameters.AddWithValue("@hora", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            finally
            {
                Connection.Close();
            }
        }

        public DataSet buscar(string valor, string tipoBusqueda)
        {
            DataSet ds = new DataSet();
            string query="";

            query = prepararConsulta(tipoBusqueda);

            try
            {
                Connection.Open();
                Command = new MySqlCommand(query, Connection);

                if (tipoBusqueda != "Completo")
                {
                    Command.Parameters.AddWithValue("@valor", valor);
                }
                else
                {
                    valor = "";
                }

                DataAdapter = new MySqlDataAdapter(Command);
                DataAdapter.Fill(ds);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            finally
            {
                Connection.Close();
            }

            return ds;
        }

        private string prepararConsulta(string tipoBusqueda)
        {
            string q = string.Empty;
            switch (tipoBusqueda)
            {
                case "Nombre":
                    q = string.Format(
                        "SELECT NombrePersonaje, Arma, Accion, Hora " +
                        "FROM log " +
                        "WHERE NombrePersonaje = @valor");
                    break;
                case "Arma":
                    q = string.Format(
                        "SELECT NombrePersonaje, Arma, Accion, Hora " +
                        "FROM log " +
                        "WHERE Arma = @valor");
                    break;
                case "Movimiento":
                    q = string.Format(
                        "SELECT NombrePersonaje, Arma, Accion, Hora " +
                        "FROM log " +
                        "WHERE Accion = @valor");
                    break;
                case "Hora":
                    q = string.Format(
                        "SELECT NombrePersonaje, Arma, Accion, Hora " +
                        "FROM log " +
                        "WHERE HOUR(Hora)= @valor");
                    break;
                case "Completo":
                    q = string.Format(
                        "SELECT NombrePersonaje, Arma, Accion, Hora " +
                        "FROM log " +
                        "ORDER BY Hora DESC");
                    break;
            }
            return q;
        }
    }
}
