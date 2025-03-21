using Domain.models;
using MediatR;
using static Domain.models.Auth;

namespace Aplication.service.HumanData.Commands
{
    public class RegisterCommand : IRequest<Auth>
    {

        public string Username { get; set; }
        public string Password { get; set; }

        public AuthRole role { get; set; }

        public RegisterCommand(string username, string password, AuthRole role)
        {
            Username = username;
            Password = password;
            this.role = role;
        }
    }
}

