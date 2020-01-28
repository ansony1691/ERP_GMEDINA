namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_DeduccionesInstitucionesFinancierasColaboradres
    {
        public int deif_IdDeduccionInstFinanciera { get; set; }
        public int emp_Id { get; set; }
        public Nullable<decimal> deif_Monto { get; set; }
        public string deif_Comentarios { get; set; }
        public int deif_UsuarioCrea { get; set; }
        public System.DateTime deif_FechaCrea { get; set; }
        public Nullable<int> deif_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> deif_FechaModifica { get; set; }
        public bool deif_Activo { get; set; }
        public int insf_IdInstitucionFinanciera { get; set; }
        public string insf_DescInstitucionFinanc { get; set; }
        public string cde_DescripcionDeduccion { get; set; }
    }
}
