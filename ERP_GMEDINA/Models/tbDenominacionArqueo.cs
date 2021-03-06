
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbDenominacionArqueo
    {
        public int arqde_Id { get; set; }
        public int mocja_Id { get; set; }
        public short deno_Id { get; set; }
        public short arqde_CantidadDenominacion { get; set; }
        public decimal arqde_MontoDenominacion { get; set; }
        public int arqde_UsuarioCrea { get; set; }
        public System.DateTime arqde_FechaCrea { get; set; }
        public Nullable<int> arqde_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> arqde_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbDenominacion tbDenominacion { get; set; }
        public virtual tbMovimientoCaja tbMovimientoCaja { get; set; }
    }
}
