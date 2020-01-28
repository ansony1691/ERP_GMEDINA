namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_tbCatalogoDeDeducciones
    {
        public int cde_IdDeducciones { get; set; }
        public string cde_DescripcionDeduccion { get; set; }
        public int tde_IdTipoDedu { get; set; }
        public Nullable<decimal> cde_PorcentajeColaborador { get; set; }
        public Nullable<decimal> cde_PorcentajeEmpresa { get; set; }
        public int cde_UsuarioCrea { get; set; }
        public System.DateTime cde_FechaCrea { get; set; }
        public Nullable<int> cde_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> cde_FechaModifica { get; set; }
        public bool cde_Activo { get; set; }
    }
}
