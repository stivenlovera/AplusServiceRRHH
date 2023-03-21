using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBAplusEmpresas.Usuarios;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class AuthenticationModule
    {
        private readonly ILogger<AuthenticationModule> _logger;
        private readonly AuthenticationRepository _authenticationRepository;
        private readonly UsuarioRepository _usuarioRepository;

        public AuthenticationModule(
            ILogger<AuthenticationModule> logger,
            AuthenticationRepository AuthenticationRepository,
            UsuarioRepository usuarioRepository
        )
        {
            this._logger = logger;
            this._authenticationRepository = AuthenticationRepository;
            this._usuarioRepository = usuarioRepository;
        }
        public async Task<Login> Login(string Usuario, string Password)
        {
            this._logger.LogWarning($"Module/Login({Usuario},{Password}) Inizialize ...");
            var verificar = await this._usuarioRepository.Login(Usuario, Password);
           return verificar;
        }
    }
}