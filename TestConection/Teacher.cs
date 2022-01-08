using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConection
{
    public class Teacher
    {
        public Teacher()
        {
            Students = new List<Student>();

        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public uint Age { get; set; }
        public string Subject { get; set; }
        public virtual List<Student> Students { get; set; } //навигационное свойство

        public override string ToString()
        {
            return $"Учитель: имя = {Name}; фамилия {Surname}; возраст {Age}; Прпдемет = {Subject}";
        }

    }
}
