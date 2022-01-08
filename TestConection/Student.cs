using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConection
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public uint Age { get; set; }
        public uint Grade { get; set; }

        public uint TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public override string ToString()
        {
            return $"Студент: имя = {Name}; фамилия {Surname}; возраст {Age}; Grade = {Grade}";
        }

    }
}
