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
    using System.Collections.Generic;
    
    public partial class tbSucursal
    {
        public int suc_Id { get; set; }
        public string mun_Codigo { get; set; }
        public int bod_Id { get; set; }
        public int pemi_Id { get; set; }
        public string suc_Descripcion { get; set; }
        public string suc_Correo { get; set; }
        public string suc_Direccion { get; set; }
        public string suc_Telefono { get; set; }
        public int suc_UsuarioCrea { get; set; }
        public System.DateTime suc_FechaCrea { get; set; }
        public Nullable<int> suc_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> suc_FechaModifica { get; set; }
    }
}
