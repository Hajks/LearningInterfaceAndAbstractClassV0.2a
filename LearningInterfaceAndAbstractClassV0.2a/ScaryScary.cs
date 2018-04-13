using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaceAndAbstractClassV0._2a
{
   class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings): base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        public int numberOfScaryThings;
        
        public string ScaryThingIHave
        {
            get
            {
                return "Mam " + numberOfScaryThings + " pająków";
            }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Buuu! Mam cię! " + ScaryThingIHave);
        } 
    }
}
