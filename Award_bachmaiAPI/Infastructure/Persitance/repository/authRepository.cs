using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using Domain.models;
using Infastructure.Persitance.DbContext;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.Persitance.repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly WebAPIContext _context;

        public AuthRepository(WebAPIContext context)
        {
            _context = context;
        }

        public async Task<Auth> LoginAsync(string username, string password)
        {
            var user = await _context.Auths.FirstOrDefaultAsync(u => u.Username == username);
            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return null; // or throw an exception
            }

            return user;
        }

       public async Task<Auth> RegisterAsync(Auth user)
        {
            if (await UserExistsAsync(user.Username))
            {
                throw new ArgumentException("Username already exists.");
            }
            
            string password = user.Password;
            user.Password = BCrypt.Net.BCrypt.HashPassword(password);
            _context.Auths.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<bool> UserExistsAsync(string username)
        {
            return await _context.Auths.AnyAsync(u => u.Username == username);
        }

        //private bool VerifyPassword(Auth user, string password)
        //{
        //    // Implement your password verification logic here
        //    return user.Password == password; // Simplified for example purposes
        //}

        //private string HashPassword(string password)
        //{
        //    return BCrypt.Net.BCrypt.HashPassword(password);
        //}
    }
}

