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
    
    public partial class tbHorarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbHorarios()
        {
            this.tbEmpleados = new HashSet<tbEmpleados>();
        }
    
        public int hor_Id { get; set; }
        public int jor_Id { get; set; }
        public string hor_Descripcion { get; set; }
        public System.TimeSpan hor_HoraInicio { get; set; }
        public System.TimeSpan hor_HoraFin { get; set; }
        public System.TimeSpan hor_CantidadHoras { get; set; }
        public bool hor_Estado { get; set; }
        public string hor_RazonInactivo { get; set; }
        public int hor_UsuarioCrea { get; set; }
        public System.DateTime hor_FechaCrea { get; set; }
        public Nullable<int> hor_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> hor_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbJornadas tbJornadas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
    }
}
