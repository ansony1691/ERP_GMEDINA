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
    
    public partial class tbAccesoRol
    {
        public int acrol_Id { get; set; }
        public Nullable<int> rol_Id { get; set; }
        public Nullable<int> obj_Id { get; set; }
        public Nullable<int> acrol_UsuarioCrea { get; set; }
        public Nullable<System.DateTime> acrol_FechaCrea { get; set; }
        public Nullable<int> acrol_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> acrol_FechaModifica { get; set; }
    
        public virtual tbObjeto tbObjeto { get; set; }
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbRol tbRol { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbObjeto tbObjeto1 { get; set; }
        public virtual tbRol tbRol1 { get; set; }
        public virtual tbUsuario tbUsuario2 { get; set; }
        public virtual tbUsuario tbUsuario3 { get; set; }
    }
}
