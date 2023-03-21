using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Context;
using AplusServiceRRHH.Entities.DBAplusEmpresas.Usuarios;
using AplusServiceRRHH.Querys;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AplusServiceRRHH.Repository
{
    public class UsuarioRepository
    {
        private readonly ILogger<UsuarioRepository> _logger;
        private readonly DbMysqlServerContext _dbMysqlServerContext;
        private readonly UsuarioQuery _usuarioQuery;

        public UsuarioRepository(
            ILogger<UsuarioRepository> logger,
            DbMysqlServerContext dbMysqlServerContext,
            UsuarioQuery usuarioQuery
        )
        {
            this._logger = logger;
            this._dbMysqlServerContext = dbMysqlServerContext;
            this._usuarioQuery = usuarioQuery;
        }
        public async Task<Login> Login(string usuario, string contrasena)
        {
            this._logger.LogWarning($"UsuarioRepository/Login({usuario},{contrasena}): Inizialize...");
            var sql = this._usuarioQuery.Login(usuario,contrasena);
            var data = await this._dbMysqlServerContext.Login.FromSqlRaw(sql).ToListAsync();
            var resultado =data.FirstOrDefault();
            if (resultado != null)
            {
                this._logger.LogWarning($"UsuarioRepository/Login SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"UsuarioRepository/Login: Message => 'No se pudo logear correctamente' CONSULT => {sql}");
                throw new Exception("No se pudo logear correctamente");
            }
        }
        public async Task<List<UsuarioDataTable>> ObtenerUsuario()
        {
            this._logger.LogWarning($"UsuarioRepository/ObtenerUsuario(): Inizialize...");
            var sql = this._usuarioQuery.DataTableUsuario();
            var resultado = await this._dbMysqlServerContext.UsuarioDataTable.FromSqlRaw(sql).ToListAsync();
            if (resultado != null)
            {
                this._logger.LogWarning($"UsuarioRepository/ObtenerUsuario SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"UsuarioRepository/ObtenerUsuario: Message => 'No existe Usuarios Registrados' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<HHRRUsuario> ObtenerUsuarioId(int id)
        {
            this._logger.LogWarning($"UsuarioRepository/ObtenerUsuarioId(): Inizialize...");
            var sql = this._usuarioQuery.ObtenerUsuarioId(id);
            var data = await this._dbMysqlServerContext.HHRRUsuario.FromSqlRaw(sql).ToListAsync();
            var resultado = data.FirstOrDefault();
            if (resultado != null)
            {
                this._logger.LogWarning($"UsuarioRepository/ObtenerUsuarioId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return resultado;
            }
            else
            {
                this._logger.LogError($"UsuarioRepository/ObtenerUsuarioId: Message => 'No existe usuario Registrado' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
        public async Task<bool> CrearUsuarioId(string usuario, string contrasena, int HHRRcolaboradorId)
        {
            this._logger.LogWarning($"UsuarioRepository/CrearUsuarioId(): Inizialize...");
            var sql = this._usuarioQuery.GuardarUsuario(usuario, contrasena, HHRRcolaboradorId);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"UsuarioRepository/CrearUsuarioId SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"UsuarioRepository/CrearUsuarioId: Message => 'No existe pudo crear Usuario' CONSULT => {sql}");
                throw new Exception("No existe Usuario");
            }
        }
        public async Task<bool> ModificarUsuario(int id, string usuario, string contrasena, int HHRRcolaboradorId)
        {
            this._logger.LogWarning($"UsuarioRepository/UpdateUsuario(): Inizialize...");
            var sql = this._usuarioQuery.ModificarUsuario(id, usuario, contrasena, HHRRcolaboradorId);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"UsuarioRepository/ModificarUsuario SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"UsuarioRepository/ModificarUsuario: Message => 'No puso Modificar' CONSULT => {sql}");
                throw new Exception("No se pudo modificar usuario");
            }
        }
        public async Task<bool> EliminarUsuario(int id)
        {
            this._logger.LogWarning($"UsuarioRepository/EliminarUsuario({id}): Inizialize...");
            var sql = this._usuarioQuery.EliminarUsuario(id);
            var resultado = await this._dbMysqlServerContext.Database.ExecuteSqlRawAsync(sql);
            if (resultado == 1)
            {
                this._logger.LogWarning($"UsuarioRepository/EliminarUsuario SUCCESS => {JsonConvert.SerializeObject(resultado, Formatting.Indented)}");
                return true;
            }
            else
            {
                this._logger.LogError($"UsuarioRepository/EliminarUsuario: Message => 'Error al eliminar Usuario' CONSULT => {sql}");
                throw new Exception("No existe tipo documento");
            }
        }
    }
}