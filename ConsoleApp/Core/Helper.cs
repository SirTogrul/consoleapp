using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core
{
    public class Helper
    {
        public static  bool Namechecker(string name)
        {
            return name.Length >= 3 && name.Split(' ').Length == 1 && char.IsUpper(name[0]);
        }
        public static bool Surnamechecker(string surname)
        {
            return surname.Length >= 3 && surname.Split(' ').Length == 1 && char.IsUpper(surname[0]);
        }
        public static bool Classnamechecker(string name)
        {
            return name.Length == 5 &&
                char.IsUpper(name[0]) &&
                char.IsUpper(name[1]) &&
                char.IsDigit(name[2]) &&
                char.IsDigit(name[3]) &&
                char.IsDigit(name[4]) &&
                char.IsDigit(name[5]);
        }
    }
          
}
