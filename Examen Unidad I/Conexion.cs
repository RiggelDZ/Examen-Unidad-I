using System;
using MySql.Data.MySqlClient;

namespace Examen_Unidad_I
{
    class Conexion
    {
        public string conexion, mensaje;
        protected MySqlConnection connection;
        protected MySqlCommand command;
        protected MySqlDataReader datareader;
        protected MySqlDataAdapter dataadapter;

        public MySqlConnection Connection { get { return connection; } set { connection = value; } }
        public MySqlCommand Command { get { return command; } set { command = value; } }
        public MySqlDataReader DataReader { get { return datareader; } set { datareader = value; } }
        public MySqlDataAdapter DataAdapter { get { return dataadapter; } set { dataadapter = value; } }

        public Conexion()
        {
            conexion = ("server=remotemysql.com; database=YWmTmRf5zD; Uid=YWmTmRf5zD ; pwd=rdolyIAWft");
            connection = new MySqlConnection(conexion);
        }
    }
}
