using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using Npgsql;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
     NpgsqlConnection conection;

    public Service () {

    }

    
    [WebMethod]
    public List<Solicitudes> getData()
    {
        conection = new NpgsqlConnection("Server=ec2-54-159-176-167.compute-1.amazonaws.com;Port=5432; User Id=pjyghcancygocn;Password=78557542915e03c4be9c09b7dc476291aa2ba9169a6e755e4ad54d12659c8ab6;Database = d63ddgu7blih3q");
        List<Solicitudes> lista = new List<Solicitudes>();

        conection.Open();

        NpgsqlCommand cmd = new NpgsqlCommand("select * from solicitudes;", conection);

        NpgsqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            Solicitudes s = new Solicitudes();
            s.IdSolicitud = dr.GetInt16(0);
            s.IdPrestamo = dr.GetInt16(2);
            s.IdTrabajador = dr.GetInt16(3);
            //s.Estado = dr.GetBoolean(1);
            //s.Fecha = dr.GetDateTime(4);
            lista.Add(s);
        }
        dr.Close();
        conection.Open();
        return lista;
    }

    [WebMethod]
    public int HelloWorld() {
        return 1;
    }
    
}