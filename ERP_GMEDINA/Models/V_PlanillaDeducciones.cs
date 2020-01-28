namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_PlanillaDeducciones
    {
        public int cpla_IdPlanilla { get; set; }
        public string cpla_DescripcionPlanilla { get; set; }
        public int cpla_FrecuenciaEnDias { get; set; }
        public int tpdd_IdPlanillaDetDeduccion { get; set; }
        public int cde_IdDeducciones { get; set; }
        public string cde_DescripcionDeduccion { get; set; }
        public int tde_IdTipoDedu { get; set; }
        public string tde_Descripcion { get; set; }
        public Nullable<decimal> cde_PorcentajeColaborador { get; set; }
        public Nullable<decimal> cde_PorcentajeEmpresa { get; set; }
    }
}
