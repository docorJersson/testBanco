using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Solicitudes
/// </summary>
public class Solicitudes
{

    private int idSolicitud;
    private int idPrestamo;
    private int idTrabajador;
    private Boolean estado;
    private DateTime fecha;

    public int IdSolicitud
    {
        get
        {
            return idSolicitud;
        }

        set
        {
            idSolicitud = value;
        }
    }

    public int IdPrestamo
    {
        get
        {
            return idPrestamo;
        }

        set
        {
            idPrestamo = value;
        }
    }

    public int IdTrabajador
    {
        get
        {
            return idTrabajador;
        }

        set
        {
            idTrabajador = value;
        }
    }

    public Boolean Estado
    {
        get
        {
            return estado;
        }

        set
        {
            estado = value;
        }
    }

    public DateTime Fecha
    {
        get
        {
            return fecha;
        }

        set
        {
            fecha = value;
        }
    }

    public Solicitudes()
    {
    }

    

}