using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    public class User
    {
        public int userId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role {  get; set; }

        public User(int userId, string Username, string Name, string Email, string Password, string Role)
        {
            this.userId = userId;
            this.Username = Username;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.Role = Role;
        }
    }
}
