//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_RPT_FaseSeleccion
    {
        public int fsel_Id { get; set; }
        public int per_Id { get; set; }
        public int Id_Persona { get; set; }
        public string Nombre { get; set; }
        public int fare_Id { get; set; }
        public string Fase { get; set; }
        public int req_Id { get; set; }
        public string Plaza_Solicitada { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    }
}
