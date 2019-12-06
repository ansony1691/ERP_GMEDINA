﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ERP_GMEDINAEntities : DbContext
    {
        public ERP_GMEDINAEntities()
            : base("name=ERP_GMEDINAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbAccesoRol> tbAccesoRol { get; set; }
        public virtual DbSet<tbObjeto> tbObjeto { get; set; }
        public virtual DbSet<tbRol> tbRol { get; set; }
        public virtual DbSet<tbRolesUsuario> tbRolesUsuario { get; set; }
        public virtual DbSet<tbUsuario> tbUsuario { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbAcumuladosISR> tbAcumuladosISR { get; set; }
        public virtual DbSet<tbAdelantoSueldo> tbAdelantoSueldo { get; set; }
        public virtual DbSet<tbAFP> tbAFP { get; set; }
        public virtual DbSet<tbAuxilioDeCesantias> tbAuxilioDeCesantias { get; set; }
        public virtual DbSet<tbCatalogoDeDeducciones> tbCatalogoDeDeducciones { get; set; }
        public virtual DbSet<tbCatalogoDeIngresos> tbCatalogoDeIngresos { get; set; }
        public virtual DbSet<tbCatalogoDePlanillas> tbCatalogoDePlanillas { get; set; }
        public virtual DbSet<tbDecimoCuartoMes> tbDecimoCuartoMes { get; set; }
        public virtual DbSet<tbDecimoTercerMes> tbDecimoTercerMes { get; set; }
        public virtual DbSet<tbDeduccionAFP> tbDeduccionAFP { get; set; }
        public virtual DbSet<tbDeduccionesExtraordinarias> tbDeduccionesExtraordinarias { get; set; }
        public virtual DbSet<tbDeduccionInstitucionFinanciera> tbDeduccionInstitucionFinanciera { get; set; }
        public virtual DbSet<tbEmpleadoBonos> tbEmpleadoBonos { get; set; }
        public virtual DbSet<tbEmpleadoComisiones> tbEmpleadoComisiones { get; set; }
        public virtual DbSet<tbFormaPago> tbFormaPago { get; set; }
        public virtual DbSet<tbHistorialDeduccionPago> tbHistorialDeduccionPago { get; set; }
        public virtual DbSet<tbHistorialDeIngresosPago> tbHistorialDeIngresosPago { get; set; }
        public virtual DbSet<tbHistorialDePago> tbHistorialDePago { get; set; }
        public virtual DbSet<tbHistorialLiquidaciones> tbHistorialLiquidaciones { get; set; }
        public virtual DbSet<tbInstitucionesFinancieras> tbInstitucionesFinancieras { get; set; }
        public virtual DbSet<tbISR> tbISR { get; set; }
        public virtual DbSet<tbLiquidaciones> tbLiquidaciones { get; set; }
        public virtual DbSet<tbLiquidacionVacaciones> tbLiquidacionVacaciones { get; set; }
        public virtual DbSet<tbMotivoLiquidaciones> tbMotivoLiquidaciones { get; set; }
        public virtual DbSet<tbPeriodos> tbPeriodos { get; set; }
        public virtual DbSet<tbPreaviso> tbPreaviso { get; set; }
        public virtual DbSet<tbRamaActividad> tbRamaActividad { get; set; }
        public virtual DbSet<tbSalarioPorHora> tbSalarioPorHora { get; set; }
        public virtual DbSet<tbTechosDeducciones> tbTechosDeducciones { get; set; }
        public virtual DbSet<tbTipoDeduccion> tbTipoDeduccion { get; set; }
        public virtual DbSet<tbTipoPlanillaDetalleDeduccion> tbTipoPlanillaDetalleDeduccion { get; set; }
        public virtual DbSet<tbTipoPlanillaDetalleIngreso> tbTipoPlanillaDetalleIngreso { get; set; }
        public virtual DbSet<tbAreas> tbAreas { get; set; }
        public virtual DbSet<tbCargos> tbCargos { get; set; }
        public virtual DbSet<tbCompetencias> tbCompetencias { get; set; }
        public virtual DbSet<tbCompetenciasPersona> tbCompetenciasPersona { get; set; }
        public virtual DbSet<tbCompetenciasRequisicion> tbCompetenciasRequisicion { get; set; }
        public virtual DbSet<tbDepartamentos> tbDepartamentos { get; set; }
        public virtual DbSet<tbEmpleados> tbEmpleados { get; set; }
        public virtual DbSet<tbEmpresas> tbEmpresas { get; set; }
        public virtual DbSet<tbEquipoEmpleados> tbEquipoEmpleados { get; set; }
        public virtual DbSet<tbEquipoTrabajo> tbEquipoTrabajo { get; set; }
        public virtual DbSet<tbFaseSeleccion> tbFaseSeleccion { get; set; }
        public virtual DbSet<tbFasesReclutamiento> tbFasesReclutamiento { get; set; }
        public virtual DbSet<tbHabilidades> tbHabilidades { get; set; }
        public virtual DbSet<tbHabilidadesPersona> tbHabilidadesPersona { get; set; }
        public virtual DbSet<tbHabilidadesRequisicion> tbHabilidadesRequisicion { get; set; }
        public virtual DbSet<tbHistorialAmonestaciones> tbHistorialAmonestaciones { get; set; }
        public virtual DbSet<tbHistorialAudienciaDescargo> tbHistorialAudienciaDescargo { get; set; }
        public virtual DbSet<tbHistorialCargos> tbHistorialCargos { get; set; }
        public virtual DbSet<tbHistorialContrataciones> tbHistorialContrataciones { get; set; }
        public virtual DbSet<tbHistorialHorasTrabajadas> tbHistorialHorasTrabajadas { get; set; }
        public virtual DbSet<tbHistorialIncapacidades> tbHistorialIncapacidades { get; set; }
        public virtual DbSet<tbHistorialPermisos> tbHistorialPermisos { get; set; }
        public virtual DbSet<tbHistorialRefrendamientos> tbHistorialRefrendamientos { get; set; }
        public virtual DbSet<tbHistorialSalidas> tbHistorialSalidas { get; set; }
        public virtual DbSet<tbHistorialVacaciones> tbHistorialVacaciones { get; set; }
        public virtual DbSet<tbHorarios> tbHorarios { get; set; }
        public virtual DbSet<tbIdiomaPersona> tbIdiomaPersona { get; set; }
        public virtual DbSet<tbIdiomas> tbIdiomas { get; set; }
        public virtual DbSet<tbIdiomasRequisicion> tbIdiomasRequisicion { get; set; }
        public virtual DbSet<tbJornadas> tbJornadas { get; set; }
        public virtual DbSet<tbNacionalidades> tbNacionalidades { get; set; }
        public virtual DbSet<tbPersonas> tbPersonas { get; set; }
        public virtual DbSet<tbPrestaciones> tbPrestaciones { get; set; }
        public virtual DbSet<tbRazonSalidas> tbRazonSalidas { get; set; }
        public virtual DbSet<tbRequerimientosEspeciales> tbRequerimientosEspeciales { get; set; }
        public virtual DbSet<tbRequerimientosEspecialesPersona> tbRequerimientosEspecialesPersona { get; set; }
        public virtual DbSet<tbRequerimientosEspecialesRequisicion> tbRequerimientosEspecialesRequisicion { get; set; }
        public virtual DbSet<tbRequisiciones> tbRequisiciones { get; set; }
        public virtual DbSet<tbSeleccionCandidatos> tbSeleccionCandidatos { get; set; }
        public virtual DbSet<tbSucursales> tbSucursales { get; set; }
        public virtual DbSet<tbSueldos> tbSueldos { get; set; }
        public virtual DbSet<tbTipoAmonestaciones> tbTipoAmonestaciones { get; set; }
        public virtual DbSet<tbTipoHoras> tbTipoHoras { get; set; }
        public virtual DbSet<tbTipoIncapacidades> tbTipoIncapacidades { get; set; }
        public virtual DbSet<tbTipoMonedas> tbTipoMonedas { get; set; }
        public virtual DbSet<tbTipoPermisos> tbTipoPermisos { get; set; }
        public virtual DbSet<tbTipoSalidas> tbTipoSalidas { get; set; }
        public virtual DbSet<tbTitulos> tbTitulos { get; set; }
        public virtual DbSet<tbTitulosPersona> tbTitulosPersona { get; set; }
        public virtual DbSet<tbTitulosRequisicion> tbTitulosRequisicion { get; set; }
        public virtual DbSet<V_AFP_RPT> V_AFP_RPT { get; set; }
        public virtual DbSet<V_BonosColaborador> V_BonosColaborador { get; set; }
        public virtual DbSet<V_CatalogoDeIngresos> V_CatalogoDeIngresos { get; set; }
        public virtual DbSet<V_CatalogoDePlanillasConIngresosYDeducciones> V_CatalogoDePlanillasConIngresosYDeducciones { get; set; }
        public virtual DbSet<V_ColaboradoresPorPlanilla> V_ColaboradoresPorPlanilla { get; set; }
        public virtual DbSet<V_ComisionesColaborador> V_ComisionesColaborador { get; set; }
        public virtual DbSet<V_DecimoCuartoMes> V_DecimoCuartoMes { get; set; }
        public virtual DbSet<V_DecimoCuartoMes_RPT> V_DecimoCuartoMes_RPT { get; set; }
        public virtual DbSet<V_DecimoTercerMes> V_DecimoTercerMes { get; set; }
        public virtual DbSet<V_DecimoTercerMes_RPT> V_DecimoTercerMes_RPT { get; set; }
        public virtual DbSet<V_DeduccionesExtraordinarias> V_DeduccionesExtraordinarias { get; set; }
        public virtual DbSet<V_DeduccionesExtraordinarias_Detalles> V_DeduccionesExtraordinarias_Detalles { get; set; }
        public virtual DbSet<V_DeduccionesExtraordinarias_Empleados> V_DeduccionesExtraordinarias_Empleados { get; set; }
        public virtual DbSet<V_DeduccionesExtraordinarias_EquipoEmpleado> V_DeduccionesExtraordinarias_EquipoEmpleado { get; set; }
        public virtual DbSet<V_DeduccionesExtrasColaboradores> V_DeduccionesExtrasColaboradores { get; set; }
        public virtual DbSet<V_DeduccionesInstitucionesFinancierasColaboradres> V_DeduccionesInstitucionesFinancierasColaboradres { get; set; }
        public virtual DbSet<V_EmpleadoBonos> V_EmpleadoBonos { get; set; }
        public virtual DbSet<V_FormaDePago> V_FormaDePago { get; set; }
        public virtual DbSet<V_GeneralTotales_RPT> V_GeneralTotales_RPT { get; set; }
        public virtual DbSet<V_IHSS_RPT> V_IHSS_RPT { get; set; }
        public virtual DbSet<V_INFOP_RPT> V_INFOP_RPT { get; set; }
        public virtual DbSet<V_InformacionColaborador> V_InformacionColaborador { get; set; }
        public virtual DbSet<V_InstitucionesFinancieras_RPT> V_InstitucionesFinancieras_RPT { get; set; }
        public virtual DbSet<V_ISR_RPT> V_ISR_RPT { get; set; }
        public virtual DbSet<V_Liquidaciones_RPT> V_Liquidaciones_RPT { get; set; }
        public virtual DbSet<V_Plani_EmpleadoPorPlanilla> V_Plani_EmpleadoPorPlanilla { get; set; }
        public virtual DbSet<V_Plani_FechaPlani> V_Plani_FechaPlani { get; set; }
        public virtual DbSet<V_Plani_FechaPlanilla> V_Plani_FechaPlanilla { get; set; }
        public virtual DbSet<V_Plani_TipoPlani> V_Plani_TipoPlani { get; set; }
        public virtual DbSet<V_PlanillaDeducciones> V_PlanillaDeducciones { get; set; }
        public virtual DbSet<V_PlanillaIngresos> V_PlanillaIngresos { get; set; }
        public virtual DbSet<V_PreviewPlanilla> V_PreviewPlanilla { get; set; }
        public virtual DbSet<V_RAP_RPT> V_RAP_RPT { get; set; }
        public virtual DbSet<V_tbAdelantoSueldo> V_tbAdelantoSueldo { get; set; }
        public virtual DbSet<V_tbCatalogoDeDeducciones> V_tbCatalogoDeDeducciones { get; set; }
        public virtual DbSet<V_tbCatalogoDeIngresos> V_tbCatalogoDeIngresos { get; set; }
        public virtual DbSet<V_tbEmpleadoComisiones> V_tbEmpleadoComisiones { get; set; }
        public virtual DbSet<V_TipoDeduccion> V_TipoDeduccion { get; set; }
    
        public virtual ObjectResult<UDP_Plani_EmpleadoComisiones_Activar_Result> UDP_Plani_EmpleadoComisiones_Activar(Nullable<int> cc_Id, Nullable<int> cc_UsuarioModifica, Nullable<System.DateTime> cc_FechaModifcia)
        {
            var cc_IdParameter = cc_Id.HasValue ?
                new ObjectParameter("cc_Id", cc_Id) :
                new ObjectParameter("cc_Id", typeof(int));
    
            var cc_UsuarioModificaParameter = cc_UsuarioModifica.HasValue ?
                new ObjectParameter("cc_UsuarioModifica", cc_UsuarioModifica) :
                new ObjectParameter("cc_UsuarioModifica", typeof(int));
    
            var cc_FechaModifciaParameter = cc_FechaModifcia.HasValue ?
                new ObjectParameter("cc_FechaModifcia", cc_FechaModifcia) :
                new ObjectParameter("cc_FechaModifcia", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Plani_EmpleadoComisiones_Activar_Result>("UDP_Plani_EmpleadoComisiones_Activar", cc_IdParameter, cc_UsuarioModificaParameter, cc_FechaModifciaParameter);
        }
    
        public virtual ObjectResult<UDP_Plani_EmpleadoComisiones_Inactivar_Result> UDP_Plani_EmpleadoComisiones_Inactivar(Nullable<int> cc_Id, Nullable<int> cc_UsuarioModifica, Nullable<System.DateTime> cc_FechaModifcia)
        {
            var cc_IdParameter = cc_Id.HasValue ?
                new ObjectParameter("cc_Id", cc_Id) :
                new ObjectParameter("cc_Id", typeof(int));
    
            var cc_UsuarioModificaParameter = cc_UsuarioModifica.HasValue ?
                new ObjectParameter("cc_UsuarioModifica", cc_UsuarioModifica) :
                new ObjectParameter("cc_UsuarioModifica", typeof(int));
    
            var cc_FechaModifciaParameter = cc_FechaModifcia.HasValue ?
                new ObjectParameter("cc_FechaModifcia", cc_FechaModifcia) :
                new ObjectParameter("cc_FechaModifcia", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Plani_EmpleadoComisiones_Inactivar_Result>("UDP_Plani_EmpleadoComisiones_Inactivar", cc_IdParameter, cc_UsuarioModificaParameter, cc_FechaModifciaParameter);
        }
    
        public virtual ObjectResult<UDP_Plani_EmpleadoComisiones_Insert_Result> UDP_Plani_EmpleadoComisiones_Insert(Nullable<int> emp_Id, Nullable<int> cin_IdIngreso, Nullable<System.DateTime> cc_FechaRegistro, Nullable<bool> cc_Pagado, Nullable<int> cc_UsuarioCrea, Nullable<System.DateTime> cc_FechaCrea, Nullable<decimal> cc_PorcentajeComision, Nullable<decimal> cc_TotalVenta)
        {
            var emp_IdParameter = emp_Id.HasValue ?
                new ObjectParameter("emp_Id", emp_Id) :
                new ObjectParameter("emp_Id", typeof(int));
    
            var cin_IdIngresoParameter = cin_IdIngreso.HasValue ?
                new ObjectParameter("cin_IdIngreso", cin_IdIngreso) :
                new ObjectParameter("cin_IdIngreso", typeof(int));
    
            var cc_FechaRegistroParameter = cc_FechaRegistro.HasValue ?
                new ObjectParameter("cc_FechaRegistro", cc_FechaRegistro) :
                new ObjectParameter("cc_FechaRegistro", typeof(System.DateTime));
    
            var cc_PagadoParameter = cc_Pagado.HasValue ?
                new ObjectParameter("cc_Pagado", cc_Pagado) :
                new ObjectParameter("cc_Pagado", typeof(bool));
    
            var cc_UsuarioCreaParameter = cc_UsuarioCrea.HasValue ?
                new ObjectParameter("cc_UsuarioCrea", cc_UsuarioCrea) :
                new ObjectParameter("cc_UsuarioCrea", typeof(int));
    
            var cc_FechaCreaParameter = cc_FechaCrea.HasValue ?
                new ObjectParameter("cc_FechaCrea", cc_FechaCrea) :
                new ObjectParameter("cc_FechaCrea", typeof(System.DateTime));
    
            var cc_PorcentajeComisionParameter = cc_PorcentajeComision.HasValue ?
                new ObjectParameter("cc_PorcentajeComision", cc_PorcentajeComision) :
                new ObjectParameter("cc_PorcentajeComision", typeof(decimal));
    
            var cc_TotalVentaParameter = cc_TotalVenta.HasValue ?
                new ObjectParameter("cc_TotalVenta", cc_TotalVenta) :
                new ObjectParameter("cc_TotalVenta", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Plani_EmpleadoComisiones_Insert_Result>("UDP_Plani_EmpleadoComisiones_Insert", emp_IdParameter, cin_IdIngresoParameter, cc_FechaRegistroParameter, cc_PagadoParameter, cc_UsuarioCreaParameter, cc_FechaCreaParameter, cc_PorcentajeComisionParameter, cc_TotalVentaParameter);
        }
    
        public virtual ObjectResult<UDP_Plani_EmpleadoComisiones_Update_Result> UDP_Plani_EmpleadoComisiones_Update(Nullable<int> cc_Id, Nullable<int> eMP_Id, Nullable<int> cc_UsuarioModifica, Nullable<System.DateTime> cc_FechaModifica, Nullable<decimal> cc_PorcentajeComision, Nullable<decimal> cc_TotalVenta)
        {
            var cc_IdParameter = cc_Id.HasValue ?
                new ObjectParameter("cc_Id", cc_Id) :
                new ObjectParameter("cc_Id", typeof(int));
    
            var eMP_IdParameter = eMP_Id.HasValue ?
                new ObjectParameter("EMP_Id", eMP_Id) :
                new ObjectParameter("EMP_Id", typeof(int));
    
            var cc_UsuarioModificaParameter = cc_UsuarioModifica.HasValue ?
                new ObjectParameter("cc_UsuarioModifica", cc_UsuarioModifica) :
                new ObjectParameter("cc_UsuarioModifica", typeof(int));
    
            var cc_FechaModificaParameter = cc_FechaModifica.HasValue ?
                new ObjectParameter("cc_FechaModifica", cc_FechaModifica) :
                new ObjectParameter("cc_FechaModifica", typeof(System.DateTime));
    
            var cc_PorcentajeComisionParameter = cc_PorcentajeComision.HasValue ?
                new ObjectParameter("cc_PorcentajeComision", cc_PorcentajeComision) :
                new ObjectParameter("cc_PorcentajeComision", typeof(decimal));
    
            var cc_TotalVentaParameter = cc_TotalVenta.HasValue ?
                new ObjectParameter("cc_TotalVenta", cc_TotalVenta) :
                new ObjectParameter("cc_TotalVenta", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Plani_EmpleadoComisiones_Update_Result>("UDP_Plani_EmpleadoComisiones_Update", cc_IdParameter, eMP_IdParameter, cc_UsuarioModificaParameter, cc_FechaModificaParameter, cc_PorcentajeComisionParameter, cc_TotalVentaParameter);
        }
    
        public virtual ObjectResult<UDP_Plani_tbCatalogoDeDeducciones_Activar_Result> UDP_Plani_tbCatalogoDeDeducciones_Activar(Nullable<int> cde_IdDeduccion, Nullable<int> cde_UsuarioModifica, Nullable<System.DateTime> cde_FechaModifica)
        {
            var cde_IdDeduccionParameter = cde_IdDeduccion.HasValue ?
                new ObjectParameter("cde_IdDeduccion", cde_IdDeduccion) :
                new ObjectParameter("cde_IdDeduccion", typeof(int));
    
            var cde_UsuarioModificaParameter = cde_UsuarioModifica.HasValue ?
                new ObjectParameter("cde_UsuarioModifica", cde_UsuarioModifica) :
                new ObjectParameter("cde_UsuarioModifica", typeof(int));
    
            var cde_FechaModificaParameter = cde_FechaModifica.HasValue ?
                new ObjectParameter("cde_FechaModifica", cde_FechaModifica) :
                new ObjectParameter("cde_FechaModifica", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Plani_tbCatalogoDeDeducciones_Activar_Result>("UDP_Plani_tbCatalogoDeDeducciones_Activar", cde_IdDeduccionParameter, cde_UsuarioModificaParameter, cde_FechaModificaParameter);
        }
    
        public virtual ObjectResult<UDP_Plani_tbCatalogoDeDeducciones_Inactivar_Result> UDP_Plani_tbCatalogoDeDeducciones_Inactivar(Nullable<int> cde_IdDeduccion, Nullable<int> cde_UsuarioModifica, Nullable<System.DateTime> cde_FechaModifica)
        {
            var cde_IdDeduccionParameter = cde_IdDeduccion.HasValue ?
                new ObjectParameter("cde_IdDeduccion", cde_IdDeduccion) :
                new ObjectParameter("cde_IdDeduccion", typeof(int));
    
            var cde_UsuarioModificaParameter = cde_UsuarioModifica.HasValue ?
                new ObjectParameter("cde_UsuarioModifica", cde_UsuarioModifica) :
                new ObjectParameter("cde_UsuarioModifica", typeof(int));
    
            var cde_FechaModificaParameter = cde_FechaModifica.HasValue ?
                new ObjectParameter("cde_FechaModifica", cde_FechaModifica) :
                new ObjectParameter("cde_FechaModifica", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Plani_tbCatalogoDeDeducciones_Inactivar_Result>("UDP_Plani_tbCatalogoDeDeducciones_Inactivar", cde_IdDeduccionParameter, cde_UsuarioModificaParameter, cde_FechaModificaParameter);
        }
    
        public virtual ObjectResult<UDP_Plani_tbCatalogoDeDeducciones_Insert_Result> UDP_Plani_tbCatalogoDeDeducciones_Insert(string cde_DescripcionDedu, Nullable<int> tde_IdTipoDedu, Nullable<decimal> cde_PorcentajeColaborador, Nullable<decimal> cde_PorcentajeEmpresa, Nullable<int> cde_UsuarioCrea, Nullable<System.DateTime> cde_FechaCrea)
        {
            var cde_DescripcionDeduParameter = cde_DescripcionDedu != null ?
                new ObjectParameter("cde_DescripcionDedu", cde_DescripcionDedu) :
                new ObjectParameter("cde_DescripcionDedu", typeof(string));
    
            var tde_IdTipoDeduParameter = tde_IdTipoDedu.HasValue ?
                new ObjectParameter("tde_IdTipoDedu", tde_IdTipoDedu) :
                new ObjectParameter("tde_IdTipoDedu", typeof(int));
    
            var cde_PorcentajeColaboradorParameter = cde_PorcentajeColaborador.HasValue ?
                new ObjectParameter("cde_PorcentajeColaborador", cde_PorcentajeColaborador) :
                new ObjectParameter("cde_PorcentajeColaborador", typeof(decimal));
    
            var cde_PorcentajeEmpresaParameter = cde_PorcentajeEmpresa.HasValue ?
                new ObjectParameter("cde_PorcentajeEmpresa", cde_PorcentajeEmpresa) :
                new ObjectParameter("cde_PorcentajeEmpresa", typeof(decimal));
    
            var cde_UsuarioCreaParameter = cde_UsuarioCrea.HasValue ?
                new ObjectParameter("cde_UsuarioCrea", cde_UsuarioCrea) :
                new ObjectParameter("cde_UsuarioCrea", typeof(int));
    
            var cde_FechaCreaParameter = cde_FechaCrea.HasValue ?
                new ObjectParameter("cde_FechaCrea", cde_FechaCrea) :
                new ObjectParameter("cde_FechaCrea", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Plani_tbCatalogoDeDeducciones_Insert_Result>("UDP_Plani_tbCatalogoDeDeducciones_Insert", cde_DescripcionDeduParameter, tde_IdTipoDeduParameter, cde_PorcentajeColaboradorParameter, cde_PorcentajeEmpresaParameter, cde_UsuarioCreaParameter, cde_FechaCreaParameter);
        }
    
        public virtual ObjectResult<UDP_Plani_tbCatalogoDeDeducciones_Update_Result> UDP_Plani_tbCatalogoDeDeducciones_Update(Nullable<int> cde_IdDeduccion, string cde_DescripcionDedu, Nullable<int> tde_IdTipoDedu, Nullable<decimal> cde_PorcentajeColaborador, Nullable<decimal> cde_PorcentajeEmpresa, Nullable<int> cde_UsuarioModifica, Nullable<System.DateTime> cde_FechaModifica)
        {
            var cde_IdDeduccionParameter = cde_IdDeduccion.HasValue ?
                new ObjectParameter("cde_IdDeduccion", cde_IdDeduccion) :
                new ObjectParameter("cde_IdDeduccion", typeof(int));
    
            var cde_DescripcionDeduParameter = cde_DescripcionDedu != null ?
                new ObjectParameter("cde_DescripcionDedu", cde_DescripcionDedu) :
                new ObjectParameter("cde_DescripcionDedu", typeof(string));
    
            var tde_IdTipoDeduParameter = tde_IdTipoDedu.HasValue ?
                new ObjectParameter("tde_IdTipoDedu", tde_IdTipoDedu) :
                new ObjectParameter("tde_IdTipoDedu", typeof(int));
    
            var cde_PorcentajeColaboradorParameter = cde_PorcentajeColaborador.HasValue ?
                new ObjectParameter("cde_PorcentajeColaborador", cde_PorcentajeColaborador) :
                new ObjectParameter("cde_PorcentajeColaborador", typeof(decimal));
    
            var cde_PorcentajeEmpresaParameter = cde_PorcentajeEmpresa.HasValue ?
                new ObjectParameter("cde_PorcentajeEmpresa", cde_PorcentajeEmpresa) :
                new ObjectParameter("cde_PorcentajeEmpresa", typeof(decimal));
    
            var cde_UsuarioModificaParameter = cde_UsuarioModifica.HasValue ?
                new ObjectParameter("cde_UsuarioModifica", cde_UsuarioModifica) :
                new ObjectParameter("cde_UsuarioModifica", typeof(int));
    
            var cde_FechaModificaParameter = cde_FechaModifica.HasValue ?
                new ObjectParameter("cde_FechaModifica", cde_FechaModifica) :
                new ObjectParameter("cde_FechaModifica", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Plani_tbCatalogoDeDeducciones_Update_Result>("UDP_Plani_tbCatalogoDeDeducciones_Update", cde_IdDeduccionParameter, cde_DescripcionDeduParameter, tde_IdTipoDeduParameter, cde_PorcentajeColaboradorParameter, cde_PorcentajeEmpresaParameter, cde_UsuarioModificaParameter, cde_FechaModificaParameter);
        }
    
        public virtual ObjectResult<UDP_Plani_tbDecimoTercerMes_Insert_Result> UDP_Plani_tbDecimoTercerMes_Insert(Nullable<int> emp_Id, Nullable<decimal> dtm_DecimoTercer)
        {
            var emp_IdParameter = emp_Id.HasValue ?
                new ObjectParameter("emp_Id", emp_Id) :
                new ObjectParameter("emp_Id", typeof(int));
    
            var dtm_DecimoTercerParameter = dtm_DecimoTercer.HasValue ?
                new ObjectParameter("dtm_DecimoTercer", dtm_DecimoTercer) :
                new ObjectParameter("dtm_DecimoTercer", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Plani_tbDecimoTercerMes_Insert_Result>("UDP_Plani_tbDecimoTercerMes_Insert", emp_IdParameter, dtm_DecimoTercerParameter);
        }
    
        public virtual ObjectResult<UDP_Plani_tbDeduccionesExtraordinarias_Activar_Result> UDP_Plani_tbDeduccionesExtraordinarias_Activar(Nullable<int> dex_IdDeduccionesExtra, Nullable<int> dex_UsuarioModifica, Nullable<System.DateTime> dex_FechaModifica)
        {
            var dex_IdDeduccionesExtraParameter = dex_IdDeduccionesExtra.HasValue ?
                new ObjectParameter("dex_IdDeduccionesExtra", dex_IdDeduccionesExtra) :
                new ObjectParameter("dex_IdDeduccionesExtra", typeof(int));
    
            var dex_UsuarioModificaParameter = dex_UsuarioModifica.HasValue ?
                new ObjectParameter("dex_UsuarioModifica", dex_UsuarioModifica) :
                new ObjectParameter("dex_UsuarioModifica", typeof(int));
    
            var dex_FechaModificaParameter = dex_FechaModifica.HasValue ?
                new ObjectParameter("dex_FechaModifica", dex_FechaModifica) :
                new ObjectParameter("dex_FechaModifica", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Plani_tbDeduccionesExtraordinarias_Activar_Result>("UDP_Plani_tbDeduccionesExtraordinarias_Activar", dex_IdDeduccionesExtraParameter, dex_UsuarioModificaParameter, dex_FechaModificaParameter);
        }
    
        public virtual ObjectResult<UDP_Plani_tbDeduccionesExtraordinarias_Inactivar_Result> UDP_Plani_tbDeduccionesExtraordinarias_Inactivar(Nullable<int> dex_IdDeduccionesExtra, Nullable<int> dex_UsuarioModifica, Nullable<System.DateTime> dex_FechaModifica)
        {
            var dex_IdDeduccionesExtraParameter = dex_IdDeduccionesExtra.HasValue ?
                new ObjectParameter("dex_IdDeduccionesExtra", dex_IdDeduccionesExtra) :
                new ObjectParameter("dex_IdDeduccionesExtra", typeof(int));
    
            var dex_UsuarioModificaParameter = dex_UsuarioModifica.HasValue ?
                new ObjectParameter("dex_UsuarioModifica", dex_UsuarioModifica) :
                new ObjectParameter("dex_UsuarioModifica", typeof(int));
    
            var dex_FechaModificaParameter = dex_FechaModifica.HasValue ?
                new ObjectParameter("dex_FechaModifica", dex_FechaModifica) :
                new ObjectParameter("dex_FechaModifica", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Plani_tbDeduccionesExtraordinarias_Inactivar_Result>("UDP_Plani_tbDeduccionesExtraordinarias_Inactivar", dex_IdDeduccionesExtraParameter, dex_UsuarioModificaParameter, dex_FechaModificaParameter);
        }
    
        public virtual ObjectResult<UDP_Plani_tbDeduccionesExtraordinarias_Insert_Result> UDP_Plani_tbDeduccionesExtraordinarias_Insert(Nullable<int> eqem_Id, Nullable<decimal> dex_MontoInicial, Nullable<decimal> dex_MontoRestante, string dex_ObservacionesComentarios, Nullable<int> cde_IdDeducciones, Nullable<decimal> dex_Cuota, Nullable<int> dex_UsuarioCrea, Nullable<System.DateTime> dex_FechaCrea)
        {
            var eqem_IdParameter = eqem_Id.HasValue ?
                new ObjectParameter("eqem_Id", eqem_Id) :
                new ObjectParameter("eqem_Id", typeof(int));
    
            var dex_MontoInicialParameter = dex_MontoInicial.HasValue ?
                new ObjectParameter("dex_MontoInicial", dex_MontoInicial) :
                new ObjectParameter("dex_MontoInicial", typeof(decimal));
    
            var dex_MontoRestanteParameter = dex_MontoRestante.HasValue ?
                new ObjectParameter("dex_MontoRestante", dex_MontoRestante) :
                new ObjectParameter("dex_MontoRestante", typeof(decimal));
    
            var dex_ObservacionesComentariosParameter = dex_ObservacionesComentarios != null ?
                new ObjectParameter("dex_ObservacionesComentarios", dex_ObservacionesComentarios) :
                new ObjectParameter("dex_ObservacionesComentarios", typeof(string));
    
            var cde_IdDeduccionesParameter = cde_IdDeducciones.HasValue ?
                new ObjectParameter("cde_IdDeducciones", cde_IdDeducciones) :
                new ObjectParameter("cde_IdDeducciones", typeof(int));
    
            var dex_CuotaParameter = dex_Cuota.HasValue ?
                new ObjectParameter("dex_Cuota", dex_Cuota) :
                new ObjectParameter("dex_Cuota", typeof(decimal));
    
            var dex_UsuarioCreaParameter = dex_UsuarioCrea.HasValue ?
                new ObjectParameter("dex_UsuarioCrea", dex_UsuarioCrea) :
                new ObjectParameter("dex_UsuarioCrea", typeof(int));
    
            var dex_FechaCreaParameter = dex_FechaCrea.HasValue ?
                new ObjectParameter("dex_FechaCrea", dex_FechaCrea) :
                new ObjectParameter("dex_FechaCrea", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Plani_tbDeduccionesExtraordinarias_Insert_Result>("UDP_Plani_tbDeduccionesExtraordinarias_Insert", eqem_IdParameter, dex_MontoInicialParameter, dex_MontoRestanteParameter, dex_ObservacionesComentariosParameter, cde_IdDeduccionesParameter, dex_CuotaParameter, dex_UsuarioCreaParameter, dex_FechaCreaParameter);
        }
    
        public virtual ObjectResult<UDP_Plani_tbDeduccionesExtraordinarias_Update_Result> UDP_Plani_tbDeduccionesExtraordinarias_Update(Nullable<int> dex_IdDeduccionesExtra, Nullable<int> eqem_Id, Nullable<decimal> dex_MontoInicial, Nullable<decimal> dex_MontoRestante, string dex_ObservacionesComentarios, Nullable<int> cde_IdDeducciones, Nullable<decimal> dex_Cuota, Nullable<int> dex_UsuarioModifica, Nullable<System.DateTime> dex_FechaModifica)
        {
            var dex_IdDeduccionesExtraParameter = dex_IdDeduccionesExtra.HasValue ?
                new ObjectParameter("dex_IdDeduccionesExtra", dex_IdDeduccionesExtra) :
                new ObjectParameter("dex_IdDeduccionesExtra", typeof(int));
    
            var eqem_IdParameter = eqem_Id.HasValue ?
                new ObjectParameter("eqem_Id", eqem_Id) :
                new ObjectParameter("eqem_Id", typeof(int));
    
            var dex_MontoInicialParameter = dex_MontoInicial.HasValue ?
                new ObjectParameter("dex_MontoInicial", dex_MontoInicial) :
                new ObjectParameter("dex_MontoInicial", typeof(decimal));
    
            var dex_MontoRestanteParameter = dex_MontoRestante.HasValue ?
                new ObjectParameter("dex_MontoRestante", dex_MontoRestante) :
                new ObjectParameter("dex_MontoRestante", typeof(decimal));
    
            var dex_ObservacionesComentariosParameter = dex_ObservacionesComentarios != null ?
                new ObjectParameter("dex_ObservacionesComentarios", dex_ObservacionesComentarios) :
                new ObjectParameter("dex_ObservacionesComentarios", typeof(string));
    
            var cde_IdDeduccionesParameter = cde_IdDeducciones.HasValue ?
                new ObjectParameter("cde_IdDeducciones", cde_IdDeducciones) :
                new ObjectParameter("cde_IdDeducciones", typeof(int));
    
            var dex_CuotaParameter = dex_Cuota.HasValue ?
                new ObjectParameter("dex_Cuota", dex_Cuota) :
                new ObjectParameter("dex_Cuota", typeof(decimal));
    
            var dex_UsuarioModificaParameter = dex_UsuarioModifica.HasValue ?
                new ObjectParameter("dex_UsuarioModifica", dex_UsuarioModifica) :
                new ObjectParameter("dex_UsuarioModifica", typeof(int));
    
            var dex_FechaModificaParameter = dex_FechaModifica.HasValue ?
                new ObjectParameter("dex_FechaModifica", dex_FechaModifica) :
                new ObjectParameter("dex_FechaModifica", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UDP_Plani_tbDeduccionesExtraordinarias_Update_Result>("UDP_Plani_tbDeduccionesExtraordinarias_Update", dex_IdDeduccionesExtraParameter, eqem_IdParameter, dex_MontoInicialParameter, dex_MontoRestanteParameter, dex_ObservacionesComentariosParameter, cde_IdDeduccionesParameter, dex_CuotaParameter, dex_UsuarioModificaParameter, dex_FechaModificaParameter);
        }
    }
}
