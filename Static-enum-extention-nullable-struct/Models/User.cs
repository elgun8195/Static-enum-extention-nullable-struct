using System;
using System.Collections.Generic;
using System.Text;

namespace Static_enum_extention_nullable_struct.Models
{
    internal class User : IAccount
    {

        private int Id;
        public string Fullname;
        public string Email;
        public string Password;




        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public bool PasswordChecker(string Password)
        {
            if (Password.Length >= 8 && HasUpper(Password) && HasDigit(Password) && HasLower(Password))
            {
                return true;
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id} - Fullname: {Fullname} - Email: {Email} - Password: {Password}");
        }





        public bool HasUpper(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                    return true;
            }
            return false;
        }

        public bool HasLower(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                    return true;
            }
            return false;
        }

        public bool HasDigit(string password)
        {
            foreach (var item in password)
            {
                if (char.IsDigit(item))
                    return true;
            }
            return false;
        }

    }
}
