//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebserviceTracker2013
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rastreadores
    {
        public int ID { get; set; }
        public double Serial { get; set; }
        public bool StatusSO { get; set; }
        public string LatitudeGPS { get; set; }
        public string LongitudeGPS { get; set; }
        public string AltitudeGPS { get; set; }
        public string VelocidadeGPS { get; set; }
        public System.DateTime DateTimeGPS { get; set; }
        public System.DateTime DateTimeService { get; set; }
        public short NumeroDeSatelites { get; set; }
        public short QualidadeSinalGPS { get; set; }
        public short QualidadeSinalGSM { get; set; }
        public string Observacao { get; set; }
    }
}
