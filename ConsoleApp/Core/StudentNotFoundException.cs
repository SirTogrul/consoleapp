using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
     public  class StudentNotFoundException:Exception
    {
        public StudentNotFoundException() : base("'Telebe tapilmadi.")
        {
        }

    }
    public class ClassroomNotFoundException : Exception
    {
        public ClassroomNotFoundException() : base("Classroom tapilmadi.") { }
    }
}
