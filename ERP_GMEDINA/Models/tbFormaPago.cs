namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbFormaPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbFormaPago()
        {
            this.tbEmpleados = new HashSet<tbEmpleados>();
        }
    
        public int fpa_IdFormaPago { get; set; }
        public string fpa_Descripcion { get; set; }
        public int fpa_UsuarioCrea { get; set; }
        public System.DateTime fpa_FechaCrea { get; set; }
        public Nullable<int> fpa_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> fpa_FechaModifica { get; set; }
        public bool fpa_Activo { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
    }
}
