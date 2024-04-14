using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public  class Student
    {
        private static int _id;
        public int Id { set; get; }
        public string Name { set; get; }
        public string SurName { set; get; }
        public Student()
        {
            _id++;
            Id = _id;
        }
        public override string ToString()
        {
            return $"{Name} {SurName} {Id}";
        }
    }
}
