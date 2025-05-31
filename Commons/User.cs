/**************************************************************************
 *                                                                        *
 *  File:        User.cs                                                  *
 *  Copyright:   (c) 2025, Check & Drive                                  *
 *  E-mail:      checkandrive@chestionarauto.ro                           *
 *  Description: Reprezintă un utilizator al aplicației, cu informații    *
 *               despre ID, nume de utilizator, nume real, email,         *
 *               parolă și rol.                                           *
 *                                                                        *
 *  Această aplicație a fost realizată de patru studenți ai Facultății de *
 *  Automatică și Calculatoare, în cadrul materiei Ingineria Programării. *
 *  Este oferită ca software liber, conform licenței GNU GPL.             *
 *  Poate fi redistribuită și/sau modificată, dar fără nicio garanție,    *
 *  nici măcar pentru adecvarea la un scop anume.                         *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChestionarAuto
{
    /// <summary>
    /// Reprezintă un utilizator al aplicației, cu informații despre ID, nume de utilizator, nume real, email, parolă și rol.
    /// </summary>
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
