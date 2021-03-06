
namespace ERP_GMEDINA.Models
{
    using System;
    
    public partial class UDP_Vent_tbPago_Imprimir_Result
    {
        public int pago_Id { get; set; }
        public long fact_Id { get; set; }
        public string fact_Codigo { get; set; }
        public string clte_Identificacion { get; set; }
        public string clte_Nombres { get; set; }
        public string tpa_Descripcion { get; set; }
        public System.DateTime pago_FechaElaboracion { get; set; }
        public decimal pago_SaldoAnterior { get; set; }
        public decimal pago_TotalPago { get; set; }
        public Nullable<decimal> pago_MontoEfectivo { get; set; }
        public Nullable<decimal> pago_TotalCambio { get; set; }
        public string pago_Emisor { get; set; }
        public string pago_Titular { get; set; }
    }
}
