using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class UrukHai : Orc
    {
        public UrukHai(int Power, string Name) :base(Power, Name)
        {
                if ((Power >= 12) && (Power <= 10)) 

                    throw new Exception("Ошибка силы");
            
           

        }
    }
}
