using Domain.models;
using MediatR;

namespace Aplication.service.HumanData.Commands
{
    public class RegisterCommand : IRequest<Auth>
    {

        public string Username { get; set; }
        public string Password { get; set; }

        public RegisterCommand(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}

