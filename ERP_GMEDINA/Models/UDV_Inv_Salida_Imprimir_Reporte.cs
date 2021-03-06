
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UDV_Inv_Salida_Imprimir_Reporte
    {
        public Nullable<System.DateTime> sal_FechaElaboracion { get; set; }
        public Nullable<byte> tsal_Id { get; set; }
        public string tsal_Descripcion { get; set; }
        public Nullable<int> bod_Id { get; set; }
        public string bod_Nombre { get; set; }
        public Nullable<byte> estm_Id { get; set; }
        public string estm_Descripcion { get; set; }
        public string sal_BodDestino { get; set; }
        public string fact_Codigo { get; set; }
        public string bod_ResponsableBodega { get; set; }
        public string prod_Codigo { get; set; }
        public string prod_Descripcion { get; set; }
        public string prod_Marca { get; set; }
        public string prod_Modelo { get; set; }
        public string prod_Talla { get; set; }
        public string prod_Color { get; set; }
        public string pcat_Nombre { get; set; }
        public string pscat_Descripcion { get; set; }
        public string uni_Descripcion { get; set; }
        public string prod_CodigoBarras { get; set; }
        public decimal sald_Cantidad { get; set; }
    }
}
