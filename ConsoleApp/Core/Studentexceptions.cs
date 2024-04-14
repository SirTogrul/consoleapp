using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class Studentnotfound:Exception
    {
        public Studentnotfound(string message) : base(message) { }
    }
}
