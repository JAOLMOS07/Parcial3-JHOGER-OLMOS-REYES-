﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OracleClient;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class ConnectionManager
    {
        public OracleConnection conexion;
        public ConnectionManager(string connectionString)
        {
            conexion = new OracleConnection(connectionString);

        }
        public void Open()
        {
            conexion.Open();
            Console.WriteLine("Conexion abierta");
        }
        public void Close()
        {
            conexion.Close();
            Console.WriteLine("Conexion cerrada");
        }
    }
}
