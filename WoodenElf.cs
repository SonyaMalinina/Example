using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class WoodenElf : Elf
    {
        public WoodenElf(int Power, string Name): base(Power, Name)
        {
                if ((Power!=6) ) 
       
                    throw new Exception("Ошибка силы");
            
        }
    }
}
