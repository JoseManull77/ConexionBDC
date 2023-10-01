using ConnectionDBC.Servicios;
using Npgsql;
using System.Configuration;
public class program 
{
    public static void Main(string[] args) 
    {
        connection con = new connection();
        con.generarConexion();

    }
}