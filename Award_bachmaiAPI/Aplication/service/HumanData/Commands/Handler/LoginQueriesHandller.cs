using System.Threading;
using System.Threading.Tasks;
using Aplication.service.HumanData.Queries;
using Domain.Interface;
using Domain.models;
using MediatR;

namespace Aplication.service.HumanData.Commands.Handler
{
    internal class LoginQueriesHandler : IRequestHandler<LoginQuery, Auth>
    {
        private readonly IAuthRepository _authRepository;

        public LoginQueriesHandler(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<Auth> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var user = await _authRepository.LoginAsync(request.Username, request.Password);
            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }

            return user;
        }
    }
}
