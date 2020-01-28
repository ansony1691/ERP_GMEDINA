namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_HistorialHorasTrabajadas
    {
        public int Id { get; set; }
        public string Nombre_Completo { get; set; }
        public string Departamento { get; set; }
        public string Area { get; set; }
        public string Cargo { get; set; }
        public string Jornada { get; set; }
        public string Tipo_Horas { get; set; }
        public int Cantidad { get; set; }
        public int Recargo { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Usuario_Crea { get; set; }
        public System.DateTime Fecha_Crea { get; set; }
        public string Usuario_Modifica { get; set; }
        public Nullable<System.DateTime> Fecha_Modifica { get; set; }
    }
}
