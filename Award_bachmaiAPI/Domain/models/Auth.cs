using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.models
{


    public class Auth
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public AuthRole Role { get; set; } = AuthRole.User;
        public Auth(string password, string username, AuthRole role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        //public Auth(int id, string username, string password, AuthRole role)
        //{
        //    Id = id;
        //    Username = username;
        //    Password = password;
        //    this.role = role;
        //}


        public Auth()
        {
        }
        public override string ToString()
        {
            return $"Id: {Id}, Username: {Username}, Password: {Password}, Role: {Role}";

        }


        public enum AuthRole
        {
            Admin,
            User
        }
    }
}
