namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbTipoPermisos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbTipoPermisos()
        {
            this.tbHistorialPermisos = new HashSet<tbHistorialPermisos>();
        }
    
        public int tper_Id { get; set; }
        public string tper_Descripcion { get; set; }
        public bool tper_Estado { get; set; }
        public string tper_RazonInactivo { get; set; }
        public int tper_UsuarioCrea { get; set; }
        public System.DateTime tper_FechaCrea { get; set; }
        public Nullable<int> tper_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> tper_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialPermisos> tbHistorialPermisos { get; set; }
    }
}
