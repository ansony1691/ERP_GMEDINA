
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbDevolucion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbDevolucion()
        {
            this.tbDevolucionDetalle = new HashSet<tbDevolucionDetalle>();
            this.tbNotaCredito = new HashSet<tbNotaCredito>();
        }
    
        public int dev_Id { get; set; }
        public long fact_Id { get; set; }
        public short cja_Id { get; set; }
        public string nocre_Codigo { get; set; }
        public Nullable<bool> dev_Estado { get; set; }
        public System.DateTime dev_Fecha { get; set; }
        public int dev_UsuarioCrea { get; set; }
        public System.DateTime dev_FechaCrea { get; set; }
        public Nullable<int> dev_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> dev_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbCaja tbCaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDevolucionDetalle> tbDevolucionDetalle { get; set; }
        public virtual tbFactura tbFactura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbNotaCredito> tbNotaCredito { get; set; }
    }
}
