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
    
    public partial class V_CatalogoDeIngresos
    {
        public int cin_IdIngreso { get; set; }
        public string cin_DescripcionIngreso { get; set; }
        public int cin_UsuarioCrea { get; set; }
        public System.DateTime cin_FechaCrea { get; set; }
        public Nullable<int> cin_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> cin_FechaModifica { get; set; }
        public bool cin_Activo { get; set; }
    }
}
