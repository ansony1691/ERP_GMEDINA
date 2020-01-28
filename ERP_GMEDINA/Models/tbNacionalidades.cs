namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbNacionalidades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbNacionalidades()
        {
            this.tbPersonas = new HashSet<tbPersonas>();
        }
    
        public int nac_Id { get; set; }
        public string nac_Descripcion { get; set; }
        public bool nac_Estado { get; set; }
        public string nac_RazonInactivo { get; set; }
        public int nac_UsuarioCrea { get; set; }
        public System.DateTime nac_FechaCrea { get; set; }
        public Nullable<int> nac_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> nac_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPersonas> tbPersonas { get; set; }
    }
}
