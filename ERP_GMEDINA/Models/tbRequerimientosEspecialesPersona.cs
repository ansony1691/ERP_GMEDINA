
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbRequerimientosEspecialesPersona
    {
        public int rep_Id { get; set; }
        public int per_Id { get; set; }
        public int resp_Id { get; set; }
        public bool rep_Estado { get; set; }
        public string rep_RazonInactivo { get; set; }
        public int rep_UsuarioCrea { get; set; }
        public System.DateTime rep_FechaCrea { get; set; }
        public Nullable<int> rep_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> rep_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbPersonas tbPersonas { get; set; }
        public virtual tbRequerimientosEspeciales tbRequerimientosEspeciales { get; set; }
    }
}
