﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearningInterfaceAndAbstractClassV0._2a
{
    class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        protected string funnyThingIHave; // We used protected access modificator for better encapsulation.
        public string FunnyThingIHave
        {
            get
            {
                return "Cześć dzieciaki! Mam " + funnyThingIHave;
            }
        }
        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}
