namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_RPT_EquipoEmpleado
    {
        public int eqem_Id { get; set; }
        public int Id_Persona { get; set; }
        public string Identidad { get; set; }
        public string Nombre_Completo { get; set; }
        public string Descripcion_del_Equipo { get; set; }
        public System.DateTime Fecha { get; set; }
        public string eqtra_Descripcion { get; set; }
        public string eqtra_Codigo { get; set; }
        public string eqtra_Observacion { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime fechaFin { get; set; }
        public int eqtra_Id { get; set; }
    }
}
