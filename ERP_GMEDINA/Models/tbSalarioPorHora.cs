
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
    
public partial class tbSalarioPorHora
{

    public int saph_Idsaph { get; set; }

    public int rama_Id { get; set; }

    public Nullable<decimal> saph_SalarioMinimo { get; set; }

    public int jor_Id { get; set; }

    public Nullable<decimal> saph_Monto { get; set; }

    public int saph_TamanoEmpresaInicial { get; set; }

    public int saph_TamanoEmpresaFinal { get; set; }

    public int saph_UsuarioCrea { get; set; }

    public System.DateTime saph_FechaCrea { get; set; }

    public Nullable<int> saph_UsuarioModifica { get; set; }

    public Nullable<System.DateTime> saph_FechaModifica { get; set; }

    public bool saph_Activo { get; set; }



    public virtual tbUsuario tbUsuario { get; set; }

    public virtual tbUsuario tbUsuario1 { get; set; }

    public virtual tbRamaActividad tbRamaActividad { get; set; }

    public virtual tbJornadas tbJornadas { get; set; }

}

}
