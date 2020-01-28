namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbRequerimientosEspeciales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbRequerimientosEspeciales()
        {
            this.tbRequerimientosEspecialesPersona = new HashSet<tbRequerimientosEspecialesPersona>();
            this.tbRequerimientosEspecialesRequisicion = new HashSet<tbRequerimientosEspecialesRequisicion>();
        }
    
        public int resp_Id { get; set; }
        public string resp_Descripcion { get; set; }
        public bool resp_Estado { get; set; }
        public string resp_RazonInactivo { get; set; }
        public int resp_UsuarioCrea { get; set; }
        public System.DateTime resp_FechaCrea { get; set; }
        public Nullable<int> resp_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> resp_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRequerimientosEspecialesPersona> tbRequerimientosEspecialesPersona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRequerimientosEspecialesRequisicion> tbRequerimientosEspecialesRequisicion { get; set; }
    }
}
