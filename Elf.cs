using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Elf : MiddleEarthCitizen
    {
        public Elf(int Power, string Name): base(Power, Name)
        {
            if ((Power >= 7) && (Power <= 4)) 
             { throw new Exception("Ошибка силы");}

        }
    }
}
