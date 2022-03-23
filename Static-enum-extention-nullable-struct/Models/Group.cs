using System;
using System.Collections.Generic;
using System.Text;

namespace Static_enum_extention_nullable_struct.Models
{
    internal class Group
    {
        public int GroupNo;
        public int StudentLimit;

        public int Studentlimit
        {
            get => Studentlimit;
            set
            {
                if (value >= 5 && value <= 18)
                {
                    Studentlimit = value;
                    return;
                }
            }
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]) && char.IsNumber(groupNo[2]) && char.IsNumber(groupNo[3]) && char.IsNumber(groupNo[4]))
            {
                return true;
            }
            return false;
        }


    }
}
