﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StaCatalina
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class StaCatalinaEntities : DbContext
    {
        public StaCatalinaEntities()
            : base("name=StaCatalinaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<varEmpresa> varEmpresa { get; set; }
        public virtual DbSet<stkMoviReqInterno> stkMoviReqInterno { get; set; }
        public virtual DbSet<comRequerimientoInterno> comRequerimientoInterno { get; set; }
        public virtual DbSet<comRequerimientoInternoItem> comRequerimientoInternoItem { get; set; }
        public virtual DbSet<comUsuarioEnviaMail> comUsuarioEnviaMail { get; set; }
        public virtual DbSet<TBL_Usuarios> TBL_Usuarios { get; set; }
        public virtual DbSet<comOrdenCompra> comOrdenCompra { get; set; }
        public virtual DbSet<comRequerimientoItem> comRequerimientoItem { get; set; }
        public virtual DbSet<comOrdenCompraDetalle> comOrdenCompraDetalle { get; set; }
        public virtual DbSet<stkMotivoAjuste> stkMotivoAjuste { get; set; }
    
        public virtual ObjectResult<REQUERIMIENTOS_INTERNO_PARA_MODIFICAR_Result> REQUERIMIENTOS_INTERNO_PARA_MODIFICAR(Nullable<int> sector, Nullable<int> idUsuario)
        {
            var sectorParameter = sector.HasValue ?
                new ObjectParameter("Sector", sector) :
                new ObjectParameter("Sector", typeof(int));
    
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<REQUERIMIENTOS_INTERNO_PARA_MODIFICAR_Result>("REQUERIMIENTOS_INTERNO_PARA_MODIFICAR", sectorParameter, idUsuarioParameter);
        }
    
        public virtual ObjectResult<TraeRequerimientoInternoItem_Result> TraeRequerimientoInternoItem(string codEmp, Nullable<int> requerimiento_id, Nullable<int> nivelAut_id)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            var requerimiento_idParameter = requerimiento_id.HasValue ?
                new ObjectParameter("requerimiento_id", requerimiento_id) :
                new ObjectParameter("requerimiento_id", typeof(int));
    
            var nivelAut_idParameter = nivelAut_id.HasValue ?
                new ObjectParameter("nivelAut_id", nivelAut_id) :
                new ObjectParameter("nivelAut_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TraeRequerimientoInternoItem_Result>("TraeRequerimientoInternoItem", codEmpParameter, requerimiento_idParameter, nivelAut_idParameter);
        }
    
        public virtual int ACTUALIZA_OBS_REQ_INTERNO(string codEmp, Nullable<int> nro, string obs, Nullable<int> depositoOrigenId, Nullable<int> sectorDepositoOrigenId, Nullable<int> depositoDestinoId, Nullable<int> sectorDepositoDestinoId)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            var nroParameter = nro.HasValue ?
                new ObjectParameter("nro", nro) :
                new ObjectParameter("nro", typeof(int));
    
            var obsParameter = obs != null ?
                new ObjectParameter("obs", obs) :
                new ObjectParameter("obs", typeof(string));
    
            var depositoOrigenIdParameter = depositoOrigenId.HasValue ?
                new ObjectParameter("DepositoOrigenId", depositoOrigenId) :
                new ObjectParameter("DepositoOrigenId", typeof(int));
    
            var sectorDepositoOrigenIdParameter = sectorDepositoOrigenId.HasValue ?
                new ObjectParameter("SectorDepositoOrigenId", sectorDepositoOrigenId) :
                new ObjectParameter("SectorDepositoOrigenId", typeof(int));
    
            var depositoDestinoIdParameter = depositoDestinoId.HasValue ?
                new ObjectParameter("DepositoDestinoId", depositoDestinoId) :
                new ObjectParameter("DepositoDestinoId", typeof(int));
    
            var sectorDepositoDestinoIdParameter = sectorDepositoDestinoId.HasValue ?
                new ObjectParameter("SectorDepositoDestinoId", sectorDepositoDestinoId) :
                new ObjectParameter("SectorDepositoDestinoId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ACTUALIZA_OBS_REQ_INTERNO", codEmpParameter, nroParameter, obsParameter, depositoOrigenIdParameter, sectorDepositoOrigenIdParameter, depositoDestinoIdParameter, sectorDepositoDestinoIdParameter);
        }
    
        public virtual ObjectResult<ORDEN_COMPRA_ABIERTAS_Result> ORDEN_COMPRA_ABIERTAS(Nullable<int> dias)
        {
            var diasParameter = dias.HasValue ?
                new ObjectParameter("Dias", dias) :
                new ObjectParameter("Dias", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ORDEN_COMPRA_ABIERTAS_Result>("ORDEN_COMPRA_ABIERTAS", diasParameter);
        }
    
        public virtual ObjectResult<TraeOrdenCompraItem_OC_Abiertas_Result> TraeOrdenCompraItem_OC_Abiertas(string codEmp, Nullable<int> ordenCompra_id)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            var ordenCompra_idParameter = ordenCompra_id.HasValue ?
                new ObjectParameter("ordenCompra_id", ordenCompra_id) :
                new ObjectParameter("ordenCompra_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TraeOrdenCompraItem_OC_Abiertas_Result>("TraeOrdenCompraItem_OC_Abiertas", codEmpParameter, ordenCompra_idParameter);
        }
    
        public virtual ObjectResult<ORDENCOMPRA_PARA_MODIFICAR_FECHA_BUSCADOR_Result> ORDENCOMPRA_PARA_MODIFICAR_FECHA_BUSCADOR(string codEmp, Nullable<int> nro)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            var nroParameter = nro.HasValue ?
                new ObjectParameter("Nro", nro) :
                new ObjectParameter("Nro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ORDENCOMPRA_PARA_MODIFICAR_FECHA_BUSCADOR_Result>("ORDENCOMPRA_PARA_MODIFICAR_FECHA_BUSCADOR", codEmpParameter, nroParameter);
        }
    
        public virtual ObjectResult<ORDENCOMPRA_PENDIENTES_DE_ENTREGA_BUSCADOR_Result> ORDENCOMPRA_PENDIENTES_DE_ENTREGA_BUSCADOR(string codEmp, Nullable<int> nro)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            var nroParameter = nro.HasValue ?
                new ObjectParameter("Nro", nro) :
                new ObjectParameter("Nro", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ORDENCOMPRA_PENDIENTES_DE_ENTREGA_BUSCADOR_Result>("ORDENCOMPRA_PENDIENTES_DE_ENTREGA_BUSCADOR", codEmpParameter, nroParameter);
        }
    
        public virtual int OrdenCompra_Indicador_Mensual(string empresa, Nullable<int> anio, Nullable<int> mes, Nullable<int> dias)
        {
            var empresaParameter = empresa != null ?
                new ObjectParameter("Empresa", empresa) :
                new ObjectParameter("Empresa", typeof(string));
    
            var anioParameter = anio.HasValue ?
                new ObjectParameter("Anio", anio) :
                new ObjectParameter("Anio", typeof(int));
    
            var mesParameter = mes.HasValue ?
                new ObjectParameter("Mes", mes) :
                new ObjectParameter("Mes", typeof(int));
    
            var diasParameter = dias.HasValue ?
                new ObjectParameter("Dias", dias) :
                new ObjectParameter("Dias", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("OrdenCompra_Indicador_Mensual", empresaParameter, anioParameter, mesParameter, diasParameter);
        }
    
        public virtual ObjectResult<OrdenCompraAbierta_SegunFacturaBejerman_Result> OrdenCompraAbierta_SegunFacturaBejerman(string empresa, Nullable<int> dias)
        {
            var empresaParameter = empresa != null ?
                new ObjectParameter("Empresa", empresa) :
                new ObjectParameter("Empresa", typeof(string));
    
            var diasParameter = dias.HasValue ?
                new ObjectParameter("Dias", dias) :
                new ObjectParameter("Dias", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<OrdenCompraAbierta_SegunFacturaBejerman_Result>("OrdenCompraAbierta_SegunFacturaBejerman", empresaParameter, diasParameter);
        }
    
        public virtual ObjectResult<CtaContable_Result> CtaContable()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CtaContable_Result>("CtaContable");
        }
    
        public virtual ObjectResult<H_CondPagoProveed_Result> H_CondPagoProveed(string codEmp, string proveed)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            var proveedParameter = proveed != null ?
                new ObjectParameter("Proveed", proveed) :
                new ObjectParameter("Proveed", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<H_CondPagoProveed_Result>("H_CondPagoProveed", codEmpParameter, proveedParameter);
        }
    
        public virtual int ExcluyeItemsReqInterno(string codEmp, Nullable<int> idReq, Nullable<int> nroItem, string motivo, string usuario, Nullable<bool> excluido)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            var idReqParameter = idReq.HasValue ?
                new ObjectParameter("idReq", idReq) :
                new ObjectParameter("idReq", typeof(int));
    
            var nroItemParameter = nroItem.HasValue ?
                new ObjectParameter("nroItem", nroItem) :
                new ObjectParameter("nroItem", typeof(int));
    
            var motivoParameter = motivo != null ?
                new ObjectParameter("Motivo", motivo) :
                new ObjectParameter("Motivo", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(string));
    
            var excluidoParameter = excluido.HasValue ?
                new ObjectParameter("excluido", excluido) :
                new ObjectParameter("excluido", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ExcluyeItemsReqInterno", codEmpParameter, idReqParameter, nroItemParameter, motivoParameter, usuarioParameter, excluidoParameter);
        }
    
        public virtual int FinalizaRequerimientoInterno(string codEmp, Nullable<int> requerimiento_id, string motivo, Nullable<System.DateTime> fechaFinalizacion, string usuarioFinaliza)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            var requerimiento_idParameter = requerimiento_id.HasValue ?
                new ObjectParameter("requerimiento_id", requerimiento_id) :
                new ObjectParameter("requerimiento_id", typeof(int));
    
            var motivoParameter = motivo != null ?
                new ObjectParameter("motivo", motivo) :
                new ObjectParameter("motivo", typeof(string));
    
            var fechaFinalizacionParameter = fechaFinalizacion.HasValue ?
                new ObjectParameter("fechaFinalizacion", fechaFinalizacion) :
                new ObjectParameter("fechaFinalizacion", typeof(System.DateTime));
    
            var usuarioFinalizaParameter = usuarioFinaliza != null ?
                new ObjectParameter("usuarioFinaliza", usuarioFinaliza) :
                new ObjectParameter("usuarioFinaliza", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("FinalizaRequerimientoInterno", codEmpParameter, requerimiento_idParameter, motivoParameter, fechaFinalizacionParameter, usuarioFinalizaParameter);
        }
    
        [DbFunction("StaCatalinaEntities", "TraeProveedorEmpresa")]
        public virtual IQueryable<TraeProveedorEmpresa_Result> TraeProveedorEmpresa(string codEmp, string proveed)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            var proveedParameter = proveed != null ?
                new ObjectParameter("Proveed", proveed) :
                new ObjectParameter("Proveed", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TraeProveedorEmpresa_Result>("[StaCatalinaEntities].[TraeProveedorEmpresa](@codEmp, @Proveed)", codEmpParameter, proveedParameter);
        }
    
        public virtual int ActualizaMailProveedor(string codEmp, string proveed, string mail)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            var proveedParameter = proveed != null ?
                new ObjectParameter("proveed", proveed) :
                new ObjectParameter("proveed", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizaMailProveedor", codEmpParameter, proveedParameter, mailParameter);
        }
    
        public virtual ObjectResult<ordenCompraSinStock_ParaModificar_Result> ordenCompraSinStock_ParaModificar(string codEmp, Nullable<int> ordenCompra_id)
        {
            var codEmpParameter = codEmp != null ?
                new ObjectParameter("codEmp", codEmp) :
                new ObjectParameter("codEmp", typeof(string));
    
            var ordenCompra_idParameter = ordenCompra_id.HasValue ?
                new ObjectParameter("ordenCompra_id", ordenCompra_id) :
                new ObjectParameter("ordenCompra_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ordenCompraSinStock_ParaModificar_Result>("ordenCompraSinStock_ParaModificar", codEmpParameter, ordenCompra_idParameter);
        }
    }
}
