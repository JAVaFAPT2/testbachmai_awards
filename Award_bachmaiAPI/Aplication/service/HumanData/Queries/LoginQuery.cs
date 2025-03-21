using Domain.models;
using MediatR;

namespace Aplication.service.HumanData.Queries
{
    public class LoginQuery : IRequest<Auth>
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginQuery(string username, string password)
        {
            Username = username;
            Password = password;
            
        }
    }
}

