using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Goblin : MiddleEarthCitizen
    {
        public Goblin (int Power, string Name): base(Power, Name)
        {
                if ((Power >= 5) && (Power <= 2))
                {throw new Exception("Ошибка силы");}
            

        }
    }
}
