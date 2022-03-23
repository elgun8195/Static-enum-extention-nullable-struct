using System;
using System.Collections.Generic;
using System.Text;

namespace Static_enum_extention_nullable_struct.Models
{
    public interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
