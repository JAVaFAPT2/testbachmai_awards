using Aplication.service.HumanData.Commands;
using Aplication.service.HumanData.Queries;

using Domain.Interface;
using Domain.models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.models.Auth;

namespace Infastructure.service
{
    public class AuthService(IMediator mediator) : IAuthService
    {
        private readonly IMediator _mediator = mediator;
        public async Task<Auth> LoginAsync(string email, string password)
        {
            return await _mediator.Send(new LoginQuery(email, password));
        }

        public async Task<Auth> RegisterAsync(string username,string password,AuthRole role)
        {
            return await _mediator.Send(new RegisterCommand(username, password, role));
        }
    }
}
