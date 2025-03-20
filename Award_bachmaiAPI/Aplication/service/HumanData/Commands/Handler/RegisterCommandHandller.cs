using System.Threading;
using System.Threading.Tasks;
using Aplication.service.HumanData.Commands;
using Domain.Interface;
using Domain.models;
using MediatR;

namespace Aplication.service.HumanData.Commands.Handler
{
    internal class RegisterCommandHandler : IRequestHandler<RegisterCommand, Auth>
    {
        private readonly IAuthRepository _authRepository;

        public RegisterCommandHandler(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<Auth> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var user = new Auth
            {
                Username = request.Username,
                Password = request.Password
            };

            var registeredUser = await _authRepository.RegisterAsync(user, request.Password);
            return registeredUser;
        }
    }
}
