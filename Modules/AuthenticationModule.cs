using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Repository;

namespace AplusServiceRRHH.Modules
{
    public class AuthenticationModule
    {
        private readonly ILogger<AuthenticationModule> _logger;
        private readonly AuthenticationRepository _authenticationRepository;

        public AuthenticationModule(
            ILogger<AuthenticationModule> logger,
            AuthenticationRepository AuthenticationRepository
        )
        {
            this._logger = logger;
            this._authenticationRepository = AuthenticationRepository;
        }
        public async Task<UsuarioEmpresa> Login(string Usuario, string Password)
        {
            this._logger.LogWarning($"Module/Login({Usuario},{Password}) Inizialize ...");
            var verificar = await this._authenticationRepository.LoginUserRepository(Usuario, Password);

            if (verificar != null)
            {
                this._logger.LogWarning($"Module/Login({Usuario},{Password}) SUCCESS => {true}");
                return verificar;
            }
            else
            {
                this._logger.LogWarning($"Module/Login({Usuario},{Password}) SUCCESS => {false}");
                throw new Exception("No existe Usuario Registrado");
            }


            //continuar
        }
    }
}