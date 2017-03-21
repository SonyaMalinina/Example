using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Orc : MiddleEarthCitizen
    {
        private Wolf Powerewolf; //{ get { return this.Powerewolf; } set { Powerewolf = value; } }
        // protected Wolf wolf

        public Orc(int Power, string Name, Wolf w): base(Power, Name)
        {
                if ((Power >= 10) && (Power <= 8)) 
             throw new Exception("Ошибка силы");
            Powerewolf = w;
            this.Power = this.Power + w.power;
        }
        protected Orc(int Power, string Name):base(Power, Name) { }

        public void FirstStrike() { }



        public class Wolf
        {
            public int power { get; set; }
            string name2; 

            public Wolf(int Powerewolf, string Name) 
            {
                if ((Powerewolf <= 7) || (Powerewolf >= 4)) { power = Powerewolf; }
                else
                {
                    throw new Exception("Ошибка силы");
                }
            }
        }
    }
}
