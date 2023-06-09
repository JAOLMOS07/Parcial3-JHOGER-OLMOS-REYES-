using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class Repositorio : ConnectionManager
    {
        public Repositorio(string connectionString) : base(connectionString)
        {
        }

        public string Insert(string insertado)
        {
            Open();
            OracleCommand command = new OracleCommand("ingresar_proveedor", conexion);
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.Add("v_id_proveedor", OracleType.VarChar).Value = proveedor.id;
            //command.Parameters.Add("v_nombre_proveedor", OracleType.VarChar).Value = proveedor.nombre;
            //command.Parameters.Add("v_telefono_proveedor", OracleType.VarChar).Value = proveedor.telefono;
            //command.Parameters.Add("v_correo", OracleType.VarChar).Value = proveedor.correo;
            command.ExecuteNonQuery();
            Close();
        
            return "ingresado";
        }

        public List<string> obtenerstringes()
        {
            List<string> stringes = new List<string>();
            OracleCommand command = new OracleCommand("obtener_stringes", conexion);
            command.CommandType = CommandType.StoredProcedure;

            OracleParameter resultCursor = new OracleParameter();
            resultCursor.ParameterName = "result_cursor";
            resultCursor.OracleType = OracleType.Cursor;
            resultCursor.Direction = ParameterDirection.ReturnValue;

            command.Parameters.Add(resultCursor);

            Open();
            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
               

                stringes.Add(" ");
            }

            reader.Close();
            Close();





            return stringes;
        }


    }
}
