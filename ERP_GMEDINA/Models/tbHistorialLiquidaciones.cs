
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
    
public partial class tbHistorialLiquidaciones
{

    public int hliq_Id { get; set; }

    public int emp_Id { get; set; }

    public System.DateTime hliq_fechaIngreso { get; set; }

    public System.DateTime hliq_fechaLiquidacion { get; set; }

    public int hliq_PorcentajeLiquidacion { get; set; }

    public string hliq_Observaciones { get; set; }

    public bool hliq_Estado { get; set; }

    public string hliq_RazonInactivo { get; set; }

    public int hliq_UsuarioCrea { get; set; }

    public System.DateTime hliq_FechaCrea { get; set; }

    public Nullable<int> hliq_UsuarioModifica { get; set; }

    public Nullable<System.DateTime> hliq_FechaModifica { get; set; }



    public virtual tbUsuario tbUsuario { get; set; }

    public virtual tbUsuario tbUsuario1 { get; set; }

    public virtual tbEmpleados tbEmpleados { get; set; }

}

}
