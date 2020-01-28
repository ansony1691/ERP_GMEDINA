namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbDeduccionAFP
    {
        public int dafp_Id { get; set; }
        public decimal dafp_AporteLps { get; set; }
        public int afp_Id { get; set; }
        public int emp_Id { get; set; }
        public Nullable<bool> dafp_Pagado { get; set; }
        public int dafp_UsuarioCrea { get; set; }
        public System.DateTime dafp_FechaCrea { get; set; }
        public Nullable<int> dafp_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> dafp_FechaModifica { get; set; }
        public bool dafp_Activo { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbAFP tbAFP { get; set; }
        public virtual tbEmpleados tbEmpleados { get; set; }
    }
}
