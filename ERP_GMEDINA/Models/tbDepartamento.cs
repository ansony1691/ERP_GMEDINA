
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbDepartamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbDepartamento()
        {
            this.tbMunicipio = new HashSet<tbMunicipio>();
        }
    
        public string dep_Codigo { get; set; }
        public string dep_Nombre { get; set; }
        public int dep_UsuarioCrea { get; set; }
        public System.DateTime dep_FechaCrea { get; set; }
        public Nullable<int> dep_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> dep_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbMunicipio> tbMunicipio { get; set; }
    }
}
