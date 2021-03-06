
namespace ERP_GMEDINA.Models
{
    using System;
    
    public partial class UDP_Vent_tbCuponDescuento_Imprimir_Result
    {
        public int cdto_ID { get; set; }
        public string suc_Descripcion { get; set; }
        public string suc_Correo { get; set; }
        public string suc_Direccion { get; set; }
        public string suc_Telefono { get; set; }
        public System.DateTime cdto_FechaEmision { get; set; }
        public System.DateTime cdto_FechaVencimiento { get; set; }
        public Nullable<decimal> cdto_PorcentajeDescuento { get; set; }
        public decimal cdto_MaximoMontoDescuento { get; set; }
        public Nullable<decimal> cdto_MontoDescuento { get; set; }
        public decimal cdto_CantidadCompraMinima { get; set; }
    }
}
