//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    
    public partial class UDP_Inv_tbProducto_Consulta_Result
    {
        public string prod_Codigo { get; set; }
        public string prod_Descripcion { get; set; }
        public string prod_Marca { get; set; }
        public string prod_Modelo { get; set; }
        public string prod_Talla { get; set; }
        public string prod_Color { get; set; }
        public int pscat_Id { get; set; }
        public int uni_Id { get; set; }
        public int prod_UsuarioCrea { get; set; }
        public System.DateTime prod_FechaCrea { get; set; }
        public Nullable<int> prod_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> prod_FechaModifica { get; set; }
        public bool prod_EsActivo { get; set; }
        public string prod_Razon_Inactivacion { get; set; }
        public string prod_CodigoBarras { get; set; }
        public Nullable<int> prod_Correlativo { get; set; }
    }
}
