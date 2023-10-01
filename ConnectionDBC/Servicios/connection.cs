using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ConnectionDBC.Servicios
{
    internal class connection
    {
        public NpgsqlConnection generarConexion() 
        {
            string stringConexionPostgresql = ConfigurationManager.ConnectionStrings["stringConexion"].ConnectionString;
            Console.WriteLine("[INFORMACIÓN-ConexionPostgresqlImplementacion-generarConexionPostgresql] Cadena conexión: " + stringConexionPostgresql);
            NpgsqlConnection conn = null;
            string estado = "";

            if (!string.IsNullOrWhiteSpace(stringConexionPostgresql)) {
                try
                {
                    conn = new NpgsqlConnection(stringConexionPostgresql);
                    conn.Open();
                    //Se obtiene el estado de conexión para informarlo por consola
                    estado = conn.State.ToString();
                    if (estado.Equals("Open"))
                    {

                        Console.WriteLine("[INFORMACIÓN-ConexionPostgresqlImplementacion-generarConexionPostgresql] Estado conexión: " + estado);

                    }
                    else
                    {
                        conn = null;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("[ERROR-ConexionPostgresqlImplementacion-generarConexionPostgresql] Error al generar la conexión:" + e);
                    conn = null;
                    return conn;
                }
                    return conn;
            }
        }
    }
}
