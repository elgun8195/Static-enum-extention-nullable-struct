using System;
using System.Collections.Generic;
using System.Text;

namespace Static_enum_extention_nullable_struct.Models
{
    internal class Student
    {
        private int _id = 0;
        private string Fullname;

        public int Point;
        public int Id
        {
            get { return this._id; }
        }


        public Student(string fullname, int point)
        {

            Fullname = fullname;
            Point = point;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"ID: {this.Id} - Fullname: {this.Fullname} - Point: {this.Point}");
        }

    }
}
