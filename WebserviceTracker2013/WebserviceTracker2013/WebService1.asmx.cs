using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebserviceTracker2013
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Name = "TrackerProjectME", Namespace = "http://http://lucasselliach.azurewebsites.net", Description = "WebService version 1.0.0")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        #region Struct_Tracker
        private lucasDataBaseEntities entities = new lucasDataBaseEntities();

        public struct Struct_Tracker
        {
            public int ID;
            public float Serial;
            public bool StatusSO;
            public string LatitudeGPS;
            public string LongitudeGPS;
            public string AltitudeGPS;
            public string VelocidadeGPS;
            public DateTime DateTimeGPS;
            public DateTime DateTimeService;
            public string NumeroDeSatelites;
            public int QualidadeSinalGPS;
            public int QualidadeSinalGSM;
            public int Observacao;
        }

        #endregion Struct_Tracker

        [WebMethod]
        public void Tracker(double Serial, bool StatusSO, string LatitudeGPS, string LongitudeGPS, string AltitudeGPS, string VelocidadeGPS, string DateTimeGPS,
                                        short NumeroDeSatelites, short QualidadeSinalGPS, short QualidadeSinalGSM, string Observacao)
        {
            Rastreadores rastreadores = new Rastreadores();

            rastreadores.Serial = Serial;
            rastreadores.StatusSO = StatusSO;
            rastreadores.LatitudeGPS = LatitudeGPS;
            rastreadores.LongitudeGPS = LongitudeGPS;
            rastreadores.AltitudeGPS = AltitudeGPS;
            rastreadores.VelocidadeGPS = VelocidadeGPS;
            rastreadores.DateTimeGPS = Convert.ToDateTime(DateTimeGPS);
            rastreadores.DateTimeService = DateTime.Now;
            rastreadores.NumeroDeSatelites = NumeroDeSatelites;
            rastreadores.QualidadeSinalGPS = QualidadeSinalGPS;
            rastreadores.QualidadeSinalGSM = QualidadeSinalGSM;
            rastreadores.Observacao = Observacao;
            entities.Rastreadores.Add(rastreadores);
            entities.SaveChanges();
        }

        [WebMethod]
        public List<Rastreadores> ResuestTracker()
        {
            var list = entities.Rastreadores.OrderByDescending(x=>x.DateTimeGPS).ToList();
            return list;
        }
    }
}
