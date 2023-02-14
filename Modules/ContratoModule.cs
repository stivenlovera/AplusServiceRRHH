using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas;
using AplusServiceRRHH.Entities.DBAplusEmpresas.Contrato;
using AplusServiceRRHH.Models;
using AplusServiceRRHH.Repository;
using AplusServiceRRHH.Utils;

namespace AplusServiceRRHH.Modules
{
    public class ContratoModule
    {
        private readonly ILogger<CargoModule> _logger;
        private readonly ColaboradorRepository _colaboradorRepository;
        private readonly GenerateDocumento _generateDocumento;
        private readonly EmpresaRepository _empresaRepository;

        public ContratoModule(
            ILogger<CargoModule> logger,
            ColaboradorRepository colaboradorRepository,
            GenerateDocumento generateDocumento,
            EmpresaRepository empresaRepository
        )
        {
            this._logger = logger;
            this._colaboradorRepository = colaboradorRepository;
            this._generateDocumento = generateDocumento;
            this._empresaRepository = empresaRepository;
        }
        public async Task<List<ColaboradorDataTable>> DataTableContratos()
        {
            var colaboradores = await this._colaboradorRepository.DatatableColaborador();
            return colaboradores;
        }
        public async Task<ContratoColaborador> EditarContratosColaborador(int id)
        {
            var colaboradores = await this._colaboradorRepository.EditarContratoColaborador(id);
            return colaboradores;
        }
        public async Task<bool> UpdateContratosColaborador(
                int id,
                DateTime FechaIngreso,
                int ModohaberBasico,
                decimal HaberBasico,
                int ModoQuincena,
                int ModoContrato,
                int TipoContrato,
                decimal HaberQuincena,
                string MotivoContrato,
                DateTime? FechaFinalizacion,
                DateTime FechaRatificacion,
                int AguinaldoMes1,
                int Aplica2aguinaldo
        )
        {
            var colaboradores = await this._colaboradorRepository.ModicarContratoColaborador(
                id,
                FechaIngreso,
                ModohaberBasico,
                HaberBasico,
                ModoQuincena,
                ModoContrato,
                TipoContrato,
                HaberQuincena,
                MotivoContrato,
                FechaFinalizacion,
                FechaRatificacion,
                AguinaldoMes1,
                Aplica2aguinaldo
            );
            return colaboradores;
        }
        public async Task<GenerarContrato> GenerarContrato(int id)
        {
            var empresa = await this._empresaRepository.ObtenerObtenerEmpresaIdRepository(1);
            var colaborador = await this._colaboradorRepository.EditarContratoColaborador(id);
            var contratoModel = new ContratoDefault
            {
                Cargo = "POR DEFINIR",
                Preview = false,
                NombreEmpresa = empresa.Nombre,
                ImagenEmpresa = "demo",
                NombreCompleto = $"{colaborador.Nombre1} {colaborador.Nombre2} {colaborador.Nombre3} {colaborador.ApellidoPaterno} {colaborador.ApellidoMaterno} {colaborador.ApellidoCasado}",
                FechaIngreso =colaborador.FechaIngreso,
                ModalidadContrato = "POR DEFINIR",
                haberBasico = colaborador.HaberBasico.ToString(),
                HaberQuincena = colaborador.HaberQuincena.ToString(),
                MotivoContratacion = colaborador.MotivoContrato,
            };
            var document = this._generateDocumento.GenerateContrato(contratoModel);
            //this._logger.LogWarning($"Documento { Convert.ToBase64String(document)}");
            return new GenerarContrato
            {
                nombreDocumento = contratoModel.NombreCompleto,
                File = document
            };
        }
        public async Task<ContratoColaborador> GenerarContratoPdf(int id)
        {
            var colaboradores = await this._colaboradorRepository.EditarContratoColaborador(id);
            return colaboradores;
        }
    }
    public class GenerarContrato
    {
        public string nombreDocumento { get; set; }
        public byte[] File { get; set; }
    }
}