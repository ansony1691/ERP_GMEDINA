namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_DeduccionesExtraordinarias_Detalles
    {
        public int dex_IdDeduccionesExtra { get; set; }
        public int eqem_Id { get; set; }
        public string per_Empleado { get; set; }
        public string car_Cargo { get; set; }
        public string depto_Departamento { get; set; }
        public string area_Area { get; set; }
        public string dex_ObservacionesComentarios { get; set; }
        public Nullable<int> eqtra_Id { get; set; }
        public string eqtra_Codigo { get; set; }
        public string eqtra_Descripcion { get; set; }
        public Nullable<decimal> dex_MontoInicial { get; set; }
        public Nullable<decimal> dex_MontoRestante { get; set; }
        public Nullable<decimal> dex_Cuota { get; set; }
        public int cde_IdDeducciones { get; set; }
        public string cde_DescripcionDeduccion { get; set; }
        public int dex_UsuarioCrea { get; set; }
        public string usu_UsuarioCrea { get; set; }
        public System.DateTime dex_FechaCrea { get; set; }
        public Nullable<int> dex_UsuarioModifica { get; set; }
        public string usu_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> dex_FechaModifica { get; set; }
        public bool dex_Activo { get; set; }
    }
}
