using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Horse 
    {
        public int power1;
        public string name1;

        public Horse(int Power1, string Name1) 
        {
            if ((power1 <= 5) || (power1 >= 4)) { power1 = Power1; }
              else { throw new Exception("Ошибка силы"); }

            name1 = "HORSE ";
            
        }
    }
}
