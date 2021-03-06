
namespace ERP_GMEDINA.Models
{
    using System;
    
    public partial class UDP_Vent_Pedido_EntreFechas_Result
    {
        public Nullable<int> clte_Id { get; set; }
        public Nullable<bool> clte_EsPersonaNatural { get; set; }
        public System.DateTime FECHA_PEDIDO { get; set; }
        public string RTN_CLIENTE { get; set; }
        public string NOMBRE_CLIENTE { get; set; }
        public string ESTADO_DEL_PEDIDO { get; set; }
        public Nullable<System.DateTime> FECHA_FACTURACIÓN { get; set; }
        public string CÓDIGO_PRODUCTO { get; set; }
        public Nullable<decimal> CANTIDAD { get; set; }
        public Nullable<decimal> CANTIDAD_FACTURADA { get; set; }
    }
}
