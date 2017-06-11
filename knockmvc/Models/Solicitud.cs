using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace knockmvc.Models
{
    public class Solicitud
    {
        public int IdSolicitud { get; set; }
        public string Tipo { get; set; }
        public List<SolicitudDependencia> SolicitudDependencia { get; set; }
    }

    public class SolicitudDependencia
    {
        public int idDependencia { get; set; }
        public string Nombre { get; set; }
        public string FechaDesde { get; set; }
        public string FechaHasta { get; set; }
        public int IdSolicitud { get; set; }
    }

    public class RepositorySolicitud
    {
        private static Solicitud sol = new Solicitud() { 
        
            IdSolicitud=1,
            Tipo="Carga-Datos",
            SolicitudDependencia = new List<SolicitudDependencia>
            {
                new SolicitudDependencia(){idDependencia=1,Nombre="Economicas",FechaDesde="2015/05/20",FechaHasta="2018/02/01"},
                new SolicitudDependencia(){idDependencia=1,Nombre="Agrarias",FechaDesde="2015/05/20",FechaHasta="2018/02/01"},
                new SolicitudDependencia(){idDependencia=1,Nombre="Exactas",FechaDesde="2015/05/20",FechaHasta="2018/02/01"}
            }
           
        
        };


        public static Solicitud GetSolicitud()
        {
            return sol;
        }
    }

    
}