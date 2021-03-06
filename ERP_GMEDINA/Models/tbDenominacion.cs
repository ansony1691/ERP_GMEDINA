
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbDenominacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbDenominacion()
        {
            this.tbSolicitudEfectivoDetalle = new HashSet<tbSolicitudEfectivoDetalle>();
            this.tbDenominacionArqueo = new HashSet<tbDenominacionArqueo>();
        }
    
        public short deno_Id { get; set; }
        public string deno_Descripcion { get; set; }
        public byte deno_Tipo { get; set; }
        public decimal deno_valor { get; set; }
        public short mnda_Id { get; set; }
        public int deno_UsuarioCrea { get; set; }
        public System.DateTime deno_FechaCrea { get; set; }
        public Nullable<int> deno_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> deno_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSolicitudEfectivoDetalle> tbSolicitudEfectivoDetalle { get; set; }
        public virtual tbMoneda tbMoneda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDenominacionArqueo> tbDenominacionArqueo { get; set; }
    }
}
