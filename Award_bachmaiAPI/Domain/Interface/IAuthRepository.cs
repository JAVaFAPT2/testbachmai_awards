using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IAuthRepository
    {
        Task<Auth> RegisterAsync(Auth user);
        Task<Auth> LoginAsync(string username, string password );
        Task<bool> UserExistsAsync(string username);
    }
}
