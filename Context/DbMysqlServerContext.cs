using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AplusServiceRRHH.Context
{
    public class DbMysqlServerContext : IdentityDbContext
    {
        public DbMysqlServerContext(DbContextOptions<DbMysqlServerContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public virtual DbSet<Contacto> Contacto { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<ImagenEmpresa> ImagenEmpresa { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<HHRRTipoDocumento> HHRRTipoDocumento { get; set; }
        public virtual DbSet<HHRRPais> HHRRPais { get; set; }
        public virtual DbSet<HHRRDepartamento> HHRRDepartamento { get; set; }
        public virtual DbSet<HHRRSexo> HHRRSexo { get; set; }
        public virtual DbSet<HHRREstadoCivil> HHRREstadoCivil { get; set; }
        public virtual DbSet<HHRRCargo> HHRRCargo { get; set; }
        public virtual DbSet<HHRRUnidad> HHRRUnidad { get; set; }
        public virtual DbSet<HHRRClasificacionLaboral> HHRRClasificacionLaboral { get; set; }
        public virtual DbSet<HHRRSucursal> HHRRSucursal { get; set; }
        public virtual DbSet<HHRROficina> HHRROficina { get; set; }
        public virtual DbSet<HHRRModContrato> HHRRModContrato { get; set; }
        public virtual DbSet<HHRRTipoContrato> HHRRTipoContrato { get; set; }
        public virtual DbSet<HHRRInformacionContable> HHRRInformacionContable { get; set; }
        public virtual DbSet<HHRRCentroCosto> HHRRCentroCosto { get; set; }
        public virtual DbSet<HHRRFormaPago> HHRRFormaPago { get; set; }
        public virtual DbSet<HHRRTipoCuenta> HHRRTipoCuenta { get; set; }
        public virtual DbSet<HHRRBanco> HHRRBanco { get; set; }
        public virtual DbSet<HHRRAdministracionPesion> HHRRAdministracionPesion { get; set; }
        public virtual DbSet<HHRRCajaSalud> HHRRCajaSalud { get; set; }
        public virtual DbSet<HHRRFormacionPrincipal> HHRRFormacionPrincipal { get; set; }
        public virtual DbSet<HHRRColaborador> HHRRColaborador { get; set; }
        //query
        public virtual DbSet<ColaboradorDataTable> ColaboradorDataTable { get; set; }
    }
}