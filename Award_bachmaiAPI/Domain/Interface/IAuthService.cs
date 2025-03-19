using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IAuthService
    {
        Task<Auth> RegisterAsync(string username,string password);
        Task<Auth> LoginAsync(string email, string password);
    }
}
