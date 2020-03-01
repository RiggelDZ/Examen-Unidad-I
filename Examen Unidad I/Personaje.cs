using System;
using MySql.Data.MySqlClient;

namespace Examen_Unidad_I
{
    public abstract class Personaje
    {
        private string nombre, movimiento, arma;
        public EquiparArma equiparArma;
        public RealizarMovimiento realizarMovimiento;
        Conexion con = new Conexion();

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Arma { get { return arma; } set { arma = value; } }
        public string Movimiento { get { return movimiento; } set { movimiento = value; } }

        public void establecerArma(EquiparArma ea)
        {
            equiparArma = ea;
        }

        public void establecerMovimiento(RealizarMovimiento rm)
        {
            realizarMovimiento = rm;
        }

        public void ejecutarArma()
        {
            arma = equiparArma.equipar();
        }

        public void ejecutarMovimiento()
        {
            movimiento = realizarMovimiento.realizar();
        }

        public void guardarAccion()
        {
            try
            {
                con.Connection.Open();
                con.Command = new MySqlCommand("INSERT INTO log VALUES(0, @nombre, @arma, @accion, @hora);", con.Connection);
                con.Command.Parameters.AddWithValue("@nombre", Nombre);
                con.Command.Parameters.AddWithValue("@arma", Arma);
                con.Command.Parameters.AddWithValue("@accion", Movimiento);
                con.Command.Parameters.AddWithValue("@hora", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                con.Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                con.mensaje = ex.ToString();
            }
            finally
            {
                con.Connection.Close();
            }
        }
        
    }
}
