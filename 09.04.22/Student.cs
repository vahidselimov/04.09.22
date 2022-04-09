using System;
using System.Collections.Generic;
using System.Text;

namespace _09._04._22
{
    class Student : Person
    {
        private int _point { get; set; }
        public int Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value > 0 && value > 100)
                {
                    _point = value;
                }

            }
        }
        public int _id { get; set; }
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    _id = value;
                }
            }
        }
        public Student(string name, string surname, int point, int id, int age) : base(name, surname, age)
        {
            _point = point;
            Id = id;
        }





        public void Showinfo()
        {
            Console.WriteLine($"Name:{Name} Surname:{Surname} Age:{Age} Point:{Point} Id:{Id}");

        }
    }
}
