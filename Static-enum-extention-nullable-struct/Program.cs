using System;
using Static_enum_extention_nullable_struct.Models;

namespace Static_enum_extention_nullable_struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("email@gmail.com", "Elgun8195");
            user.Fullname = "Elgun Qocayev";
            user.ShowInfo();
            Student student1 = new Student("AdSoyad", 100);
            student1.ShowInfo();
            Student student2 = new Student("AdSoyad2", 90);
            student2.ShowInfo();

        }
    }
}
