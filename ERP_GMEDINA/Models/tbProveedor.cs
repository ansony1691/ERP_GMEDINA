
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbProveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbProveedor()
        {
            this.tbEntrada = new HashSet<tbEntrada>();
            this.tbProducto = new HashSet<tbProducto>();
        }
    
        public int prov_Id { get; set; }
        public string prov_Nombre { get; set; }
        public string prov_NombreContacto { get; set; }
        public string prov_Direccion { get; set; }
        public string prov_Email { get; set; }
        public string prov_Telefono { get; set; }
        public int prov_UsuarioCrea { get; set; }
        public System.DateTime prov_FechaCrea { get; set; }
        public Nullable<int> prov_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> prov_FechaModifica { get; set; }
        public string prov_RTN { get; set; }
        public Nullable<short> acte_Id { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbActividadEconomica tbActividadEconomica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEntrada> tbEntrada { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbProducto> tbProducto { get; set; }
    }
}